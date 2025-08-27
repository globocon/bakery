// AJAX filter for product selection

let productingredient_Table;
let bulkeditproductingredient_Table;
let productIdToEdit = 0;
let mapTypeList = [];

$(function () {

    productingredient_Table = $('#productingredientTable').DataTable({
        lengthMenu: [[10, 25, 50, 100, 1000], [10, 25, 50, 100, 1000]],
        paging: true,
        pagingType: "full_numbers",
        ordering: true,
        scrollCollapse: true,
        fixedHeader: true,
        order: [[0, "desc"]],
        info: false,
        scrollX: true,
        searching: true,
        autoWidth: false,
        ajax: {
            url: './ProductIngredients?handler=ShowAllProductIngredientsMapping',
            type: 'GET',
            dataSrc: '',
            headers: { 'RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val() },
        },
        columns: [
            { data: 'id', visible: false },
            { data: 'productId', visible: false },
            { data: 'rawMaterialId', visible: false },
            { data: 'product.name', width: '30%', title: "Product" },
            { data: 'rawMaterial.name', width: '30%', title: "Ingredient" },
            { data: 'mapType', width: '10%', title: "Map Type" },
            {
                data: 'quantityRequired',
                width: '10%',
                title: "Quantity",
                className: "text-end",
                render: function (data, type, row) {
                    return `${parseFloat(data).toFixed(7)}`;
                }
            },
            { data: 'rawMaterial.unit', width: '3%', className: "text-center", title: "Uom" },
            {
                data: 'showInReport',
                width: '10%',
                title: "Show in Report",
                className: "text-center",
                render: function (data, type, row) {
                    let checked = data === true ? 'Yes' : 'No';
                    return `${checked}`;
                }
            },
            { data: 'id' } // Placeholder for actions, real config below
        ],
        columnDefs: [
            {
                targets: -1,
                orderable: false,
                width: '10%',
                title: "Action",
                className: "text-center",
                render: function (data, type, row) {
                    return `
                    <div class="d-flex justify-content-center">
                        <button type="button" data-id="${data}" class="btn btn-sm btn-outline-primary px-2 mx-2" onclick="editProductIngredient(this);">
                            <i class="bx bx-edit me-0"></i>
                        </button>
                        <button type="button" data-id="${data}" class="btn btn-sm btn-outline-danger px-2 mx-2" onclick="deleteProductIngredientMapping(this);">
                            <i class="bx bx-trash me-0"></i>
                        </button>
                    </div>
                `;
                }
            }
        ]
    });

    /* To add bottom space to the datatable filter input */
    $('div.dataTables_filter').addClass('mb-2');

    $('#btn_modal_bulkeditproductingredient_save').on('click', function (e) {
        e.preventDefault();                
                
        var result = false;
        result = validateBootstrapForm('frmMdlEditProductIngredient');
        if (!result) {
            round_warning_noti && round_warning_noti('Please correct the errors.');
            return;
        }

        let productIngredientAddModal = [];

        bulkeditproductingredient_Table.rows().every(function () {
            const row = $(this.node());
            const data = this.data();

            const quantity = parseFloat(row.find('input[type="number"]').val()).toFixed(7) || 0;
            const mapType = row.find('select.map-type-dropdown').val() || 'Mix';
            const showInReport = row.find('input.show-report-checkbox').is(':checked');

            productIngredientAddModal.push({
                id: data.id,
                productId: data.productId,
                rawMaterialId: data.rawMaterialId,
                quantityRequired: quantity,
                mapType: mapType,
                showInReport: showInReport
            });
        });              
                
        $.ajax({
            url: window.location.pathname + '?handler=BulkUpdateProductIngredientMapping',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(productIngredientAddModal),
            headers: { 'RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val() },
            success: function (data) {
                if (!data.status) {
                    round_error_noti && round_error_noti(data.message);
                }
                else {
                    round_success_noti && round_success_noti(data.message);
                    $('#EditProductIngredientModal').modal('hide');
                    productingredient_Table.ajax.reload();
                }
            },
            error: function () {
                round_error_noti && round_error_noti('Failed to save mapping.');
            }
        });
    });

    //$('#btn_modal_editproductingredient_save').on('click', function (e) {
    //    e.preventDefault();
    //    $('#ProductIngredientAddModal_ProductId').val($('#select_modal_addproductingredient_Product :selected').val());
    //    $('#ProductIngredientAddModal_RawMaterialId').val($('#select_modal_addproductingredient_RawMaterial :selected').val());

    //    var selected = $('#select_modal_addproductingredient_MapType').select2('data')[0];
    //    $('#ProductIngredientAddModal_MapType').val(selected.id);

    //    var result = false;
    //    result = validateBootstrapForm('frmMdlAddProductIngredient');
    //    if (!result) {
    //        round_warning_noti && round_warning_noti('Please correct the errors.');
    //        return;
    //    }

    //    var operation = $('#ProductIngredientAddEditModal_Operation').val();
    //    var handler = '?handler='
    //    if (operation === 'ADD') {
    //        handler += 'SaveProductIngredientMapping';
    //    } else {
    //        handler += 'UpdateProductIngredientMapping';
    //    }

    //    $.ajax({
    //        url: window.location.pathname + handler,
    //        type: 'POST',
    //        DataType: 'json',
    //        data: $('#frmMdlAddProductIngredient').serialize(),
    //        headers: { 'RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val() },
    //        success: function (data) {
    //            if (!data.status) {
    //                round_error_noti && round_error_noti(data.message);
    //            }
    //            else {
    //                round_success_noti && round_success_noti(data.message);
    //                $('#AddProductIngredientModal').modal('hide');
    //                productingredient_Table.ajax.reload();
    //            }
    //        },
    //        error: function () {
    //            round_error_noti && round_error_noti('Failed to save mapping.');
    //        }
    //    });
    //});

    $('#btn_add_Product_Ingredient').on('click', function (e) {
        e.preventDefault();
        addProductIngredient();
    });

    loadMapTypeList().done(() => {
        bulkeditproductingredient_Table = $('#bulkeditproductingredientTable').DataTable({
            lengthMenu: [[10, 25, 50, 100, 1000], [10, 25, 50, 100, 1000]],
            paging: false,
            pagingType: "full_numbers",
            ordering: false,
            autoload: false,
            scrollCollapse: true,
            fixedHeader: true,
            order: [[3, "asc"]],
            info: false,
            scrollX: true,
            searching: false,
            autoWidth: false,
            ajax: {
                url: './ProductIngredients?handler=ShowAllIngredientsMappingOfProductForBulkEdit',
                type: 'GET',
                data: function (d) {
                    d.ProductId = productIdToEdit;
                },
                dataSrc: '',
                headers: { 'RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val() },
            },
            columns: [
                { data: 'id', visible: false },
                { data: 'productId', visible: false },
                { data: 'rawMaterialId', visible: false },
                { data: 'rawMaterial.name', width: '40%', title: "Ingredient" },
                {
                    data: 'mapType',
                    width: '10%',
                    title: "Map Type",
                    render: function (data, type, row, meta) {
                        let options = mapTypeList.map(opt => {
                            let selected = (opt.mapTypeName === data) ? 'selected' : '';
                            return `<option value="${opt.mapTypeName}" ${selected}>${opt.mapTypeName}</option>`;
                        }).join('');
                        return `<select class="form-select form-select-sm map-type-dropdown" data-id="${row.id}" required>${options}</select>`;
                    }
                },
                {
                    data: 'showInReport',
                    width: '5%',
                    title: "Show in Report",
                    className: "text-center",
                    render: function (data, type, row) {
                        let checked = data === true ? 'checked' : '';
                        return `<input type="checkbox" class="form-check-input show-report-checkbox" data-id="${row.id}" ${checked} />`;
                    }
                },
                {
                    data: 'quantityRequired',
                    width: '10%',
                    className: "text-end",
                    title: "Required Quantity",
                    render: function (data, type, row, meta) {
                        return `<input type="number" class="form-control text-end py-1" value="${parseFloat(data).toFixed(7)}" data-id="${row.id}" style="width: 100%;" step="0.0000001" required/>`;
                    }
                },
                { data: 'rawMaterial.unit', width: '3%', className: "text-center", title: "Uom" }
            ],
            columnDefs: []
        });
    });

    function loadMapTypeList() {
        return $.ajax({
            url: '/ProductIngredients?handler=FetchMappingTypes',
            type: 'GET',
            headers: {
                'RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val()
            },
            success: function (data) {
                mapTypeList = data;
            }
        });
    }
       
});

//var editProductIngredient = function (t) {
//    var row = productingredient_Table.row($(t).closest('tr')).data(); // Use the existing instance

//    if (row) {
//        // console.log(row); // Full row data
//        //Reset Form Validation
//        resetBootstrapValidation('frmMdlAddProductIngredient');
//        $('#addProductIngredientModalTitle').html('Edit Product Ingredient');
//        $('#ProductIngredientAddModal_Id').val(row.id);
//        $('#ProductIngredientAddModal_ProductId').val(row.productId);
//        $('#ProductIngredientAddModal_RawMaterialId').val(row.rawMaterialId);
//        $('#ProductIngredientAddModal_MapType').val(row.mapType);
//        $('#ProductIngredientAddModal_QuantityRequired').val(row.quantityRequired);        
        
//        setShowInReport(row.showInReport);

//        $('#select_modal_addproductingredient_Product').val(row.productId).trigger('change');
//        $('#select_modal_addproductingredient_RawMaterial').val(row.rawMaterialId).trigger('change');
//        $('#select_modal_addproductingredient_MapType').val(row.mapType).trigger('change');   


//        $('#select_modal_addproductingredient_Product').prop('disabled', true);
//        $('#select_modal_addproductingredient_RawMaterial').prop('disabled', true);

//        $('#ProductIngredientAddEditModal_Operation').val('EDIT');
//        $('#AddProductIngredientModal').modal('show');

//    }
//};
var editProductIngredient = function (t) {
    var row = productingredient_Table.row($(t).closest('tr')).data(); // Use the existing instance

    if (row) {
        //Reset Form Validation
        resetBootstrapValidation('frmMdlEditProductIngredient');
        productIdToEdit = row.productId;
        $('#bulkeditproductingredientTable').DataTable().clear().ajax.reload();  
        var prdnme = 'Edit [' + row.product.name + ']';
        $('#editProductIngredientModalTitle').html(prdnme);
        $('#EditProductIngredientModal').modal('show');
    }
};

$('#EditProductIngredientModal').on('shown.bs.modal', function () {
    $('#bulkeditproductingredientTable').DataTable().columns.adjust();
});

var addProductIngredient = function () {
    //Reset Form Validation
    resetBootstrapValidation('frmMdlAddProductIngredient');
    $('#addProductIngredientModalTitle').html('Add Product Ingredient');
    $('#ProductIngredientAddModal_Id').val('0');
    $('#ProductIngredientAddModal_ProductId').val('0');
    $('#ProductIngredientAddModal_RawMaterialId').val('0');
    $('#ProductIngredientAddModal_MapType').val();
    $('#ProductIngredientAddModal_QuantityRequired').val('0.0000001');


    $('#select_modal_addproductingredient_Product').prop('disabled', false);
    $('#select_modal_addproductingredient_RawMaterial').prop('disabled', false);

    $('#select_modal_addproductingredient_Product').val(null).trigger('change');
    $('#select_modal_addproductingredient_RawMaterial').val(null).trigger('change');
    $('#select_modal_addproductingredient_MapType').val(null).trigger('change');
    $('#ProductIngredientAddEditModal_Operation').val('ADD');
    $('#AddProductIngredientModal').modal('show');
};

var deleteProductIngredientMapping = function (t) {
    var rwid = $(t).data('id');
    var row = productingredient_Table.row($(t).closest('tr')).data(); // Use the existing instance
    if (row) {
        Lobibox.confirm({
            msg: "Are you sure you want to delete this mapping ?",
            callback: function (lobibox, type) {
                if (type === 'yes') {
                    $.ajax({
                        url: window.location.pathname + '?handler=DeleteProductIngredientMapping',
                        data: { id: parseInt(row.id) },
                        type: 'POST',
                        headers: { 'RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val() }
                    }).done(function (data) {
                        if (!data.status) {
                            round_error_noti && round_error_noti(data.message);
                        }
                        else {
                            round_success_noti && round_success_noti(data.message);
                            productingredient_Table.ajax.reload(); // Reload the table data
                        }
                    }).fail(function () {
                        round_error_noti && round_error_noti('Failed to delete mapping.');
                    });
                }
            }
        });
    }
};


function setShowInReport(value) {
    // Convert boolean to string if needed
    var targetValue = value ? "true" : "false";

    // Find the radio with the matching value
    var radio = document.querySelector(
        'input[name="ProductRawMaterialAddModal.ShowInReport"][value="' + targetValue + '"]'
    );

    if (radio) {
        radio.checked = true;
    }
}
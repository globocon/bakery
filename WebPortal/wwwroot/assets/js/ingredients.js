// AJAX filter for ingredient selection
let ingredients_Table;
$(document).ready(function () {
    
    ingredients_Table = $('#ingredientsTable').DataTable({
        lengthMenu: [[10, 25, 50, 100, 1000], [10, 25, 50, 100, 1000]],
        paging: true,
        pagingType: "full_numbers",
        ordering: true,
        scrollCollapse: true,
        fixedHeader: true,
        order: [1, "asc"],
        info: false,
        scrollX: true,
        searching: true,
        autoWidth: false,
        ajax: {
            url: window.location.pathname + '?handler=ShowAllIngredient',
            type: 'GET',
            dataSrc: '',
            headers: { 'RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val() },
        },
        columns: [
            { data: 'id', visible: false },
            { data: 'ingredientName', width: '50%', title: "Ingredient Name" },
            {
                data: 'cp',
                width: '10%',
                className: "text-end",
                title: "Cost Price",
                render: function (data, type, row) {
                    return parseFloat(data).toFixed(2);
                }
            },
            {
                data: 'sysStockQty',
                width: '10%',
                className: "text-end",
                title: "System Stock Qty",
                render: function (data, type, row) {
                    return parseFloat(data).toFixed(3);
                }
            },
            { data: 'uom', width: '10%', className: "text-center", title: "UOM" },
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
                        <button type="button" data-id="${data}" class="btn btn-sm btn-outline-primary px-2 mx-2" onclick="editIngredient(this);">
                            <i class="bx bx-edit me-0"></i>
                        </button>
                        <button type="button" data-id="${data}" class="btn btn-sm btn-outline-danger px-2 mx-2" onclick="deleteIngredient(this);">
                            <i class="bx bx-trash me-0"></i>
                        </button>
                    </div>
                `;
                }
            }
        ]
    });

    // To add bottom space to the datatable filter input
    $('div.dataTables_filter').addClass('mb-2');

    $('#btn_modal_editingredient_save').on('click', function (e) {       
        e.preventDefault();
        $('#IngredientAddEditModal_UOM').val($('#select_modal_editingredient_uom :selected').val());

        var result = false;
        result = validateBootstrapForm('frmMdlEditIngredient');
        if (!result) {
            round_warning_noti && round_warning_noti('Please correct the errors.');
            return;
        }

        var operation = $('#IngredientAddEditModal_Operation').val();
        var handler = '?handler='
        if (operation === 'ADD') {
            handler += 'SaveIngredient';
        } else {
            handler += 'UpdateIngredient';
        }

        $.ajax({
            url: window.location.pathname + handler,
            type: 'POST',
            DataType: 'json',
            data: $('#frmMdlEditIngredient').serialize(),
            headers: { 'RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val() }, 
            success: function (data) {
                if (!data.status) {
                    round_error_noti && round_error_noti(data.message);                    
                }
                else {
                    round_success_noti && round_success_noti(data.message);
                    $('#EditIngredientModal').modal('hide');
                    ingredients_Table.ajax.reload(); // Reload the table data
                }                
            },
            error: function () {
                round_error_noti && round_error_noti('Failed to save ingredient.');
            }
        });
    });

    $('#btn_add_ingredient').on('click', function (e) {
        e.preventDefault();
        addIngredient();
    });
         
});


var editIngredient = function (t) {
    var row = ingredients_Table.row($(t).closest('tr')).data(); // Use the existing instance

    if (row) {
        // console.log(row); // Full row data
        //Reset Form Validation
        resetBootstrapValidation('frmMdlEditIngredient');
        $('#addEditModalTitle').html('Edit Ingredient');
        $('#IngredientAddEditModal_Id').val(row.id);
        // Set uom dropdown
        $('#select_modal_editingredient_uom').val(null).trigger('change');
        $('#select_modal_editingredient_uom').val(row.uom.toLowerCase()).trigger('change'); // Or row.uom based on your data
        $('#IngredientAddEditModal_UOM').val(row.uom);
        $('#IngredientAddEditModal_IngredientName').val(row.ingredientName);
        $('#IngredientAddEditModal_CP').val(row.cp);
        $('#IngredientAddEditModal_SysStockQty').val(row.sysStockQty);
        $('#IngredientAddEditModal_PhyStockQty').val(0.000);
        $('#IngredientAddEditModal_Operation').val('EDIT');
        $('#EditIngredientModal').modal('show');              

        //var selectElement = $('#select_modal_editingredient_category option:selected').text();
        //var cotid = $('#select_modal_editingredient_category :selected').val(); //for getting value from selected option
    }
};

var addIngredient = function () {
    //Reset Form Validation
    resetBootstrapValidation('frmMdlEditIngredient');
    $('#addEditModalTitle').html('Add Ingredient');
    $('#IngredientAddEditModal_Id').val('0');
    $('#IngredientAddEditModal_UOM').val('');
    $('#select_modal_editingredient_uom').val(null).trigger('change');
    $('#IngredientAddEditModal_IngredientName').val('');
    $('#IngredientAddEditModal_CP').val('');
    $('#IngredientAddEditModal_SysStockQty').val(0.000);
    $('#IngredientAddEditModal_PhyStockQty').val(0.000);
    $('#IngredientAddEditModal_Operation').val('ADD');
    $('#EditIngredientModal').modal('show');
};
       
var deleteIngredient = function (t) {
    var rwid = $(t).data('id');
    var row = ingredients_Table.row($(t).closest('tr')).data(); // Use the existing instance
    if (row) {
        Lobibox.confirm({
            msg: "Are you sure you want to delete " + row.ingredientName + " ?",
            callback: function (lobibox, type) {
                if (type === 'yes') {                    
                    $.ajax({
                        url: window.location.pathname + '?handler=DeleteIngredient',
                        data: { id: parseInt(row.id) },
                        type: 'POST',
                        headers: { 'RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val() }
                    }).done(function (data) {
                        if (!data.status) {
                            round_error_noti && round_error_noti(data.message);
                        }
                        else {
                            round_success_noti && round_success_noti(data.message);
                            ingredients_Table.ajax.reload(); // Reload the table data
                        }
                    }).fail(function () {
                        round_error_noti && round_error_noti('Failed to delete ingredient.');
                    });
                }
            }
        });
    }    
};




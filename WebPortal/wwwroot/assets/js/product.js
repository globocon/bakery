// AJAX filter for product selection
let products_Table;
$(document).ready(function () {
    
    products_Table = $('#productsTable').DataTable({
        lengthMenu: [[5, 10, 25, 50, 100, 1000], [5, 10, 25, 50, 100, 1000]],
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
            url: './Products?handler=ShowAllProducts',
            type: 'GET',
            dataSrc: '',
            headers: { 'RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val() },
        },
        columns: [
            { data: 'id', visible: false },
            { data: 'categoryId', visible: false },
            { data: 'name', width: '50%', title: "Product Name" },
            { data: 'category.name', width: '30%', title: "Category" },
            { data: 'mrp', width: '10%', className: "text-center", title: "Mrp" },
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
                        <button type="button" data-id="${data}" class="btn btn-sm btn-outline-primary px-2 mx-2" onclick="editProduct(this);">
                            <i class="bx bx-edit me-0"></i>
                        </button>
                        <button type="button" data-id="${data}" class="btn btn-sm btn-outline-danger px-2 mx-2" onclick="deleteProduct(this);">
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

    $('#btn_modal_editproduct_save').on('click', function (e) {       
        e.preventDefault();
        $('#ProductAddEditModal_CategoryId').val($('#select_modal_editproduct_category :selected').val());


        var result = false;
        result = validateBootstrapForm('frmMdlEditProduct');
        if (!result) {
            round_warning_noti && round_warning_noti('Please correct the errors.');
            return;
        }

        var operation = $('#ProductAddEditModal_Operation').val();
        var handler = '?handler='
        if (operation === 'ADD') {
            handler += 'SaveProduct';
        } else {
            handler += 'UpdateProduct';
        }

        $.ajax({
            url: window.location.pathname + handler,
            type: 'POST',
            DataType: 'json',
            data: $('#frmMdlEditProduct').serialize(),
            headers: { 'RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val() }, 
            success: function (data) {
                if (!data.status) {
                    round_error_noti && round_error_noti(data.message);                    
                }
                else {
                    round_success_noti && round_success_noti(data.message);
                    $('#EditProductModal').modal('hide');
                    products_Table.ajax.reload(); // Reload the table data
                }                
            },
            error: function () {
                round_error_noti && round_error_noti('Failed to save product.');
            }
        });
    });

    $('#btn_add_product').on('click', function (e) {
        e.preventDefault();
        addProduct();
    });
         
});


var editProduct = function (t) {
    var row = products_Table.row($(t).closest('tr')).data(); // Use the existing instance

    if (row) {
        // console.log(row); // Full row data
        //Reset Form Validation
        resetBootstrapValidation('frmMdlEditProduct');
        $('#addEditModalTitle').html('Edit Product');
        $('#ProductAddEditModal_Id').val(row.id);
        // Set category dropdown
        $('#select_modal_editproduct_category').val(null).trigger('change');
        $('#select_modal_editproduct_category').val(row.categoryId).trigger('change'); // Or row.categoryId based on your data
        $('#ProductAddEditModal_CategoryId').val(row.categoryId);
        $('#ProductAddEditModal_ProductName').val(row.name);
        $('#ProductAddEditModal_MRP').val(row.mrp);
        $('#ProductAddEditModal_Operation').val('EDIT');
        $('#EditProductModal').modal('show');              

        //var selectElement = $('#select_modal_editproduct_category option:selected').text();
        //var cotid = $('#select_modal_editproduct_category :selected').val(); //for getting value from selected option
    }
};

var addProduct = function () {
    //Reset Form Validation
    resetBootstrapValidation('frmMdlEditProduct');
    $('#addEditModalTitle').html('Add Product');
    $('#ProductAddEditModal_Id').val('0');
    $('#ProductAddEditModal_CategoryId').val('');
    $('#select_modal_editproduct_category').val(null).trigger('change');
    $('#ProductAddEditModal_ProductName').val('');
    $('#ProductAddEditModal_MRP').val('');
    $('#ProductAddEditModal_Operation').val('ADD');
    $('#EditProductModal').modal('show');
};
       
var deleteProduct = function (t) {
    var rwid = $(t).data('id');
    var row = products_Table.row($(t).closest('tr')).data(); // Use the existing instance
    if (row) {
        Lobibox.confirm({
            msg: "Are you sure you want to delete " + row.name + " ?",
            callback: function (lobibox, type) {
                if (type === 'yes') {                    
                    $.ajax({
                        url: window.location.pathname + '?handler=DeleteProduct',
                        data: { id: parseInt(row.id) },
                        type: 'POST',
                        headers: { 'RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val() }
                    }).done(function (data) {
                        if (!data.status) {
                            round_error_noti && round_error_noti(data.message);
                        }
                        else {
                            round_success_noti && round_success_noti(data.message);
                            products_Table.ajax.reload(); // Reload the table data
                        }
                    }).fail(function () {
                        round_error_noti && round_error_noti('Failed to delete product.');
                    });
                }
            }
        });
    }    
};




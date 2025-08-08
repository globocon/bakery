// AJAX filter for product selection
let category_Table;
$(function () {    
    category_Table = $('#categoryTable').DataTable({
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
            url: './Category?handler=ShowAllCategories',
            type: 'GET',
            dataSrc: '',
            headers: { 'RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val() },
        },
        columns: [
            { data: 'id', visible: false },
            { data: 'preparationTeamId', visible: false },
            { data: 'name', width: '50%', title: "Category Name" },
            { data: 'preparationTeam.teamName', width: '30%', title: "Preparation Team" },
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
                        <button type="button" data-id="${data}" class="btn btn-sm btn-outline-primary px-2 mx-2" onclick="editCategory(this);">
                            <i class="bx bx-edit me-0"></i>
                        </button>
                        <button type="button" data-id="${data}" class="btn btn-sm btn-outline-danger px-2 mx-2" onclick="deleteCategory(this);">
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

    $('#btn_modal_editcategory_save').on('click', function (e) {       
        e.preventDefault();
        $('#CategoryAddEditModal_PreparationTeamId').val($('#select_modal_editcategory_preparationteam :selected').val());


        var result = false;
        result = validateBootstrapForm('frmMdlEditCategory');
        if (!result) {
            round_warning_noti && round_warning_noti('Please correct the errors.');
            return;
        }

        var operation = $('#CategoryAddEditModal_Operation').val();
        var handler = '?handler='
        if (operation === 'ADD') {
            handler += 'SaveCategory';
        } else {
            handler += 'UpdateCategory';
        }

        $.ajax({
            url: window.location.pathname + handler,
            type: 'POST',
            DataType: 'json',
            data: $('#frmMdlEditCategory').serialize(),
            headers: { 'RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val() }, 
            success: function (data) {
                if (!data.status) {
                    round_error_noti && round_error_noti(data.message);                    
                }
                else {
                    round_success_noti && round_success_noti(data.message);
                    $('#EditCategoryModal').modal('hide');
                    category_Table.ajax.reload(); // Reload the table data
                }                
            },
            error: function () {
                round_error_noti && round_error_noti('Failed to save category.');
            }
        });
    });

    $('#btn_add_category').on('click', function (e) {
        e.preventDefault();
        addCategory();
    });
         
});


var editCategory = function (t) {
    var row = category_Table.row($(t).closest('tr')).data(); // Use the existing instance

    if (row) {
        // console.log(row); // Full row data
        //Reset Form Validation
        resetBootstrapValidation('frmMdlEditCategory');
        $('#addEditCategoryModalTitle').html('Edit Category');
        $('#CategoryAddEditModal_Id').val(row.id);
        // Set category dropdown
        $('#select_modal_editcategory_preparationteam').val(null).trigger('change');
        $('#select_modal_editcategory_preparationteam').val(row.preparationTeamId).trigger('change'); // Or row.categoryId based on your data
        $('#CategoryAddEditModal_PreparationTeamId').val(row.preparationTeamId);
        $('#CategoryAddEditModal_Name').val(row.name);
        $('#CategoryAddEditModal_Operation').val('EDIT');
        $('#EditCategoryModal').modal('show');             
               
    }
};

var addCategory = function () {
    //Reset Form Validation
    resetBootstrapValidation('frmMdlEditCategory');
    $('#addEditCategoryModalTitle').html('Add Category');
    $('#CategoryAddEditModal_Id').val('0');
    $('#CategoryAddEditModal_PreparationTeamId').val('');
    $('#select_modal_editcategory_preparationteam').val(null).trigger('change');
    $('#CategoryAddEditModal_Name').val('');
    $('#CategoryAddEditModal_Operation').val('ADD');
    $('#EditCategoryModal').modal('show');
};
       
var deleteCategory = function (t) {
    var rwid = $(t).data('id');
    var row = category_Table.row($(t).closest('tr')).data(); // Use the existing instance
    if (row) {
        Lobibox.confirm({
            msg: "Are you sure you want to delete " + row.name + " ?",
            callback: function (lobibox, type) {
                if (type === 'yes') {                    
                    $.ajax({
                        url: window.location.pathname + '?handler=DeleteCategory',
                        data: { id: parseInt(row.id) },
                        type: 'POST',
                        headers: { 'RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val() }
                    }).done(function (data) {
                        if (!data.status) {
                            round_error_noti && round_error_noti(data.message);
                        }
                        else {
                            round_success_noti && round_success_noti(data.message);
                            category_Table.ajax.reload(); // Reload the table data
                        }
                    }).fail(function () {
                        round_error_noti && round_error_noti('Failed to delete category.');
                    });
                }
            }
        });
    }    
};


// AJAX filter for mappingtype selection
let mappingtype_Table;
$(document).ready(function () {
    
    mappingtype_Table = $('#mappingtypeTable').DataTable({
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
            url: window.location.pathname + '?handler=ShowAllProductRawMaterialMapType',
            type: 'GET',
            dataSrc: '',
            headers: { 'RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val() },
        },
        columns: [
            { data: 'id', visible: false },
            { data: 'mapTypeName', width: '90%', title: "Mapping Name" },
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
                        <button type="button" data-id="${data}" class="btn btn-sm btn-outline-primary px-2 mx-2" onclick="editMappingtype(this);">
                            <i class="bx bx-edit me-0"></i>
                        </button>
                        <button type="button" data-id="${data}" class="btn btn-sm btn-outline-danger px-2 mx-2" onclick="deleteMappingtype(this);">
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

    $('#btn_modal_editmappingtype_save').on('click', function (e) {       
        e.preventDefault();
        
        var result = false;
        result = validateBootstrapForm('frmMdlEditMappingtype');
        if (!result) {
            round_warning_noti && round_warning_noti('Please correct the errors.');
            return;
        }

        var operation = $('#MappingtypeAddEditModal_Operation').val();
        var handler = '?handler='
        if (operation === 'ADD') {
            handler += 'SaveProductRawMaterialMapType';
        } else {
            handler += 'UpdateProductRawMaterialMapType';
        }

        $.ajax({
            url: window.location.pathname + handler,
            type: 'POST',
            DataType: 'json',
            data: $('#frmMdlEditMappingtype').serialize(),
            headers: { 'RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val() }, 
            success: function (data) {
                if (!data.status) {
                    round_error_noti && round_error_noti(data.message);                    
                }
                else {
                    round_success_noti && round_success_noti(data.message);
                    $('#EditMappingtypeModal').modal('hide');
                    mappingtype_Table.ajax.reload(); // Reload the table data
                }                
            },
            error: function () {
                round_error_noti && round_error_noti('Failed to save mapping type.');
            }
        });
    });

    $('#btn_add_mappingtype').on('click', function (e) {
        e.preventDefault();
        addMappingtype();
    });
         
});


var editMappingtype = function (t) {
    var row = mappingtype_Table.row($(t).closest('tr')).data(); // Use the existing instance

    if (row) {
        // console.log(row); // Full row data
        //Reset Form Validation
        resetBootstrapValidation('frmMdlEditMappingtype');
        $('#addEditModalTitle').html('Edit Mapping Type');
        $('#MappingtypeAddEditModal_Id').val(row.id);        
        $('#MappingtypeAddEditModal_Name').val(row.mapTypeName);
        $('#MappingtypeAddEditModal_Operation').val('EDIT');
        $('#EditMappingtypeModal').modal('show');          
    }
};

var addMappingtype = function () {
    //Reset Form Validation
    resetBootstrapValidation('frmMdlEditMappingtype');
    $('#addEditModalTitle').html('Add Mapping Type');
    $('#MappingtypeAddEditModal_Id').val('0');
    $('#MappingtypeAddEditModal_Name').val('');
    $('#MappingtypeAddEditModal_Operation').val('ADD');
    $('#EditMappingtypeModal').modal('show');
};
       
var deleteMappingtype = function (t) {
    var rwid = $(t).data('id');
    var row = mappingtype_Table.row($(t).closest('tr')).data(); // Use the existing instance
    if (row) {
        Lobibox.confirm({
            msg: "Are you sure you want to delete " + row.mapTypeName + " ?",
            callback: function (lobibox, type) {
                if (type === 'yes') {                    
                    $.ajax({
                        url: window.location.pathname + '?handler=DeleteProductRawMaterialMapType',
                        data: { id: parseInt(row.id) },
                        type: 'POST',
                        headers: { 'RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val() }
                    }).done(function (data) {
                        if (!data.status) {
                            round_error_noti && round_error_noti(data.message);
                        }
                        else {
                            round_success_noti && round_success_noti(data.message);
                            mappingtype_Table.ajax.reload(); // Reload the table data
                        }
                    }).fail(function () {
                        round_error_noti && round_error_noti('Failed to delete mapping type.');
                    });
                }
            }
        });
    }    
};




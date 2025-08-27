// AJAX filter for uom selection
let uom_Table;
$(document).ready(function () {
    
    uom_Table = $('#uomTable').DataTable({
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
            url: window.location.pathname + '?handler=ShowAllUom',
            type: 'GET',
            dataSrc: '',
            headers: { 'RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val() },
        },
        columns: [
            { data: 'id', visible: false },
            { data: 'uomName', width: '90%', title: "Uom Name" },
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
                        <button type="button" data-id="${data}" class="btn btn-sm btn-outline-primary px-2 mx-2" onclick="editUom(this);">
                            <i class="bx bx-edit me-0"></i>
                        </button>
                        <button type="button" data-id="${data}" class="btn btn-sm btn-outline-danger px-2 mx-2" onclick="deleteUom(this);">
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

    $('#btn_modal_edituom_save').on('click', function (e) {       
        e.preventDefault();
        
        var result = false;
        result = validateBootstrapForm('frmMdlEditUom');
        if (!result) {
            round_warning_noti && round_warning_noti('Please correct the errors.');
            return;
        }

        var operation = $('#UomAddEditModal_Operation').val();
        var handler = '?handler='
        if (operation === 'ADD') {
            handler += 'SaveUom';
        } else {
            handler += 'UpdateUom';
        }

        $.ajax({
            url: window.location.pathname + handler,
            type: 'POST',
            DataType: 'json',
            data: $('#frmMdlEditUom').serialize(),
            headers: { 'RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val() }, 
            success: function (data) {
                if (!data.status) {
                    round_error_noti && round_error_noti(data.message);                    
                }
                else {
                    round_success_noti && round_success_noti(data.message);
                    $('#EditUomModal').modal('hide');
                    uom_Table.ajax.reload(); // Reload the table data
                }                
            },
            error: function () {
                round_error_noti && round_error_noti('Failed to save Uom.');
            }
        });
    });

    $('#btn_add_uom').on('click', function (e) {
        e.preventDefault();
        addUom();
    });
         
});


var editUom = function (t) {
    var row = uom_Table.row($(t).closest('tr')).data(); // Use the existing instance

    if (row) {
        // console.log(row); // Full row data
        //Reset Form Validation
        resetBootstrapValidation('frmMdlEditUom');
        $('#addEditModalTitle').html('Edit Mapping Type');
        $('#UomAddEditModal_Id').val(row.id);        
        $('#UomAddEditModal_UOMName').val(row.uomName);
        $('#UomAddEditModal_Operation').val('EDIT');
        $('#EditUomModal').modal('show');          
    }
};

var addUom = function () {
    //Reset Form Validation
    resetBootstrapValidation('frmMdlEditUom');
    $('#addEditModalTitle').html('Add Mapping Type');
    $('#UomAddEditModal_Id').val('0');
    $('#UomAddEditModal_UOMName').val('');
    $('#UomAddEditModal_Operation').val('ADD');
    $('#EditUomModal').modal('show');
};
       
var deleteUom = function (t) {
    var rwid = $(t).data('id');
    var row = uom_Table.row($(t).closest('tr')).data(); // Use the existing instance
    if (row) {
        Lobibox.confirm({
            msg: "Are you sure you want to delete " + row.uomName + " ?",
            callback: function (lobibox, type) {
                if (type === 'yes') {                    
                    $.ajax({
                        url: window.location.pathname + '?handler=DeleteUom',
                        data: { id: parseInt(row.id) },
                        type: 'POST',
                        headers: { 'RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val() }
                    }).done(function (data) {
                        if (!data.status) {
                            round_error_noti && round_error_noti(data.message);
                        }
                        else {
                            round_success_noti && round_success_noti(data.message);
                            uom_Table.ajax.reload(); // Reload the table data
                        }
                    }).fail(function () {
                        round_error_noti && round_error_noti('Failed to delete Uom.');
                    });
                }
            }
        });
    }    
};




// AJAX filter for team selection
let team_Table;
$(document).ready(function () {
    
    team_Table = $('#teamTable').DataTable({
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
            url: window.location.pathname + '?handler=ShowAllTeam',
            type: 'GET',
            dataSrc: '',
            headers: { 'RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val() },
        },
        columns: [
            { data: 'id', visible: false },
            { data: 'teamName', width: '90%', title: "Team Name" },
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
                        <button type="button" data-id="${data}" class="btn btn-sm btn-outline-primary px-2 mx-2" onclick="editTeam(this);">
                            <i class="bx bx-edit me-0"></i>
                        </button>
                        <button type="button" data-id="${data}" class="btn btn-sm btn-outline-danger px-2 mx-2" onclick="deleteTeam(this);">
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

    $('#btn_modal_editteam_save').on('click', function (e) {       
        e.preventDefault();
        
        var result = false;
        result = validateBootstrapForm('frmMdlEditTeam');
        if (!result) {
            round_warning_noti && round_warning_noti('Please correct the errors.');
            return;
        }

        var operation = $('#PreparationTeamAddEditModal_Operation').val();
        var handler = '?handler='
        if (operation === 'ADD') {
            handler += 'SaveTeam';
        } else {
            handler += 'UpdateTeam';
        }

        $.ajax({
            url: window.location.pathname + handler,
            type: 'POST',
            DataType: 'json',
            data: $('#frmMdlEditTeam').serialize(),
            headers: { 'RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val() }, 
            success: function (data) {
                if (!data.status) {
                    round_error_noti && round_error_noti(data.message);                    
                }
                else {
                    round_success_noti && round_success_noti(data.message);
                    $('#EditTeamModal').modal('hide');
                    team_Table.ajax.reload(); // Reload the table data
                }                
            },
            error: function () {
                round_error_noti && round_error_noti('Failed to save Team.');
            }
        });
    });

    $('#btn_add_team').on('click', function (e) {
        e.preventDefault();
        addTeam();
    });
         
});


var editTeam = function (t) {
    var row = team_Table.row($(t).closest('tr')).data(); // Use the existing instance

    if (row) {
        // console.log(row); // Full row data
        //Reset Form Validation
        resetBootstrapValidation('frmMdlEditTeam');
        $('#addEditTeamModalTitle').html('Edit Team');
        $('#PreparationTeamAddEditModal_Id').val(row.id);        
        $('#PreparationTeamAddEditModal_TeamName').val(row.teamName);
        $('#PreparationTeamAddEditModal_Operation').val('EDIT');
        $('#EditTeamModal').modal('show');          
    }
};

var addTeam = function () {
    //Reset Form Validation
    resetBootstrapValidation('frmMdlEditTeam');
    $('#addEditTeamModalTitle').html('Add Team');
    $('#PreparationTeamAddEditModal_Id').val('0');
    $('#PreparationTeamAddEditModal_TeamName').val('');
    $('#PreparationTeamAddEditModal_Operation').val('ADD');
    $('#EditTeamModal').modal('show');
};
       
var deleteTeam = function (t) {
    var rwid = $(t).data('id');
    var row = team_Table.row($(t).closest('tr')).data(); // Use the existing instance
    if (row) {
        Lobibox.confirm({
            msg: "Are you sure you want to delete " + row.teamName + " ?",
            callback: function (lobibox, type) {
                if (type === 'yes') {                    
                    $.ajax({
                        url: window.location.pathname + '?handler=DeleteTeam',
                        data: { id: parseInt(row.id) },
                        type: 'POST',
                        headers: { 'RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val() }
                    }).done(function (data) {
                        if (!data.status) {
                            round_error_noti && round_error_noti(data.message);
                        }
                        else {
                            round_success_noti && round_success_noti(data.message);
                            team_Table.ajax.reload(); // Reload the table data
                        }
                    }).fail(function () {
                        round_error_noti && round_error_noti('Failed to delete Team.');
                    });
                }
            }
        });
    }    
};





// AJAX filter for customer selection
let customers_Table;
$(document).ready(function () {

    $('#image-uploadify').imageuploadify();

    customers_Table = $('#customerTable').DataTable({
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
            url: window.location.pathname + '?handler=ShowAllCustomer',
            type: 'GET',
            dataSrc: '',
            headers: { 'RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val() },
        },
        columns: [
            { data: 'customerId', visible: false },
            {
                data: 'name',
                width: '50%',
                className: "",
                title: "Customer Name",
                render: function (data, type, row, meta) {
                    const imgPath = row.imgFileExtn
                        ? `/uploads/Customers/${row.customerId}${row.imgFileExtn}`
                        : '/assets/images/avatars/NoCustomerImage.jpg';

                    const card = `
                        <div class="d-flex align-items-center">
                            <div class="">
                                <img src="${imgPath}" class="rounded-circle" width="46" height="46" alt="" />
							</div>
							<div class="ms-2">
								<h6 class="mb-1 font-14">${row.name}</h6>
								<p class="mb-0 font-13 text-secondary">${row.address}</p>
							</div>
						</div>
                    `;
                    return card;
                }
            },
            {
                data: 'phone',
                width: '5%',
                title: "Phone",
                className: "text-center",
                render: function (data, type, row) {                    
                    return data;
                }
            },
            {
                data: 'email',
                width: '10%',
                className: "text-end",
                title: "Email",
                render: function (data, type, row, meta) {
                    return data;
                }
            },
            {
                data: 'gstNo',
                width: '10%',
                className: "text-end",
                title: "GSTNo",
                render: function (data, type, row) {
                    return data;
                }
            },
            { data: 'imgFileExtn', visible:false },
            { data: 'customerId' } // Placeholder for actions, real config below
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
                        <button type="button" data-id="${data}" class="btn btn-sm btn-outline-primary px-2 mx-2" onclick="editCustomer(this);">
                            <i class="bx bx-edit me-0"></i>
                        </button>
                        <button type="button" data-id="${data}" class="btn btn-sm btn-outline-danger px-2 mx-2" onclick="deleteCustomer(this);">
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

    $('#btn_modal_editcustomer_save').on('click', function (e) {
        e.preventDefault();

        var result = validateBootstrapForm('frmMdlEditCustomer');
        if (!result) {
            round_warning_noti && round_warning_noti('Please correct the errors.');
            return;
        }

        var operation = $('#CustomerAddEditModal_Operation').val();
        var handler = '?handler=' + (operation === 'ADD' ? 'SaveCustomer' : 'UpdateCustomer');

        var form = $('#frmMdlEditCustomer')[0];
        var formData = new FormData(form);

        // Append image file if selected
        var fileInput = $('#image-uploadify')[0];
        if (fileInput.files.length > 0) {
            formData.append('CustomerImage', fileInput.files[0]);
        }

        $.ajax({
            url: window.location.pathname + handler,
            type: 'POST',
            processData: false,
            contentType: false,
            data: formData,
            headers: { 'RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val() },
            success: function (data) {
                if (!data.status) {
                    round_error_noti && round_error_noti(data.message);
                } else {
                    round_success_noti && round_success_noti(data.message);
                    $('#EditCustomerModal').modal('hide');
                    customers_Table.ajax.reload(); // Reload the table data
                }
            },
            error: function () {
                round_error_noti && round_error_noti('Failed to save customer.');
            }
        });
    });


    $('#btn_add_customer').on('click', function (e) {
        e.preventDefault();
        addCustomer();
    });

});



var editCustomer = function (t) {	
    var row = customers_Table.row($(t).closest('tr')).data(); // Use the existing instance

    if (row) {
        var customerId = row.customerId;        
        //Reset Form Validation
        resetBootstrapValidation('frmMdlEditCustomer');
        $('#addEditModalTitle').html('Edit Customer');
        $.ajax({
            url: window.location.pathname + '?handler=FetchCustomerById',
            type: 'GET',
            data: { id: customerId },
            headers: { 'RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val() },
            success: function (data) {
                if (data) {
                    // Assuming your modal fields follow this naming
                    $('#CustomerAddEditModal_CustomerId').val(data.customerId);
                    $('#CustomerAddEditModal_ImgFileExtn').val(data.imgFileExtn);
                    $('#CustomerAddEditModal_Name').val(data.name);
                    $('#CustomerAddEditModal_Phone').val(data.phone);
                    $('#CustomerAddEditModal_Email').val(data.email);
                    $('#CustomerAddEditModal_Address').val(data.address);
                    $('#CustomerAddEditModal_GSTNo').val(data.gstNo);
                    $('#Customer_Name').html(data.name);
                    // Add more fields as per your model

                    $('#CustomerAddEditModal_Operation').val('EDIT');
                    $('#EditCustomerModal').modal('show');
                } else {
                    round_error_noti && round_error_noti('Customer data not found.');
                }
            },
            error: function () {
                round_error_noti && round_error_noti('Failed to fetch customer data.');
            },
            complete: function () {
                $(t).prop('disabled', false); // re-enable button
            }
        });
    }
}

var addCustomer = function () {
    //Reset Form Validation
    resetBootstrapValidation('frmMdlEditCustomer');
    $('#CustomerAddEditModal_CustomerId').val('0');
    $('#CustomerAddEditModal_ImgFileExtn').val('');
    $('#CustomerAddEditModal_Name').val('');
    $('#CustomerAddEditModal_Phone').val('');
    $('#CustomerAddEditModal_Email').val('');
    $('#CustomerAddEditModal_Address').val('');
    $('#CustomerAddEditModal_GSTNo').val('');
    $('#Customer_Name').html('');
    $('#CustomerAddEditModal_Operation').val('ADD');
    $('#EditCustomerModal').modal('show');
};

var deleteCustomer = function (t) {
    var rwid = $(t).data('id');
    var row = customers_Table.row($(t).closest('tr')).data(); // Use the existing instance
    if (row) {
        Lobibox.confirm({
            msg: "Are you sure you want to delete " + row.name + " ?",
            callback: function (lobibox, type) {
                if (type === 'yes') {
                    $.ajax({
                        url: window.location.pathname + '?handler=DeleteCustomer',
                        data: { id: parseInt(row.customerId) },
                        type: 'POST',
                        headers: { 'RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val() }
                    }).done(function (data) {
                        if (!data.status) {
                            round_error_noti && round_error_noti(data.message);
                        }
                        else {
                            round_success_noti && round_success_noti(data.message);
                            customers_Table.ajax.reload(); // Reload the table data
                        }
                    }).fail(function () {
                        round_error_noti && round_error_noti('Failed to delete customer.');
                    });
                }
            }
        });
    }
};




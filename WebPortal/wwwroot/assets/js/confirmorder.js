$(function () {
    // Select all checkbox
    $('#selectAll').on('change', function () {
        $('.order-checkbox').prop('checked', this.checked);
    });

    // Handle Show Orders button click
    $('#btnGetOrdersByDate').on('click', function (e) {
        e.preventDefault();
        var orderDate = $('#OrderDate').val();
        if (!orderDate) {
            round_warning_noti && round_warning_noti('Please select an order date.');
            return;
        }

        $.ajax({
            url: window.location.pathname,
            type: 'GET',
            data: { SelectedOrderDate: orderDate }, // <-- Use property name here
            success: function (data) {
                var html = $(data);
                var newCard = html.find('.card.mb-4').nextAll();
                $('.card.mb-4').nextAll().remove();
                $('.card.mb-4').after(newCard);
            },
            error: function () {
                round_error_noti && round_error_noti('Failed to load orders.');
            }
        });
    });

    // Handle Print Orders button click
    $('#btnGetOrdersPrintByDate').on('click', function (e) {
        e.preventDefault();
        var orderDate = $('#OrderDate').val();
        if (!orderDate) {
            round_warning_noti('Please select an order date.');
            return;
        }
        // Open the PDF in a new tab
        window.open(`/ConfirmOrder?handler=PrintReport&selectedOrderDate=${encodeURIComponent(orderDate)}`, '_blank');
    });
});
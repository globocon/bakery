// Select all checkbox
$(document).on('change', '#selectAll', function () {
    $('.order-checkbox').prop('checked', this.checked);
});

// button is loaded via AJAX after the page loads, use delegated event binding:
// Handle Confirm Selected Orders AJAX
$(document).on('click', '#btnConfirmOrders', async function (e) {
    e.preventDefault();
    var orderDate = $('#OrderDate').val();
    // Collect selected order IDs
    var selectedOrderIds = $('.order-checkbox:checked').map(function () {
        return $(this).val();
    }).get();

    if (selectedOrderIds.length === 0) {
        round_warning_noti && round_warning_noti('Please select at least one order to confirm.');
        return;
    }

    try {
        const response = await fetch('?handler=ConfirmOrders', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
                'RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val() // If using antiforgery
            },
            body: JSON.stringify(selectedOrderIds)
        });

        if (response.ok) {
            const result = await response.json();
            if (result.success) {
                round_success_noti && round_success_noti(result.message || 'Orders confirmed successfully.');
                // Open the PDF in a new tab
                window.open(`/ConfirmOrder?handler=PrintReport&selectedOrderDate=${encodeURIComponent(orderDate)}`, '_blank');
                // refresh the orders table or remove confirmed rows
                $('#btnGetOrdersByDate').trigger('click'); // Trigger the button to refresh orders
            } else {
                round_error_noti && round_error_noti(result.message || 'Failed to confirm orders.');
            }
        } else {
            round_error_noti && round_error_noti('Server error. Please try again.');
        }
    } catch (error) {
        round_error_noti && round_error_noti('Error: ' + error);
    }
});

$(function () {
    
    $('#btnGetOrdersByDate').on('click', function (e) {
        // Handle Show Orders button click
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

    
    $('#btnGetOrdersPrintByDate').on('click', function (e) {
        // Handle Print Orders button click
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


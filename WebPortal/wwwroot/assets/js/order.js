$(document).ready(function () {
    $('#btnSaveNormalOrder').on('click', function (e) {
        e.preventDefault();

        // Collect form data
        var deliveryDate = $('#inputDeliveryDate').val();
        var customerId = parseInt($('#CustomerId').val());
        var orderId = parseInt($('#NormalOrderId').val());
        
        // Validate required fields
        if (!deliveryDate) {
            round_warning_noti('Please select a delivery date.');
            return;
        }
        if (!customerId) {
            round_warning_noti('Please select a customer.');
            //Lobibox.alert('warning', { msg: 'Please select a customer.' });
            return;
        }

        // Collect product quantities
        var orderItems = [];
        $('.form-control[data-productid]').each(function () {
            var qty = parseInt($(this).val(), 10);
            var productId = $(this).data('productid');
            if (qty && qty > 0) {
                orderItems.push({
                    OrderItemId: 0,
                    OrderId:0,
                    ProductId: productId,
                    Quantity: qty,
                    DeliveryDateTime: null // You may want to format this as needed
                });
            }
        });

        if (orderItems.length === 0) {
            round_warning_noti('Please enter quantity for at least one product.');
            //Lobibox.alert('warning', { msg: 'Please enter quantity for at least one product.' });
            return;
        }

        var orderData = {
            OrderId: orderId,
            OrderNumber: null,
            CustomerId: customerId,
            InvoiceRefId: null,
            OrderDate: new Date(deliveryDate).toISOString(),
            Status: 'New',
            OrderItems: orderItems
        };
               
        // Send AJAX request to save order
        $.ajax({
            url: '/Orders?handler=SaveNewOrder',  // Adjust this URL to your actual API endpoint
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(orderData),
            headers: { 'RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val() },
            success: function (response) {
                if (response && response.orderNumber) {
                    round_success_noti('Order saved.<br>Order number: ' + response.orderNumber);
                } else {
                    round_success_noti('Order saved successfully.');
                }
                $('#frmNormalOrder')[0].reset();
                $('#CustomerId').val("").trigger('change'); //Single select reset
            },
            error: function (xhr) {
                var msg = 'Failed to save order.';
                if (xhr.responseJSON && xhr.responseJSON.message) {
                    msg = xhr.responseJSON.message;
                }
                round_error_noti(msg);
                //Lobibox.alert('error', { msg: msg });
            }
        });
    });

    $('#btnSaveSpecialOrder').on('click', function (e) {
        e.preventDefault();

        var deliveryDate = $('#inputSplDeliveryDate').val();
        var deliveryTime = $('#inputSplDeliveryTime').val();
        var customerId = parseInt($('#SplCustomerId').val());
        var productId = parseInt($('#SplProductId').val());
        var qty = parseInt($('#inputOrderSplQty').val(), 10);

        // Validate required fields
        if (!deliveryDate) {
            round_warning_noti('Please select a delivery date.');
            return;
        }
        if (!deliveryTime) {
            round_warning_noti('Please select a delivery time.');
            return;
        }
        if (!customerId) {
            round_warning_noti('Please select a customer.');
            return;
        }
        if (!productId) {
            round_warning_noti('Please select a product.');
            return;
        }
        if (!qty || qty <= 0) {
            round_warning_noti('Please enter a valid quantity.');
            return;
        }
        alert('deliveryTime:' + deliveryTime);
        // Combine date and time for DeliveryDateTime
        var deliveryDateTime = new Date(deliveryDate + ' ' + deliveryTime);
        alert('deliveryDateTime:' + deliveryDateTime);
        var orderData = {
            OrderId: 0,
            OrderNumber: null,
            CustomerId: customerId,
            InvoiceRefId: null,
            OrderDate: new Date(deliveryDate).toISOString(),
            Status: 'New',
            OrderItems: [
                {
                    OrderItemId: 0,
                    OrderId: 0,
                    ProductId: productId,
                    Quantity: qty,
                    DeliveryDateTime: deliveryDateTime.toISOString()
                }
            ]
        };

        $.ajax({
            url: '/Orders?handler=SaveSpecialOrder',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(orderData),
            headers: { 'RequestVerificationToken': $('input[name="__RequestVerificationToken"]').val() },
            success: function (response) {
                if (response && response.orderNumber) {
                    round_success_noti('Special Order saved.<br>Order number: ' + response.orderNumber);
                } else {
                    round_success_noti('Special Order saved successfully.');
                }
                $('#frmSpecialOrder')[0].reset();
                $('#SplCustomerId').val("").trigger('change'); //Single select reset
                $('#SplProductId').val("").trigger('change'); //Single select reset
            },
            error: function (xhr) {
                var msg = 'Failed to save special order.';
                if (xhr.responseJSON && xhr.responseJSON.message) {
                    msg = xhr.responseJSON.message;
                }
                round_error_noti(msg);
            }
        });
    });
});
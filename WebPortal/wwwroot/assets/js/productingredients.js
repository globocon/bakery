// AJAX filter for product selection
$(document).ready(function () {
    $('#productFilter').on('change', function () {
        var productId = $(this).val();
        $.ajax({
            url: './ProductIngredients?handler=ProductIngredientsPartial',
            type: 'GET',
            data: { productId: productId },
            success: function (data) {
                $('#ingredientsTableBody').html(data);
            }
        });
    });
});

function confirmDeleteIngredient(id) {
    Lobibox.confirm({
        msg: "Are you sure you want to delete this ingredient?",
        callback: function (lobibox, type) {
            if (type === 'yes') {
                window.location.href = '@Url.Page("./ProductIngredients")' + '?handler=Delete&id=' + id + '&notify=deleted';
            }
        }
    });
}

// Show notification if present in TempData
$(function () {
    var notifyMsg = '@TempData["NotifyMsg"]';
    var notifyType = '@TempData["NotifyType"]';
    if (notifyMsg && notifyType) {
        if (notifyType === 'success') {
            round_success_noti(notifyMsg);
        } else if (notifyType === 'error') {
            round_error_noti(notifyMsg);
        }
    }
});
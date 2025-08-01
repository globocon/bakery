$(function () {
    "use strict";


    $('.single-select').select2({
        theme: 'bootstrap4',
        width: $(this).data('width') ? $(this).data('width') : $(this).hasClass('w-100') ? '100%' : 'style',
        placeholder: $(this).data('placeholder'),
        allowClear: Boolean($(this).data('allow-clear')),
    });
    $('.multiple-select').select2({
        theme: 'bootstrap4',
        width: $(this).data('width') ? $(this).data('width') : $(this).hasClass('w-100') ? '100%' : 'style',
        placeholder: $(this).data('placeholder'),
        allowClear: Boolean($(this).data('allow-clear')),
    });
    $(function () {
        $('.multiple-select-tag-enabled').each(function () {
            $(this).select2({
                theme: 'bootstrap4',
                width: $(this).data('width') ? $(this).data('width') : $(this).hasClass('w-100') ? '100%' : 'style',
                placeholder: $(this).data('placeholder'),
                allowClear: Boolean($(this).data('allow-clear')),
                tags: true,
                tokenSeparators: ['\t', '\n'],
            });
        });
    });

    // Setting dropdownParent To fix the not visible issue of select2 when defined inside model popup
    // issue and solution @ https://select2.org/troubleshooting/common-problems
    // dropdown position issue https://stackoverflow.com/questions/34498075/select2-dropdown-wrong-position  
    var dropdownParentEditProducts = $('#EditProductModal > .modal-dialog > .modal-content');
    $('.single-select-editproduct').select2({
        theme: 'bootstrap4',
        width: $(this).data('width') ? $(this).data('width') : $(this).hasClass('w-100') ? '100%' : 'style',
        placeholder: $(this).data('placeholder'),
        allowClear: Boolean($(this).data('allow-clear')),
        dropdownParent: dropdownParentEditProducts,
        closeOnSelect: true,
    });

});
$(function () {
    var categorySelect = $('select#SelectedCategoryId');
    var onSelectChanged = function () {
        var self = $(this);
        var newCategoryName = $('.new-category-label, .new-category-label + input');

        if (self.find('option:selected').val() === "-1") {
            newCategoryName.css('display', '');
        } else {
            newCategoryName.css('display', 'none');
        }
    };

    onSelectChanged.apply(categorySelect);

    categorySelect.change(onSelectChanged);
});


$(document).ready();
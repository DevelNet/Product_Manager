$(function ()
{
    $('select').change(
        function() {
            if ($('select option:selected').val() === "-1") {
                $('.new-category-label, .new-category-label + input')
                    .css('display', '');
            } else {
                $('.new-category-label, .new-category-label + input')
                    .css('display', 'none');
            } 
            
        }
        );
});


$(document).ready();
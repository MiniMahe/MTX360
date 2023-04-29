$(document).ready(function () {
    $('#search-input').on('keyup', function () {
        var query = $(this).val().toLowerCase();

        $('.enlace-aula').each(function () {
            var aula = $(this).find('.nav-link').text().toLowerCase();

            if (aula.indexOf(query) === -1) {
                $(this).hide();
            } else {
                $(this).show();
            }
        });
    });
});
var filteredColumn = 1; // Колонка для фильтрации
var rows = []; // Все строки таблицы для фильтрации

/**
 * При загрузке страницы все строки таблицы в массив
 */
$(document).ready(function() {
    rows = $(".table tr:not(:first-child)");
});

/**
 * Выбор колонки для фильтра
 */
$(".books-filter .dropdown-menu li").click(function () {
    var item = $(this);

    item.parents(".input-group-btn").find(".filter-title").text(item.text()); // заголовок по какой колонке искать в текст кнопки
    filteredColumn = +item.attr("id"); // ID колонки для поиска

    // Очистка поля ввода и фокус в него после изменения колонки фильтрации
    var input = $(".books-filter input");
    input.val("");
    input.focus();

    // Отобразить все скрытые строки таблицы
    rows.each(function () {
        $(this).show();
    });
});

/**
 * Фильтр
 */
$(".books-filter input").on("input", function (event) {
    var inputText = $(this).val(); // Значение из строки ввода

    rows.each(function () {
        // Если не совпадает текст в колонке с введенным - скрыть строку
        if (this.cells[filteredColumn].innerText.toLowerCase().indexOf(inputText.toLowerCase()) < 0) {
            $(this).hide();
        }
        // Отобразить строку
        else {
            $(this).show();
        } 
    });
});


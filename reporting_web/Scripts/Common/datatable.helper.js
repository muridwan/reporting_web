function CreateReportTable(selector, option) {
    var defaultOption = {
        processing: true,
        serverSide: false,
        paging: false,
        responsive: false,
        scrollX: true,
        scrollCollapse: true,
        autoWidth: false,
        fixedHeader: false,
        colReorder: true,
        order: [[1, "asc"]],
        dom:
            "<'row'<'col-sm-6'B><'col-sm-6'f>>" +
            "<'row'<'col-sm-12'tr>>" +
            "<'row'<'col-sm-5'i><'col-sm-7'p>>"
    };
    return $(selector).DataTable($.extend(true, {}, defaultOption, option));
}
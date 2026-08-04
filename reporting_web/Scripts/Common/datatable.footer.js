function DTFooter(api, columns, decimalColumns) {
    $.each(columns, function (i, col) {
        var decimal = decimalColumns.indexOf(col) >= 0 ? 2 : 0;
        var total = api.column(col).data().sum();
        $(api.column(col).footer()).html(
            $.fn.dataTable.render
                .number(',', '.', decimal)
                .display(total)
        );
    });

}
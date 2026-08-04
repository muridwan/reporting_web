function DTNumbering(table) {

    table.on('order.dt search.dt draw.dt', function () {

        table.column(0, {

            search: 'applied',
            order: 'applied'

        }).nodes().each(function (cell, i) {

            cell.innerHTML = i + 1;

        });

    });

}
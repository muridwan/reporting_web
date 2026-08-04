function DTExportOptions() {

    return {

        columns: ':visible',

        format: {

            body: function (data, row, column) {

                if (column === 0)
                    return row + 1;

                return $("<div>").html(data).text();

            }

        }

    };

}

function DTButtons(message) {

    var exportOptions = DTExportOptions();

    return [

        {
            extend: 'copy',
            footer: true,
            exportOptions: exportOptions
        },

        {
            extend: 'excel',
            footer: true,
            messageTop: message,
            exportOptions: exportOptions
        },

        {
            extend: 'pdf',
            footer: true,
            messageTop: message,
            orientation: 'landscape',
            pageSize: 'A3',
            exportOptions: exportOptions
        },

        {
            extend: 'print',
            footer: true,
            messageTop: message,
            exportOptions: exportOptions
        }

    ];

}
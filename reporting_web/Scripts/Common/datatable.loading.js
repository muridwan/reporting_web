function EnableLoading(table) {

    table

        .on('preXhr.dt', function () {

            $("#loadingOverlay").show();

        })

        .on('xhr.dt', function () {

            $("#loadingOverlay").hide();

        });

}
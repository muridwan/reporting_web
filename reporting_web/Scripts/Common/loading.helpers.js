function DTLoading(selector) {
    $(selector)
        .on("preXhr.dt", function () {
            $("#loadingOverlay").show();
        })
        .on("xhr.dt", function () {

            $("#loadingOverlay").hide();
        });
}
$(document).ready(function () {
    $("#Submit").on('click', function (event) {
        event.preventDefault();
        var con = $("#Contributor").val();
        var quote = $("#Quote").val();
        var quote = {
            Contributor: con ,
            Quote: quote
        };

        $.ajax({
            url: "api/BlackPositivityQuote/newQuote",
            type: "post",
            data: JSON.stringify(quote),
            contentType: 'application/json; charset=utf-8',
            dataType: "json",
            success: function (response) {
                console.log(response.data);
            }
        })
    });
});
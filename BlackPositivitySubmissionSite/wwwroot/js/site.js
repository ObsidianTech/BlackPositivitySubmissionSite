$(document).ready(function () {
    $("#Submit").on('click', function (event) {
        event.preventDefault();
        const con = $("#Contributor").val();
        const newQuote = $("#Quote").val();
        const quote = {
            Contributor: con,
            Quote: newQuote
        };

        $.ajax({
            url: "api/BlackPositivityQuote/newQuote",
            type: "post",
            data: JSON.stringify(quote),
            contentType: 'application/json; charset=utf-8',
            dataType: "json",
            success: function (data) {
                PostResult(data);
            },
            error: function (data) {
                PostResult(false);
            }
        });
    });

    const PostResult = function (success) {
        const initialView = $("#initialView");
        const successView = $("#success");
        const errorView = $("#error");
        if (success) {
            initialView.addClass('hidden');
            successView.removeClass('hidden');
        } else {
            initialView.addClass('hidden');
            errorView.removeClass('hidden');
        };
    }; 
});
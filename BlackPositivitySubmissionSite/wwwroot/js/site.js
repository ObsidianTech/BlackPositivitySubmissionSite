$(document).ready(function () {
    const con = $("#Contributor").val();
    const newQuote = $("#Quote").val();
    const fountainG = $("#fountainG");
    $("#Submit").on('click', function (event) {
        event.preventDefault();
        fountainG.show();
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
        const welcomeView = $("#welcome");
        const errorView = $("#error");

        fountainG.hide();

        if (success) {
            welcomeView.addClass('hidden');
            initialView.addClass('hidden');
            successView.removeClass('hidden');
        } else {
            welcomeView.addClass('hidden');
            initialView.addClass('hidden');
            errorView.removeClass('hidden');
        };
    }; 
});
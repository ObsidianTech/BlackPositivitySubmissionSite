$(document).ready(function () {
    $("#submission").submit(function (event) {
        event.preventDefault();
        let submission = $(this).serializeArray();
        console.log(submission);
        $.ajax({
            url: "api/BlackPositivityQuote/newQuote",
            type: "post",
            data: JSON.stringify(submission),
            contentType: 'application/json; charset=utf-8',
            dataType: "json",
            success: function (response) {
                console.log(response.data);
            }
        })
    });
});
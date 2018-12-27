// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(() => {
    $('#sendMessageBtn').click(() => {

        const messageReciepients = $('#messageReciepients').val();
        const messageSubject = $('#messageSubject').val();
        const messageBody = $('#messageBody').val();

        let data = {
            recipients: messageReciepients.split(';'),
            subject: messageSubject,
            body: messageBody
        };

        const request = $.ajax({
            url: '/api/messages',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(data),
            dataType: 'json'
        });

        request.then((response) => {
            if (!response) {
                console.log('SendMessage -> Error:');
                console.log(`Response is ${response}`);
            }
            console.log(response);
        }).catch((xhr, textStatus, error) => {
            console.log('SendMessage -> Error:');
            console.log(xhr);
            console.log(textStatus);
            console.log(error);
        });
    });
}); 
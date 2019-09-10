$(document).ready(function () {


    $('.list-group-item').click(function () {
        var id = $(this).attr('data-ID');



    });

    $('#PriceBtn').click(function () {

        var name = $('#ProductName').val();
        var category = $('#secound').text();
        $.ajax({
            url: 'Category',
            method: 'post',
            data: { 'TopicViewName': name, 'TopicViewCategory': category },
            success: function () {
                $('#CloseBtn').trigger('click');
                $('#ProductName').val('');
            }
        });
    });



    $('#LoginBtn').click(function (e) {
        e.preventDefault()

        var email = $('#LoginEmail').val();
        var password = $('#LoginPassword').val();
        $.ajax({
            url: '/Account/Login',
            method: 'post',
            data: {
                'Email': email, 'Password': password
               
            },
            success: function (response) {
                console.log(response, 'response')
                alert('success')
                return
            },
            error: function () {
                alert('Login Failed')
            },
        });
    })

})


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



    $('#LoginBtn').click(function () {
        var data = {};

        data.Email = $('#LoginEmail').val();
        data.Password = $('#LoginPassword').val();
        $.ajax({
            url: '/Account/Login',
            method: 'POST',
            data: {
                model: data,
                returnUrl: 'Home/Index'
            },
            success: function () {
                alert('success')
            },
            error: function () {
                alert('Login Failed')
            },
        });
    })

})


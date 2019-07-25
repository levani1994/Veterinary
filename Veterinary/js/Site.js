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
      

        var email = $('#LoginEmail').val();
        var password = $('#LoginPassword').val();
        $.ajax({
            url: '/Account/Login',
            method: 'post',
            data: {
                'Email': email, 'Password': password
               
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


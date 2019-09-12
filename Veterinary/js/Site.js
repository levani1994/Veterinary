$(document).ready(function () {

  //  $('#datePickerField').datepicker();



    $('.list-group-item').click(function () {
        var id = $(this).attr('data-ID');
    });



    $('#PriceBtn').click(function () {

        var name = $('#TopicName').val();
        var category = $('#TopicCategory').val();
        $.ajax({
            url: 'Category',
            method: 'post',
            data: { 'TopicViewName': name, 'TopicViewCategory': category },
            success: function () {
                $('#CloseBtn').trigger('click');
              
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

            },
            error: function () {
                alert('Login Failed')
            },
        });
    })
})

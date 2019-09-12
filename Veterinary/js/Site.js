$(document).ready(function () {

    $('#datePickerField').datepicker();


    $('.list-group-item').click(function () {
        var id = $(this).attr('data-ID');
    });

    $('#PriceBtn').click(function () {
        
        var name = $('#TopicName').val();
        var category = $('#TopicCategory').val();
        console.log(name);
        console.log(category);
        $.ajax({
            url: '/Forum/Category',
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

            },
            error: function () {
                alert('Login Failed')
            },
        });
    })

})

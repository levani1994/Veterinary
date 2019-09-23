$(document).ready(function () {

  



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
<<<<<<< HEAD

    $('#datePickerField').datepicker();
    
    //$("#calendar").datepicker({
    //    showOn: "button",
    //    buttonText: "Select date"
    //});

    $("#calendar").datepicker({
        
        showOn: "button",
        buttonImage: "images/icons/calendar.svg",
        buttonImageOnly: true,
       
    });
=======
    
  $('#datePickerField').datepicker();
>>>>>>> bb3e7c8b40a17fe64091933332c8d75574bc0b72

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
            success: function () {
                
                location.reload();
                //$('#login-logout').html();
                
            },
            error: function () {
                alert('Login Failed')
            },
        });
    })

   
})

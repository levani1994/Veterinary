$(document).ready(function () {


    $('#search').keyup(function () {
        var i = $(this).val();
        console.log(i);
    });


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

    
  $('#datePickerField').datepicker();


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

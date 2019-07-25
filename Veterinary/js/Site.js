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



    //$('#LoginBtn').click(function () {
        
    //       Console.log("deded");
    //    var email = $('#LoginEmail').val();
    //    var password = $('#LoginPassword').val();
        
    //    $.ajax({
    //        url: 'Login',
    //        method: 'post',
    //        data: {
    //            'Email': email, 'Password': password},

    //        success: function () {
    //            Console.log("deded")
    //        }
    //    });
        
    //});
})


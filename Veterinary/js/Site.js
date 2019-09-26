$(document).ready(function () {


    $('#searchTerm').keydown(function () {
        var term = $(this).val();
        $.ajax({
            url: '/Home/Search',
            method: 'post',
            data: {
                'searchTerm': term
            },
            success: function (response) {
                console.log(response, "response");
                var result = ""

                if (response.length > 0) {
                    $.each(response, function (i, item) {
                        result += "<div><p>" + response[i].Name + '</p> <p> ' + response[i].id + "</p></div>";
                    });
                } else {
                    result += "<div><p>" + response.Name + '</p> <p> ' + "not found  </p></div>"
                }

                if (term.length > 0) {
                    $("#search-result").show()
                } else {
                    result = "<div></div>"
                    $("#search-result").hide()
                    console.log('clear', result)
                }

                console.log(result, 'result')
                $("#search-result").html(result); 

            } 
        })  
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

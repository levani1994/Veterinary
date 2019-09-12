// open all popup by one code
var openPopup = document.querySelectorAll('.open__popup');
openPopup.forEach(function(click){
    click.addEventListener('click', function(e){
        document.querySelectorAll('.popup-close').forEach(function(mypopup){
            if(click.getAttribute('data-popup') ===  mypopup.getAttribute('data-popup')){
                mypopup.classList.toggle('active');
            }
        });

        e.stopPropagation();
        e.preventDefault();
    });
});


// close popup by esc 
var popups = document.querySelectorAll('.popup-close');
popups.forEach(function(popup){
    document.addEventListener('keydown', function(e){
        if (e.keyCode == 27 || e.which == 27) {
            popup.classList.remove('active');
        }
    });
});




// stop propagation all popup
document.querySelectorAll('.popup__container').forEach(function(popup){
    popup.addEventListener('click', function(e){
        e.stopPropagation();
    });
});


// close popups by x icon
var closePopup = document.querySelectorAll('.popup-close');
closePopup.forEach(function(close){
    close.addEventListener('click', function(){
        this.parentElement.parentElement.classList.remove('active');
    });
});


// close popups by document click
document.addEventListener('click', function(e){
    document.querySelectorAll('.popup-close').forEach(function(pop){
        if(pop.classList.contains('active')){
            pop.classList.remove('active');
        } 
    });
});




// slider
$(document).ready(function () {

    $('.news__slider').slick({
        autoplay: true,
        dots: true,
        prevArrow: '<div class="arrow-container arrow-container-left"><img class="slider__arrow" src="' + Path+'images/icons/arrow_left.png" alt="left arrow"></div>',
        nextArrow: '<div class="arrow-container arrow-container-right"><img class="slider__arrow" src="' + Path +'images/icons/arrow_right.png" alt="left arrow"></div>',
    });

});

$(document).ready(function () {

    $('#show-register-form').click(function () {
        $('#login-form').hide()
        $('#registration-form').show()
    });

    $('#show-login-form').click(function () {
        $('#login-form').show()
        $('#registration-form').hide()
    });


});


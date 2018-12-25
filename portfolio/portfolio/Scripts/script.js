

$(document).ready(function () {

 
 

// Scroll-Top
    var offset = 250;
    var duration = 500;
    $(window).scroll(function () {
        if ($(this).scrollTop() > offset) {
            $('.to-top').fadeIn(duration);
        } else {
            $('.to-top').fadeOut(duration);
        }
    });
    $('#scr').click(function () {

        $('html,body').animate({
            scrollTop: 0
        }, duration);
    })
    
});

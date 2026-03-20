/**
 *	www.templatemo.com
 */

/* HTML document is loaded. DOM is ready.
-----------------------------------------*/
$(document).ready(function(){

	// Mobile menu
	$('.mobile-menu-icon').click(function(){
		$('.tm-nav').slideToggle();
	});

	$( window ).resize(function() {
		if($( window ).width() > 767) {
			$('.tm-nav').show();
		} else {
			$('.tm-nav').hide();
		}
	});

  // http://stackoverflow.com/questions/2851663/how-do-i-simulate-a-hover-with-a-touch-in-touch-enabled-browsers
  $('body').bind('touchstart', function() {});

  // Smooth scroll
  // https://css-tricks.com/snippets/jquery/smooth-scrolling/
  $('a[href*=#]:not([href=#])').click(function() {
    if (location.pathname.replace(/^\//,'') == this.pathname.replace(/^\//,'') && location.hostname == this.hostname) {
      var target = $(this.hash);
      target = target.length ? target : $('[name=' + this.hash.slice(1) +']');
      if (target.length) {
        $('html,body').animate({
          scrollTop: target.offset().top
        }, 1000);
        return false;
      }
    }
  });

  /// EDITION
  function sendMessage() {
    console.log("emailjs:", typeof emailjs);
    // var name = document.getElementById("contact_name").value;
    // var email = document.getElementById("contact_email").value;
    // var subject = document.getElementById("contact_subject").value;
    // var message = document.getElementById("contact_message").value;
    // console.log(email);
    var form = document.getElementById("contact-form");
    var status = document.getElementById("status");

    emailjs.sendForm(
        "service_aprt4sa",
        "template_j4t58mi",
        form
      ).then(() => {
        status.textContent = "Email sent successfully.";
        form.reset();
      }).catch((error) => {
        status.textContent = "Failed to send email.";
        console.error(error);
      });
  }

  function init() {
    emailjs.init({
      publicKey: "AACZR4h3GEaJ1RWfC",
    });
    // events 
    var buttonSendMessage = document.getElementById("sendMessage");
    buttonSendMessage.onclick = sendMessage;
  }

  init();
  // END EDITION

});

$(window).load(function() {
	// Remove preloader
	// https://ihatetomatoes.net/create-custom-preloading-screen/
	$('body').addClass('loaded');
});
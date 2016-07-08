$(document).ready(function() {
  $('.answers').eq(0).removeClass('hidden');

  var toggle = false;
  var toggle2 = false;
    $('.answers').click(function() {
      console.log('first click');
      if (!toggle) {
        console.log(toggle + " first");
        $('.test').removeClass('hiddentest');
        $(this).addClass('removalTarget');
        toggle= true;
      } else {
        toggle2= true;
      }
    });

  // $('ul .removalTarget').click(function() {
  //   console.log("hello");
  //   $('.answers').eq(1).removeClass('hidden');
  //   $(this).remove();
  // });


  $( "#container" ).on( "click", ".removalTarget", function( event ) {
    console.log('second click');
    if (toggle && toggle2) {
      console.log(toggle + " second");
      $('.answers').eq(1).removeClass('hidden');
      $('.answers .test').eq(1).addClass('hiddentest');
      $(this).remove();
      toggle = false;
      toggle2 = false;
    }
  });

});

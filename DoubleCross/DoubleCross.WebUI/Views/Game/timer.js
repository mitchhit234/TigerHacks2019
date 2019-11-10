function timer(sec, prompt){
  document.getElementById('prompt').innerHTML = prompt;
  var timer = setInterval(function(){
      document.getElementById('time').innerHTML='00:'+ sec;
      sec--;
      if (sec < 0) {
          clearInterval(timer);
          var audio = new Audio('Done.mp3');
          audio.play();
      }
    }, 1000);
  }

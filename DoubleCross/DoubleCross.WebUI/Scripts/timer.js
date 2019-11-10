function timer(sec, prompt, alarm) {
    document.getElementById('prompt').innerHTML = prompt;
    var timer = setInterval(function () {
        document.getElementById('time').innerHTML = '00:' + sec;
        sec--;
        if (sec < 0) {
            clearInterval(timer);
            //if (alarm == 0) {
            //    var audio = new Audio('http://dight310.byu.edu/media/audio/FreeLoops.com/1/1/Alarm%20Clock.wav-19830-Free-Loops.com.mp3');
            //    audio.play();
            //}
            //else if (alarm == 1) {
            //    var audio = new Audio('http://dight310.byu.edu/media/audio/FreeLoops.com/1/1/Alarm%20Clock.wav-19830-Free-Loops.com.mp3');
            //    audio.play();
            //}
            var audio = new Audio('http://dight310.byu.edu/media/audio/FreeLoops.com/1/1/Alarm%20Clock.wav-19830-Free-Loops.com.mp3');
            audio.play();
        }
    }, 1000);
}
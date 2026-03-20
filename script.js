const MAX_MINUTE = 25;
const CIRCLE_LENGTH = 691;
var minute = 25;
var seconds = 0;
var intervalID = undefined;
var isRunning = 0;
var modeSelected = 1;
const MODES = {
    focus: 1,
    short: 2,
    long: 3
}

function disableButton(_id) {
    document.getElementById(_id).classList.add("disabled");
}

function enableButton(_id) {
    document.getElementById(_id).classList.remove("disabled");
}

function updateTime() {
    if (minute === 0 && seconds === 0) {
        clearInterval(intervalID);
        return;
    }
    if (seconds > 0) {
        seconds--;
    } else {
        minute--;
        seconds = 59;
    }
    var s = seconds;
    if (s < 10) {
        s = "0" + seconds;
    }
    updateTimeInView(minute, s);
    updateProgressInCircle();

    // document.getElementById("time").innerHTML = minute + ":" + seconds;
}

function updateProgressInCircle() {
    var circle = document.querySelector('.progress-circle');
    var total = 0;

    if (modeSelected === 1) {
        total = 25;
    }
    if (modeSelected === 2) {
        total = 5;
    }
    if (modeSelected === 3) {
        total = 15;
    }

    var progress = (minute * 60 + seconds) / (total * 60);
    progress = CIRCLE_LENGTH * (1 - progress);

    circle.setAttribute('stroke-dashoffset', progress.toString());
}

function resetProgressInCircle() {
    var circle = document.querySelector('.progress-circle');
    circle.setAttribute('stroke-dashoffset', "0");
}

function updateTimeInView(_minutes, _seconds) {
    document.getElementById("time").innerHTML = _minutes + ":" + _seconds;
}

function setActiveButtonControl(_type) {
    if (_type === 2) { // reset case
        document.getElementById("reset").classList.remove("active");
        document.getElementById("start").classList.add("active");
    } else {
        document.getElementById("start").classList.remove("active");
        document.getElementById("reset").classList.add("active");
    }
}

function setActiveButtonMode(_type) {
    if (_type === 1) { // focus case
        document.getElementById("short").classList.remove("active");
        document.getElementById("long").classList.remove("active");
        document.getElementById("focus").classList.add("active");
    }
    if (_type === 2) { // short case
        document.getElementById("focus").classList.remove("active");
        document.getElementById("long").classList.remove("active");
        document.getElementById("short").classList.add("active");
    }
    if (_type === 3) { // long case
        document.getElementById("short").classList.remove("active");
        document.getElementById("focus").classList.remove("active");
        document.getElementById("long").classList.add("active");
    }
}


// region public functions 
function reset() {
    setActiveButtonControl(2);
    clearInterval(intervalID);
    isRunning = 0;
    switch (modeSelected) {
        case 1:
            setTimeForFocusMode();
            break;
        case 2:
            setTimeForShortBreak();
            break;
        case 3:
            setTimeForLongBreak();
            break;
    }
    resetProgressInCircle();
    enableButton("start");
}

function start() {
    setActiveButtonControl(1);
    isRunning = 1;
    disableButton("start");
    intervalID = setInterval(updateTime, 1000);
}

function setTimeForShortBreak() {
    modeSelected = 2;
    minute = 5;
    seconds = 0;
    clearInterval(intervalID);
    setActiveButtonMode(2);
    resetProgressInCircle();
    updateTimeInView(minute, "00");
    enableButton("start");
}

function setTimeForLongBreak() {
    modeSelected = 3;
    minute = 15;
    seconds = 0;
    clearInterval(intervalID);
    setActiveButtonMode(3);
    resetProgressInCircle();
    updateTimeInView(minute, "00");
    enableButton("start");

}

function setTimeForFocusMode() {
    modeSelected = 1;
    minute = 25;
    seconds = 0;
    clearInterval(intervalID);
    resetProgressInCircle();
    setActiveButtonMode(1);
    updateTimeInView(minute, "00");
    enableButton("start");

}

// end region


window.addEventListener('DOMContentLoaded', (event) => {
    // events
    setTimeForFocusMode();
    setActiveButtonControl(2);
    var buttonStart = document.getElementById("start");
    buttonStart.onclick = start;

    var buttonReset = document.getElementById("reset");
    buttonReset.onclick = reset;

    var buttonFocus = document.getElementById("focus");
    buttonFocus.onclick = setTimeForFocusMode;

    var buttonShort = document.getElementById("short");
    buttonShort.onclick = setTimeForShortBreak;

    var buttonLong = document.getElementById("long");
    buttonLong.onclick = setTimeForLongBreak;
});

// export functions
// export default { reset, start };

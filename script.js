

function reset() {

}

function start() {
    console.log("starting...");
}

function pause() {
    console.log("pausing...");
}



window.addEventListener('DOMContentLoaded', (event) => {
   // events
   var buttonStart = document.getElementById("start");
   buttonStart.onclick = start;
});

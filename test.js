const { JSDOM } = require('jsdom');
const assert = require('assert'); // O usa Chai
const sinon = require('sinon');

describe('unit test for pomodoro', function() {
    var dom;
    var clock;
    beforeEach(() => {
        dom = new JSDOM('<!DOCTYPE html><html><body></body></html>');
        global.document = dom.window.document;
        global.window = {
            addEventListener: (_name, _function) => {}
        };

        var minutesElement = global.document.createElement('div');
        minutesElement.id = "minute";
        global.document.body.appendChild(minutesElement);
        
        var secondsElement = global.document.createElement('div');
        secondsElement.id = "seconds";
        global.document.body.appendChild(secondsElement);

        var startElement = global.document.createElement('button');
        startElement.id = "start";
        global.document.body.appendChild(startElement);
        clock = sinon.useFakeTimers();
    });
    
    afterEach(() => {
        delete global.window;
        delete global.document;
        clock.restore();
    });
    
    it('[BLUE-51] template', function() {
        // const { start, reset } = require('./script.js');
        // var result = suma(2, 2);
        // assert.strictEqual(result, 4);
    });

    it('[BLUE-51] it should execute the function start', function() {
        const { start, reset } = require('./script.js').default;
        start();
        clock.tick(1000);

        var startButton = global.document.getElementById("start");
        var disabled = startButton.classList();

        assert.strictEqual(disabled, "disabled");
        
    });
});

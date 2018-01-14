var mraa = require('mraa');
var temp = new mraa.Aio(0);
var light = new mraa.Aio(1);
var sound = new mraa.Aio(2);
function readSensors(){
	var tempV = temp.read();
	var mv = (tempV/1024)*5000;
	var tempValue = mv/10;
	var lightValue = light.read();
	var soundValue = sound.read();
	console.log(tempValue);
	console.log(lightValue); 
	console.log(soundValue);

}
setInterval(readSensors, 2000);




var mraa = require('mraa');
var button = new mraa.Gpio(4);
button.dir(mraa.DIR_IN);
while(1) {
    var buttonState = button.read();
	console.log(buttonState);
}

setInterval(intervalFunc, 1500);
var fs = require('fs');
var random = require('random-number');
//Random values for temperature sensor 
var option = {
	min: 30,
	max: 100,
	integer: false
};

//Random value for humidity sensor
var option2 = {
	min: 40,
	max: 100,
	integer: false
};

//Random value for accelerometer sensor
var option3 = {
	min: 1,
	max: 100,
	integer: false
};

//Writing the temperature sensor's value
var temperature = fs.createWriteStream('temp_sensor.txt', {
	flag: 'a'
});
for(var i=1; i<=100;i++){
	var temp_r = (random(option));
	var temp = Math.round(temp_r*10)/10;
	var temp_string = "Line " + i + ", " + temp + "C";
	temperature.write(temp_string+"\r\n");
}


//Writing the humidity sensor's value
var humidity = fs.createWriteStream('humidity_sensor.txt', {
	flag: 'a'
});
for(var i=1; i<=100;i++){
	var hum_r = (random(option2));
	var hum = Math.round(hum_r*10)/10;
	var hum_string = "Line " + i + ", " + hum + "%";
	humidity.write(hum_string+"\r\n");
}

//Writing the accelerometer sensor's value
var accelerometer = fs.createWriteStream('accelerometer_sensor.txt', {
	flag: 'a'
});
for(var i=1; i<=100;i++){
	var acc_r = (random(option3));
	var acc = Math.round(acc_r*10)/10;
	var acc_string = "Line " + i + ", " + acc;
	accelerometer.write(acc_string+"\r\n");
}
var fs = require("fs");
var readLine = require("readline-specific");

//Creating database
var database = fs.createWriteStream('database.txt', {
	flag: 'a'
});

//creating timestamps
//var dt = new Date();

//writing the temperature value in database
var i=1;
function read_temp(){
	readLine.oneline('./temp_sensor.txt', i, function (err, data) { 
		if (err) { 
			return console.error(err); 
		} 
		var dt = new Date();
		var utcDate = dt.toUTCString();
		database.write(utcDate + " " + data+'\r\n');
		console.log(utcDate + " " + data);
		i++;
	});

}
setInterval(read_temp, 2000);

//writing the humidity value in database
var j=1;
function read_humidity(){
	readLine.oneline('./humidity_sensor.txt', j, function (err, data) { 
		if (err) { 
			return console.error(err); 
		} 
		var dt = new Date();
		var utcDate = dt.toUTCString();
		database.write(utcDate + " " + data+'\r\n');
		console.log(utcDate + " " + data);		
		j++;
	});

}
setInterval(read_humidity, 5000);

//writing the accelerometer value in database
var k=1;
function read_acceleration(){
	readLine.oneline('./accelerometer_sensor.txt', k, function (err, data) { 
		if (err) { 
			return console.error(err); 
		} 
		var dt = new Date();
		var utcDate = dt.toUTCString();
		database.write(utcDate + " " + data + '\r\n');
		console.log(utcDate + " " + data);
		k++;
	});

}
setInterval(read_acceleration, 10000);
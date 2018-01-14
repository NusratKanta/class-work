var events = require('events');
var eventEmitter = new events.EventEmitter();

// listener #1
var i =1;
var listner1 = function read_temp(){
	readLine.oneline('./temp_sensor.txt', i, function (err, data) { 
		if (err) { 
			return console.error(err); 
		} 
		database.write(data+'\r\n');
		i++;
		var dt = new Date();
		var utcDate = dt.toUTCString();
		//console.log(utcDate);
		console.log(utcDate + " " + data);
	});

}


// listener #2
var j =1;
var listner2 = function read_humidity(){
	readLine.oneline('./humidity_sensor.txt', j, function (err, data) { 
		if (err) { 
			return console.error(err); 
		} 
		database.write(data+'\r\n');
		j++;
		var dt = new Date();
		var utcDate = dt.toUTCString();
		console.log(utcDate + " " + data);
	});

}

// listener #3
var k = 1;
var listner3 = function read_acceleration(){
	readLine.oneline('./accelerometer_sensor.txt', k, function (err, data) { 
		if (err) { 
			return console.error(err); 
		} 
		database.write(data+'\r\n');
		k++;
		var dt = new Date();
		var utcDate = dt.toUTCString();
		console.log(utcDate + " " + data);
	});

}

// Bind the connection event with the listner1 function
eventEmitter.addListener('connection', listner1);

// Bind the connection event with the listner2 function
eventEmitter.on('connection', listner2);

var eventListeners = require('events').EventEmitter.listenerCount
   (eventEmitter,'connection');
console.log(eventListeners + " Listner(s) listening to connection event");

// Fire the connection event 
eventEmitter.emit('connection');

// Remove the binding of listner1 function
eventEmitter.removeListener('connection', listner1);
console.log("Listner1 will not listen now.");

// Fire the connection event 
eventEmitter.emit('connection');

eventListeners = require('events').EventEmitter.listenerCount(eventEmitter,'connection');
console.log(eventListeners + " Listner(s) listening to connection event");

console.log("Program Ended.");
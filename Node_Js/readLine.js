var readLine = require("readline-specific");
var random = require("node-random");

readLine.oneline('./input2.txt', 2, function (err, data) { 
	if (err) { 
		return console.error(err); 
	} 
	console.log(data);
});

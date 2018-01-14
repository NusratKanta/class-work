var fs = require('fs');
//Error Handler
function handleError(err){
	console.log("Error while writing the data: " + err);
}

fs.appendFile('input.txt', 'Hello\r\n', function(err){
	if(err){
		handlerError(err);
	}
});

fs.appendFile('input.txt', 'World', function(err){
	if(err){
		handlerError(err);
	}
});
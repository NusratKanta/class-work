var fs = require("fs");
var data_var = '';

// Create a readable stream
var readerStream = fs.createReadStream('input.txt');

// Set the encoding to be utf8. 
readerStream.setEncoding('UTF8');

// Handle stream events --> data, end, and error
readerStream.on('readerStream', function() {
  var chunk;
  while (null !== (chunk = readerStream.read(1))) {
    console.log(chunk); // chunk is one symbol
  }
});

readerStream.on('end',function(){
   console.log(data_var);
});

readerStream.on('error', function(err){
   console.log(err.stack);
});

//console.log("Program Ended");
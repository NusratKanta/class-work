
var fs = require('fs');

for(i=1; i<100; i++){
  var randTemp = Math.floor(Math.random() * 100) + 1;
  fs.appendFile('Temp.txt', randTemp+"\r\n", function (err) {
    if (err) throw err;

  });

}
  console.log('Saved!');
for(i=1; i<100; i++){
  var randHumidity = Math.floor(Math.random() * 100) + 1;
  fs.appendFile('Humidity.txt', randHumidity+"\r\n", function (err) {
    if (err) throw err;

  });

}
  console.log('Saved!');
for(i=1; i<100; i++){
  var randaccelerometer = Math.floor(Math.random() * 100) + 1;
  fs.appendFile('accelerometer.txt', randaccelerometer+"\r\n", function (err) {
    if (err) throw err;

  });

}
console.log('Saved!');

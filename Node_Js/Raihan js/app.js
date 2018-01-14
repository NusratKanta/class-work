var fs = require('fs');


function DataBase(){
 
  var randaccelerometer = Math.floor(Math.random() * 100) + 1;
  if(k<100){
    k++;
  fs.appendFile('accelerometer.txt', k+":"+randaccelerometer+"\r\n", function (err) {
    if (err) throw err;

  });
}
setTimeout(accelerometer,10000);
console.log('Saved3');
}
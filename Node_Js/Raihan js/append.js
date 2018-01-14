
var fs = require('fs');
temp_t();
Humidity_H();
accelerometer();
var i=0;
function temp_t(){

  var randTemp = Math.floor(Math.random() * 100) + 1;
  

  if(i<100){

  fs.appendFile('Temp.txt', i+":"+randTemp+"\r\n", function (err) {
    if (err) throw err;
    
  });
}
i++;
setTimeout(temp_t,2000);

console.log('Saved1');
}
var j=0;
function Humidity_H(){
  
  j++;
  var randHumidity = Math.floor(Math.random() * 100) + 1;
  if(j<100){

  fs.appendFile('Humidity.txt', j+":"+randHumidity+"\r\n", function (err) {
    if (err) throw err;

  });
}
setTimeout(Humidity_H,5000);
console.log('Saved2');
}
 var k=0;
function accelerometer(){
 
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

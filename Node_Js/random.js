var random = require('random-number');
var option = {
	min: 30,
	max: 100,
	integer: true
};
for(var i=0; i<100;i++){
	console.log(random(option));
	
}
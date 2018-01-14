var Morshed = {
	printName: function(){
		console.log("Morshed Khan");
		console.log(this === Morshed);
	}
};

Morshed.printName();
var person = Morshed;
person.printName();

function defaultCall(){
	console.log("\nDefault Calling to this");
	console.log(this === global);
}

defaultCall();
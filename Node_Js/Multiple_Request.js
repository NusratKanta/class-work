function placeOrder(orderNumber){
	console.log("Customer Order: ", orderNumber);
	deliverFood(function(){
			console.log("Delivered Food: ", orderNumber);
		});
}

//Simulate a 5 second operation
function deliverFood(callback){
	setTimeout(callback, 5000);
}

//Simulate users request
placeOrder(1);
placeOrder(2);
placeOrder(3);
placeOrder(4);
placeOrder(5);
placeOrder(6);
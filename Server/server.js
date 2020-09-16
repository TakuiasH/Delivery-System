var app = require('express')();
var http = require('http').createServer(app);
var io = require('socket.io')(http);

io.on('connection', (socket) => {
	socket.emit("socketConnected", socket.id);

	socket.on('newRequest', (data) => {
		socket.broadcast.emit("newRequest", data);
	});
	socket.on('getRequests', (data) => {
		socket.broadcast.emit("getRequests", data);
	});
	socket.on('editRequest', (data) => {
		socket.broadcast.emit("editRequest", data);
	});
	socket.on('addNumber', (data) => {
		socket.broadcast.emit("addNumber", data);
	});
	socket.on('removeRequest', (data) => {
		socket.broadcast.emit("removeRequest", data);
	});
	socket.on('newDeliveryman', (data) => {
		socket.broadcast.emit("newDeliveryman", data);
	});
	socket.on('clearDeliverymanData', (data) => {
		socket.broadcast.emit("clearDeliverymanData", data);
	});
	socket.on('newClient', (data) => {
		socket.broadcast.emit("newClient", data);
	});
	socket.on('clearClientsData', (data) => {
		socket.broadcast.emit("clearClientsData", data);
	});
	socket.on('disconnect', () => {
		io.emit("disconnected");
	});

});

http.listen(3000, () => {
  console.log('listening on *:3000');
});
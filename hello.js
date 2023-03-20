//http 모듈 불러오기
var http = require("http");

http.createServer(function (request, responese){

    responese.writeHead(200, {'Content-Type' : 'text/plain'})

    responese.end('Hello world\n');

}).listen(8000);

console.log('Server running at http://127.0.0.1:8000/')
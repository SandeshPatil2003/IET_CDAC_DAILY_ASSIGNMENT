const http = require('http')

let u= require('url')

let todos = [{ id: 1, task:"Task One"},{id:2, task:"Task Two"}];

const server = http.createServer(function(req,res){

    const method= req.method;
    const url= req.url;

    const parsedUrl= new u.URL(url,`http://${req.headers.host}`);

    const pathName= parsedUrl.pathname;

    if(pathName=='/todos')
    {
        res.writeHead(200,{'Content-Type':'application/json'});

        res.end(JSON.stringify(todos));
    }
    if(pathName=='/todos/1')
    {
        res.writeHead(200,{'Content-Type':'application/json'});

        res.end(todos[0].task);
    }

    if(pathName=='/todos/2')
    {
        res.writeHead(200,{'Content-Type':'application/json'});

        res.end(todos[1].task);
    }
})


server.listen(3001)
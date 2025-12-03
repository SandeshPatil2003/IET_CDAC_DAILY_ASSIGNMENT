const h = require('http')

h.createServer((req,res)=>{

    console.log("Method"+req.method)



    if(req.method==='POST')
    {
          res.writeHead(200,{'Content-Type':'text/html'});
        res.write("Post Method Used")
        res.end("This is end of request");
    }

    if(req.method==='PUT')
    {
          res.writeHead(200,{'Content-Type':'text/html'});
        res.write("Put Method Used")
        res.end();
    }

     if(req.method==='GET')
    {
          res.writeHead(200,{'Content-Type':'text/html'});
        res.write("Get Method Used")
        res.end("This is end of request");
    }
}).listen(8080,()=>{console.log("Server Created")})
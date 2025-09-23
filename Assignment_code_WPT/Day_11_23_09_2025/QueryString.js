
const h = require('http')
const u = require('url')

const s= h.createServer( 
    
    function(req,res){

        let link = req.url;
        let data = u.parse(link,true).query;

        console.log(link);
        console.log(data);
        console.log(data.fName);

        res.writeHead(200, {'Content-Type': 'text/html'});


        res.write("<h2> Hello "+data.fName+"<h2>")
        res.end();



        



})

s.listen(3030)
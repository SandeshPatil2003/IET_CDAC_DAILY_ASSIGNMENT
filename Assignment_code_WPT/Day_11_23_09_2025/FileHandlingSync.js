const f = require('fs')

//f.writeFile('data.txt', "Hello from node to file",
    //(err)=>{console.log(err);})


    f.appendFile('data.txt', "Hello from node to file version 2",
    (err)=>{console.log(err);})




f.readFile('data.txt',"utf-8",(err,data1)=>
    {

        if(err){
            console.log("Error occurred")
        }
        else{
            console.log(data1)
        }

        }

)


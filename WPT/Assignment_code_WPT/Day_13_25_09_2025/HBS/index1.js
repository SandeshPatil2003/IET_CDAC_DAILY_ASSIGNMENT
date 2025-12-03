
//import bodyParser from 'body-parser'
console.log("FROM INDEX")
const exp = require('express')
const app=exp();


app.set('views', './views');

app.set('view engine', 'hbs');

app.use(exp.urlencoded({extended:true}))


const port=4000;


app.get('/Calc', (req, res) => {
    res.render("calc")
})

//app.use(bodyParser.urlencoded({ extended: true }));

// 

app.post("/calculation", (req, res) => {

  
    let n1 = req.body.num1
    let n2 = req.body.num2

    let sum = parseInt(n1) + parseInt(n2)
    res.render("calc", { result: sum })
})


app.listen(port, ()=>{
    console.log("server started .....");
})
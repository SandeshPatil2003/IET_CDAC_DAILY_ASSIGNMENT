//import express from 'express'
const express = require('express')

let app = express()

app.set('views', './views');

app.set('view engine', 'hbs');


const port = 4000;
app.use((req, res, next) => {
    console.log('Time:', Date.now())
 
  //  req.set('data', "from use");  
    next() 
})

app.get("/about", (req, res) => {
    console.log('about');
    // if (req.body.data) {


    // } else {

    // }  
    res.render("aboutus")//<>.hbs
})

app.listen(port);












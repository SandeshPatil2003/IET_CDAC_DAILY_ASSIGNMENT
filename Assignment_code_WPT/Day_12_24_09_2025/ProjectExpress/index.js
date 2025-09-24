console.log("From index.js")


const exp = require('express');
const app = exp();
const port = 8080;

const user_data = require("./MOCK_DATA.json")

app.get('/', (req, res)=>{
    console.log("Main page response");
});

app.get('/users', (req, res)=>{
    res.json(user_data)
});

app.get('/users/:id', (req, res)=>{

    const id = Number(req.params.id);

    const user = user_data.find(
        user => user.id === id
    )
   return res.json(user)
});

app.get('/users/:id/:email', (req, res)=>{

    const id = Number(req.params.id);
    const email = req.params.email;

    const user = user_data.find(
        user => user.id === id && user.email === email
    )
    
   return res.json(user)
});

app.delete('/users/:id', (req, res) => {
    const id = Number(req.params.id); 
    const userIndex = user_data.findIndex(
        user => user.id === id
    )
    

    const deletedItem = user_data.splice(userIndex, 1);
    return res.json(deletedItem);
});




app.listen(port)



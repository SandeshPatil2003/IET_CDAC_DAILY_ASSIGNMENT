
console.log("FROM INDEX")
const exp = require('express')
const fs = require('fs')

const app=exp();

const p = require('path')

const port=3000;

const user_data= require('./MOCK_DATA.json')

app.use(exp.json());
app.use(exp.urlencoded({extended : false}))
app.post('/addusers',(req,res)=>
{
    const data = req.body;
    const last_user = user_data[user_data.length - 1];


    user_data.push({id: last_user.id + 1, data});

    fs.writeFile('MOCK_DATA.json', JSON.stringify(user_data), (err)=>{
        console.log(err);
    });
    return res.json("Data added successfully");
});


// app.put('/users/:id', (req, res) => {
//     const id = Number(req.params.id); 

//     const newData = req.body;
//     console.log(newData);

//     return res.json(newData)

//     // const userIndex = user_data.findIndex(
//     //     user => user.id === id
//     // )
//     //  if (userIndex === -1) {
//     //     return res.status(404).json({ message: "User not found" });
//     // }
 

//     // const userToUpdate = user_data[userIndex];


//     // console.log("Befor Write")
//     //userToUpdate.id = newData.id;

//     // userToUpdate.first_name=newData.first_name;
//     // userToUpdate.last_name=newData.last_name;
//     // userToUpdate.email = newData.email;
//     // userToUpdate.gender=newData.gender;
//     // userToUpdate.ip_address=newData.ip_address;

// //       fs.writeFile('MOCK_DATA.json', JSON.stringify(user_data, null, 2), (err) => {
// //         if (err) {
// //             return res.status(500).json({ message: "Error saving data" });
// //         }
// //         return res.json({ message: "User updated successfully", user: userToUpdate });
// //     });
// //  console.log("After Write");
  

// });
app.put('/users/:id', (req, res) => {

      const id = Number(req.params.id); 

    const newData = req.body;
    console.log("Updating user ID:", id);
     console.log("Received data:", newData)
   // console.log(newData);


       const userIndex = user_data.findIndex(
        user => user.id === id
    )
     if (userIndex === -1) {
        return res.status(404).json({ message: "User not found" });
    }
 

    const userToUpdate = user_data[userIndex];


    console.log("Befor Write")
    //userToUpdate.id = newData.id;

    userToUpdate.first_name=newData.first_name;
    userToUpdate.last_name=newData.last_name;
    userToUpdate.email = newData.email;
    userToUpdate.gender=newData.gender;
    userToUpdate.ip_address=newData.ip_address;

      fs.writeFile('MOCK_DATA.json', JSON.stringify(user_data, null, 2), (err) => {
        if (err) {
            return res.status(500).json({ message: "Error saving data" });
        }
        return res.json({ message: "User updated successfully", user: userToUpdate });
    });
 console.log("After Write");

    return res.json(newData)


 
});



app.get('/aboutus',(req,res)=>
{

    const t = p.join(__dirname,'aboutus.html')

    res.sendFile(t)
})


app.listen(port, () => {
    console.log("Server is running.......");
});


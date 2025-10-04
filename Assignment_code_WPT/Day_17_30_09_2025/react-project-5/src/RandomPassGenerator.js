
import { useState, useEffect, useRef } from "react";

export default function RandomPassGenerator(){

      const [selectedOption, setSelectedOption] = useState([null]);

    let referencepass = useRef('');
     let inputField = useRef(null);
    
    let lowercase='abcdefghijklmnopqrstwxyz';
    let uppercase = 'ABCDEFGHIJKLMNOPQRSTUVWXYZ';
    let numbers='0123456789';
    let scharacters='!@#$%^&*()';



    // function passwordGenerator(){
      
function pass1(){
      let newPass = '';

        newPass+= lowercase.charAt(Math.floor(Math.random()*lowercase.length));

       
      

         referencepass.current+=newPass;
          console.log("pass:"+referencepass.current)
}

function pass2(){
      let newPass = '';

        newPass+= uppercase.charAt(Math.floor(Math.random()*uppercase.length));

       
      

         referencepass.current+=newPass;
          console.log("pass:"+referencepass.current)
}

function pass3(){
      let newPass = '';

        newPass+= numbers.charAt(Math.floor(Math.random()*numbers.length));

       
      

         referencepass.current+=newPass;
          console.log("pass:"+referencepass.current)
}

function pass4(){
      let newPass = '';

        newPass+= scharacters.charAt(Math.floor(Math.random()*scharacters.length));

       
      

         referencepass.current+=newPass;
          console.log("pass:"+referencepass.current)
}
// const handleCheckboxChange = (event) => {
//     const value = event.target.value;
//    // const isChecked = event.target.checked;

//    set
// }


function choosepass()
{
for(let j=0;j<8;j++)
{
    switch(Math.floor((Math.random()*4)+1))
    {
        case 1: pass1();
                break;
        case 2: pass2();
                break;
        case 3: pass3();
                break;
        case 4: pass4();
                break;
        default:
                    console.log("Error default")
                    break;

    }

    
}

 console.log("Last pass:"+referencepass.current)
}


choosepass();

        return(
            <>
                <h1>Password Generator</h1>
                <input type="text" ref={inputField}></input>
                <br />
                <input type="checkbox" id="lowercase" value="lowercase"
                checked={selectedOption === 'lowercase'}
              /> Lowercase
                 <br />

                <input type="checkbox" id="uppercase" value="uppercase"
                checked={selectedOption === 'uppercase'}
               /> Uppercase
                <br />
                
                <input type="checkbox" id="number" value="number"
                checked={selectedOption === 'number'}
                /> Numbers
                 <br />
                <input type="checkbox" id="schar" value="schar"
                checked={selectedOption === 'schar'}
                /> Special Characters

                
            </>
        )

}
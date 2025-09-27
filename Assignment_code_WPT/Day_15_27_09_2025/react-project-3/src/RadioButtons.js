

import { useState, useEffect } from "react"

export default function RadioButtons()
{


     let [data, setData]=useState("")
     let [selected, setSelected] = useState("");

     let [output, setOutput] = useState("");


        function getData(e){
        console.log(e.target.value)  
        setData( e.target.value)
     
     }
    console.log("Data outside ", data)
     function handleChange(e){
        //console.log(e.target.value);

        setSelected(e.target.value)
     //   displayOutput();

     }

function toTitleCase(str) {
  if (!str) return '';
  return str.toLowerCase().split(' ').map(word => {
    return word.charAt(0).toUpperCase() + word.slice(1);
  }).join(' ');
}


     function displayOutput(){
let newOutput;
        switch(selected){
            case 'Lowercase' :
               // newOutput=data.toLowerCase();
                // setOutput(data.toLowerCase());
                return <h3>Lowercase :{data.toLowerCase()}</h3>
                break;
            case 'Uppercase' :
               // newOutput=data.toUpperCase();
            //    setOutput(data.toUpperCase());
            return <h3>Uppercase :{data.toUpperCase()}</h3>
                break;
            case 'Titlecase' :
                //newOutput=data.toWellFormed();
                // setOutput(data.toWellFormed());
            return <h3>Title case :{toTitleCase(data)}</h3>
            break;
            default :break;
        }
      //  setOutput(newOutput);
     }

     console.log("Selected :", selected)
    return(
        
        <>
Enter Data : <input type="text" onBlur={getData}></input>
        <br />

        <input type="radio" value="Lowercase" name="text"
        onChange={handleChange}

        >
            
        </input>LowerCase
        <br />
        <input type="radio" value="Uppercase" name="text"
            onChange={handleChange}>
            
        </input>UpperCase
        <br />
         <input type="radio" value="Titlecase" name="text"
             onChange={handleChange}>
            
        </input>Title Case

        <br />
        <div>{displayOutput()}</div>
        
        </>
    )


}

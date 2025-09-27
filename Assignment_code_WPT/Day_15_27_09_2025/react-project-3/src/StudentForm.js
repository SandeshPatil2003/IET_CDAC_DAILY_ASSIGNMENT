import { useState} from "react"

import GraduateComponent from "./GraduateComponent";
import PostGraduateComponent from "./PostGraduateComponent";
import UnderGraduateComponent from "./UnderGraduateComponent";

export default function StudentForm()
{

    let [selected, setSelected] = useState("");
    let [name, setName] = useState("");
    let [email, setEmail] = useState("");
    function PostSelection(e)
    {
        // console.log("Inside selection")
        // console.log(e.target.value)

        setSelected(e.target.value)


    }
    function renderComponent(){
        
        switch(selected){
            case 'Graduate' :
                return <GraduateComponent name={name} email={email}/>;
                break;
            case 'PostGraduate' :
                return <PostGraduateComponent name={name} email={email} />;
                break;
            case 'UnderGraduate' :
            return <UnderGraduateComponent name={name} email={email} />;
            break;
            default :break;
            
        }
    }

    return(<>


    <h1>Student FORM</h1>
    <br></br>
        Name:  <input type="text" onBlur={(e)=>setName(e.target.value)}></input>
    <br></br>
        Email:  <input type="email" onBlur={(e)=>setEmail(e.target.value)}></input>
    <br></br>
        <select value ={selected} onChange={PostSelection}>
            <option value="" disabled>-- Select a status --</option>
            <option value="UnderGraduate">Under Graduate</option>
            <option value="Graduate" >Graduate</option>
            <option value="PostGraduate" >Post Graduate</option>
            
        </select>



    
    
    <div>{renderComponent()}</div>
    
    
    
    
    
    
    </>)









}
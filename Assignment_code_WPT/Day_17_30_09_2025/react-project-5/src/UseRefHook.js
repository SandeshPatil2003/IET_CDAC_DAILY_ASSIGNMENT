import { useEffect, useRef, useState } from "react";


export default function UseRefHook()
{
    let reference= useRef(0);

    let [result, setResult]=useState(0);
    useEffect(()=>{
        reference.current = 10;
    }, []);


    function update(){
        reference.current+=1;
        console.log("Updated to"+reference.current);
    }

    function Display(){
         setResult(reference.current); 
    }
    return(
        <>
      

        <button type="button" onClick={update}>Update Ref Value</button>
        <button type="button" onClick={Display}>Display Update</button>
         Count : {result}
        </>
    )
}
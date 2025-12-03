import React, {useState} from "react";

export default function Counter(){
    
    const [count, setCount]=useState(0);

    return(
        <>
        <h1>Counter</h1>
        <h4>Current Count : {count}</h4>

        <button type="button" onClick={()=>{setCount(count+1)}}>Increment</button>
        <button type="button" onClick={()=>{setCount(count-1)}}>Decrement</button>
        </>
    )
}
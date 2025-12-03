import { useState, useEffect } from "react";
function CounterApplication () {

    let [count, setCount] = useState(0);

      // function increment () {setCount(count+=1)}

        // useEffect(()=>{
        //      console.log("Initial Render UseEffect invoked");
        // },[count ==5])

        //   useEffect(()=>{
        //      console.log("Count Increment Render UseEffect invoked");
        // },[count])



    return(
        <>
        counter : {count}
        <br></br>
        <button type="button" onClick={()=>setCount(count+1)}>Count++</button>
        </>
    )

}

export default CounterApplication;



import React, { useCallback, useState } from "react";
// unique
const funcSet = new Set();

const DemoCallBack = () => {
    const [count, setCnt] = useState(0);
    const [num, setNum] = useState(0);

    const incrementCnt = useCallback(
        () => setCnt((prevcnt) => prevcnt + 1)
        , []);
   
    const decrementCnt = useCallback(() => setCnt(count - 1),
        []);
        
    const incrementNum = useCallback(() => setNum(num + 1),
        [num]);

   
    funcSet.add(incrementCnt);
    funcSet.add(decrementCnt);
    funcSet.add(incrementNum);



    return (
        <div>
            <h2>Without useCallback Hook</h2>
            <button onClick={incrementCnt}>Increase Counter</button>
            <button onClick={decrementCnt}>Decrease Counter</button>
            <button onClick={incrementNum}>Increase Number</button>

            <h1>Count : {count}</h1>
            <h1>Number : {num}</h1>
            <h2>Set Size  : {funcSet.size}</h2>
        </div>
    );
};

export default DemoCallBack;
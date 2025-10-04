import React, { useState , useRef } from 'react'

const Pass2 = () => {
    let length = useRef(8)
    let password = useRef("")
    const [isDigit , setIsDigit] = useState(false);
    const [isSC , setIsSC] = useState(false);

    function generatePassword(s , l){
        let pass="";
        for(let i=0 ; i<length.current.value ; i++){
            pass+=s[Math.floor(Math.random()*l)];
        }
        return pass;
    }

    function handelClick(){
        const c = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
        const d ="1234567890";
        const sc="!@#$%^&*()-=+_?/>.<,]}[{";
        let pass ="";

        if(isDigit && isSC){
            let s=c+d+sc;
            let l = s.length;
            pass = generatePassword(s , l); 
        }else if(isDigit){
            let s=c+d;
            let l = s.length;
            pass = generatePassword(s , l); 
        }else if(isSC){
            let s=c+sc;
            let l = s.length;
            pass = generatePassword(s , l); 
        }else{
            pass = generatePassword( c , c.length); 
        }
        password.current.value=pass;
    }
  return (
    <div>
        <input readOnly ref={password}/>
        <br/>
        <label htmlFor='legth'> Enter length :</label>
        <input type='number' name='length' defaultValue={8} ref={length}/>
        <br></br>
        <label htmlFor='digit'> digit</label>
        <input type='checkbox' name="digit" onChange={()=>{ setIsDigit((pre)=>!pre) }}/>
        <br></br>
        <label htmlFor='SpacialChar' > SpacialChar</label>
        <input type='checkbox' name="SpacialChar" onChange={()=>{ setIsSC((pre)=>!pre) }}/>
        <br></br>

        <button onClick={handelClick}>Generate</button>
        
    </div>
  )
}

export default Pass2
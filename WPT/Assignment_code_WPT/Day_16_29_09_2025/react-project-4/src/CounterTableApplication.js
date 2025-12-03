import { useState, useEffect, useRef } from "react";



        // let table=document.getElementById("t1");
        // let newRow= table.insertRow(table.rows.length);

        // newRow.insertCell(0).innerHTML=fname;




function CounterTable () {

    let [count, setCount] = useState(0);
      let [countTable, setCountTable] = useState([]);
     const tableRef = useRef(null); 



    //  useEffect(()=>{

    //          console.log("Count Increment Render UseEffect invoked");


    //     },[count])
          useEffect(()=>{

            const table = tableRef.current;
            let tblArr = [];
           // setCountTable(count)
             console.log("Count Increment Render UseEffect invoked");
            for(let i=1;i<=10;i++){
                   tblArr.push(count*i)
        }

        setCountTable(tblArr)

        //       if (table && count > 0) {
    
        //          let newRow = table.insertRow(-1);
    
      
        //         for(let i=0;i<10;i++){
        //         let newCell = newRow.insertCell(i);
        //         newCell.innerHTML = count*(i+1);
        //      }
        //   }
  },[count]); 
            
    return(
        <>
        counter : {count}
        <br></br>
        <button type="button" onClick={()=>setCount(count+1)}>Count++</button>
      

      <div>
         {countTable.map((value, index) => (
        <td key={index}>{value}</td>
      ))}
        {/* counter Table :
        {countTable} */}
      </div>
        {/* <table id="t1" ref={tableRef}>
            <tbody>
            <tr>
                <th>Count Table</th>
            </tr>
            </tbody>
        </table> */}
        </>
    )

}

export default CounterTable;



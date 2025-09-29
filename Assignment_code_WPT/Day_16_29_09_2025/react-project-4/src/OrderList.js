import { useState, useEffect } from "react";


export default function OrderList () {
    
    let [listItem, setList] = useState([]);

    function addItem(e){
const value = e.target.value.trim();
if(value){

        let arr = [...listItem];
        arr.push(value)
           setList(arr);
    e.target.value = "";
}
    
    }
    return(
        <>
        Enter Text : <input type="text" onBlur={addItem} />
      
        <ol>
           {listItem.map((item, index) =>(
            <li key={index}>{item}</li>
           ))}
        </ol>
      
        </>
    )
};

//  {countTable.map((value, index) => (
//         <td key={index}>{value}</td>
//       ))}

// function addItem(e) {
//   const value = e.target.value.trim();
//   if (value) {
//     // Create a new array copying existing state
//     let newArray = [...listItem];
//     // Push new element into the new array
//     newArray.push(value);
//     // Update state with new array
//     setList(newArray);
//     e.target.value = ""; // clear input after adding
//   }
// }

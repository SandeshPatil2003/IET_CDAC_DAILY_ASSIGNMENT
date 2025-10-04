import axios from 'axios';
import {useState} from 'react';
export default function AxiosLoadData(){

    let [resData, setResData] = useState([]);
    let fetchedData = axios.get("https://jsonplaceholder.typicode.com/posts");
    
    // console.log(fetchedData.data);
    fetchedData.then((res)=>{
        setResData(res.data);
    }).catch(err=>{
        console.log("Error :"+err);
    })



    return(
        <>
        <h1>Data From Axios</h1>

        <table>
                <thead>
        <tr>
          <th>Index</th>
          <th>Value</th>
        </tr>
      </thead>
            <tbody>
               
                
                    {resData.map((item)=>(
                        <tr key={item.index}>
                        <td >{item.id}</td>
                        <td>{item.title}</td>
                             </tr>
                    ))}
               
            </tbody>
        </table>
        </>
    )
}

       
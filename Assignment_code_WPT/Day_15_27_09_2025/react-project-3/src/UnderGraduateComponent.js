import { useState} from "react"


//If the user selects UnderGrad show UnderGradComponent SSC , HSC
export default function UnderGraduateComponent(props)
{
  return(
        <>
         <h1>Under Graduate</h1>
        <h3>Name : {props.name}</h3>
        <h3>Email : {props.email}</h3>
        <h3>SSC : 75%</h3>
         <h3>HSC : 85%</h3>
        </>
    )  
}
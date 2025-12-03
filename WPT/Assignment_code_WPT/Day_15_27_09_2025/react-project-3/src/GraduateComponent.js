import { useState} from "react"



// degree, year, final year score, univ
export default function GraduateComponent(props)
{
    return(
        <>
        <h1>Graduate</h1>
        <h3>Name : {props.name}</h3>
         <h3>Email : {props.email}</h3>
         <h3>Degree : BE</h3>
         <h3>Year : 2025</h3>
         <h3>Final Year Score : 8.00</h3>
         <h3>University : SPPU</h3>
        </>
    )
}
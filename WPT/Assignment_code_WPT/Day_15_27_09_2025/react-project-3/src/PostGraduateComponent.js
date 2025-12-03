import { useState} from "react"


//If the user selects PG show PGComponent year, Thesis subject

export default function PostGraduateComponent(props)
{
    return(
        <>
         <h1>Post Graduate</h1>
        <h3>Name : {props.name}</h3>
        <h3>Email : {props.email}</h3>
        <h3>PG Year : 2025</h3>
        <h3>Thesis : Artificial Intelligence</h3>
        </>
    )
}
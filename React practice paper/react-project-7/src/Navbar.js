
import React from "react"
 import  { Link } from "react-router-dom";
// import Home from "./Home"
// import About from "./About"
// import Contact from "./Contact"
// import Counter from "./Counter"

export default function Navbar(){


    return(
        <>
     

      
        <div>
            <nav>
               <ul>
                <li>
                    <Link to="/">Home</Link>
                </li>
                 <li>
                    <Link to="/about">About</Link>
                </li>
                 <li>
                    <Link to="/contact">Contact Us</Link>
                </li>
                   <li>
                    <Link to="/counter">Counter</Link>
                </li>
               </ul>
            </nav>
            {/* <nav id="nav">
              
                    <Link to="/">Home </Link>
               
                    <Link to="/about">About </Link>
               
                    <Link to="/contact">Contact Us </Link>
               
                    <Link to="/counter">Counter </Link>
               
            </nav> */}
        </div>
        
        </>
    )
}
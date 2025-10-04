 import Home from './Home';
import AboutUs from './AboutUs';
import Contact from './Contact';

 import {
    BrowserRouter, Routes, Route, NavLink
    , Link,
    useNavigate
} from "react-router-dom";

 export default function Navbar(){

 
 return (
    <div className="App">

  
        {/* <Counter name="Counter 2" /> */}

        {/* <AppContext></AppContext> */}
   
       <nav>
            <ul>
                <li>
                    <Link to="/">Home</Link>
                </li>
                  <li>
                    <Link to="/AboutUs">About us</Link>
                </li>
                  <li>
                    <Link to="/Contact">Contact</Link>
                </li>
            </ul>
        </nav>
         {/* <Routes>
                    <Route path="/" element={<Home />} />
                    <Route path="/AboutUs" element={<AboutUs />} />
                    <Route path="/Contact" element={<Contact />} />
                    
                </Routes> */}
            
</div>
 )
  }
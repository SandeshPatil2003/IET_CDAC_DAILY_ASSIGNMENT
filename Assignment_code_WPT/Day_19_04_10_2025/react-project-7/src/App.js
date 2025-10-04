
import './App.css';

 import {
    BrowserRouter, Routes, Route, NavLink
    , Link,
    useNavigate
} from "react-router-dom";
import Counter from './Counter';

import AppContext from './useContext';

import Navbar from './Navbar';
import Home from './Home';
import AboutUs from './AboutUs';
import Contact from './Contact';
function App() {
 return (

 
  <BrowserRouter>
   <>
  <Navbar />

    <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/AboutUs" element={<AboutUs />} />
          <Route path="/Contact" element={<Contact />} />
        </Routes>
         </>
  </BrowserRouter>

 )
}

export default App;

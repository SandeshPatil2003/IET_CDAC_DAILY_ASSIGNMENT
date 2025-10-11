
import './App.css';

 import {
    BrowserRouter, Routes, Route, 
} from "react-router-dom";

import Navbar from './Navbar';
import Home from './Home';
import About from './About';
import Contact from './Contact';
import Counter from './Counter';
function App() {
 return (
<>
<BrowserRouter>

  {/* <Router> */}
  <Navbar/>

  <Routes>
    <Route path='/' element={<Home />} />
    <Route path='/about' element={<About /> }/>
    <Route path='/contact' element={<Contact />} />
    <Route path='/counter' element={<Counter />} />
  </Routes>

  {/* </Router> */}

</BrowserRouter>
</>
 
 
 )
}

export default App;

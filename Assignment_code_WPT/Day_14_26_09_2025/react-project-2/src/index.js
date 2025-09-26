import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';
import Factorial from'./Factorial';
import Calculator from'./Calculator';
import TestFunction1 from './TestFunctions';
import { TestFunction2,TestFunction3 } from './TestFunctions';

import CaseConverter from './TextCase'


const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
    
    <Factorial number="5"/>
    <Calculator num1="30" num2="10" operation="Mul"/>
    <TestFunction1>
    
    </TestFunction1>

    <TestFunction2>
    
    </TestFunction2>

    <TestFunction3>
    
    </TestFunction3>

    <CaseConverter />
 
  </React.StrictMode>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();

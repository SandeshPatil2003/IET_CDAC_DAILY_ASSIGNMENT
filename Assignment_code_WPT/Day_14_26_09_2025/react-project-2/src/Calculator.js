
export default function Factorial(prop){

    
    let num1 = parseFloat(prop.num1)
    let num2 = parseFloat(prop.num2)

    let operation=prop.operation;

    function Add()
    {
        return num1+num2;

    }

    function Sub()
    {
        return num1-num2;
    }

    function Mul()
    {
        return num1*num2;
    }

    function Div()
    {
        return num1/num2;
    }
    
if(operation == 'Add')
    return(

    <h2> 

        Numbers are : {num1},{num2};
         <br />
        
         Addition is {Add()}

    </h2>)
    else if(operation == 'Sub'){
         return(

    <h2> 

        Numbers are : {num1},{num2};
         <br />

         Subtraction is {Sub()}
    
    </h2>)
    }
     else if(operation == 'Mul'){
         return(

    <h2> 

        Numbers are : {num1},{num2};
         <br />

         Multiplication is {Mul()}
    
    </h2>)
    }
     else if(operation == 'Div'){
         return(

    <h2> 

        Numbers are : {num1},{num2};
         <br />

         Division is {Div()}
    
    </h2>)
    }
    else{
        return(
        <h2>Invalid Operation</h2>
        )
    }
}
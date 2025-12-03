

function fact1(n){

    if(n<0){
        console.log("Factorial is not possible for negative number");
        return null;
    }
    let fact=1;

    for(let i=2;i<=n;i++){
        fact*=i;
    }
    return fact;
}


function fact2(n)
{
    if(n<=1)
        return 1;

    return n*fact2(n-1)
}

function factorialImpl(choice){
    if(choice.toUpperCase() === "FORLOOP")
    {
        return fact1(5);
    }
    else if(choice.toUpperCase() === "RECUR"){
        return fact2(6);
    }
}

let result = factorialImpl("forloop");

console.log("Using forloop choice :"+result);
console.log("Using Recursion choice :" +factorialImpl("RECUR"));
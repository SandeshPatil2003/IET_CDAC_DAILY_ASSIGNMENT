
function factorial(n){

    if(n<=1)
        return 1;
    else 
        return n*factorial(n-1);

}


let a=process.argv[2]

console.log(factorial(a));
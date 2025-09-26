
export default function Factorial(prop){

    let fact = 1
    let num = parseFloat(prop.number)
    for (let a=1;a<=num;a++)
    {
        fact*=a;
    }

    return(<h1>

        {num} FACTORIAL IS {fact}</h1>)
}
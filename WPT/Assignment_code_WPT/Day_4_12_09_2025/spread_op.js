function calculate(...a){
    let sum=0;
    a.forEach((el)=>{
        sum+=el;
    })
 console.log("Addition of elements is :"+sum)
//      a.forEach((el)=>{
//        if(el%2 !=0)
//         console.log(el)
//     })
calculate(1,2,3,4,5)
let oddNumbers = a.filter((el)=>{
    return el%2!=0;
})

onsole.log(oddNumbers);
   // return sum;
}


//Testin function overriding in javascript
// function add(a,b,c=0){
//     return a+b+c;
// }
// function add(a,b,c=0,d=0){
//     return a+b+c+d
// }
// console.log("Addition by passing 2 para to 3 para fun :"+add(1,2))
// console.log("Addition by passing 3 para to 4 para fun :"+add(5,5,3))

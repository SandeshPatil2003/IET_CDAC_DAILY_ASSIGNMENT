arr=[428,423,4,23,52,6,6,45,345,8,953]


var max=0;
for(let i=0;i<arr.length;i++)
{
    if(max<arr[i])
    max=arr[i];

}
console.log("Using Normal for loop found largest :" +max);

let largest = arr[0]
arr.forEach((el)=> 
    {   
    if (el > largest) {
     largest = el; 
  }})
console.log("Using forEach found largest :" +largest);


const largestNumber = arr.reduce((accumulator, currentValue) => {
  return Math.max(accumulator, currentValue);
});


console.log("Using Reduce found largest :" +largestNumber); 
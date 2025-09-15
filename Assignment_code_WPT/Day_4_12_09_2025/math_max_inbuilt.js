function maxElement(...a){
 
 const max = Math.max(...a);
 console.log("Max element is :"+max)

 const min = Math.min(...a);
 console.log("Min element is :"+min)
console.log("Array without sort :" +a)
  let sortedArr =   a.sort((a,b)=>a-b)
    console.log("Array after sort is :" +sortedArr)


}

maxElement(1,55,77,30,4,5)

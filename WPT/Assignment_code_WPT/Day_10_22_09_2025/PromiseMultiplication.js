let a = process.argv[2]
let b = process.argv[3]


function multiplication(){
    let myPromise = new Promise((res,rej)=>{

        if(a >=0 && b>=0){
            res(a,b);
        }
        else{
            rej("Error : Value cannot be negative")
        }   
    })

myPromise.then(
    ()=>{
        console.log(a*b)
    })
    .catch((e)=>{
        console.log(e)
    })
    
}
multiplication();

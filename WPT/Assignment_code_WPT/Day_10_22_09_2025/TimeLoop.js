
console.log("program started");

console.log("basic log 1")

setImmediate(function A() {
	console.log("1st immediate");
});

console.log("basic log 2")

process.nextTick(function C() {
	console.log("1st process");
});

console.log("basic log 3")

setTimeout(()=>{console.log("Time out 1")},0)
console.log("basic log 4")

let myPromise= new Promise( (res,req)=>{

    let a=1;

    if(a>0) res(a)
        

})


myPromise.then((a)=>{
    console.log("Promise resolved"+a)

})

console.log("basic log 5")

setImmediate(function A() {
	console.log("2nd immediate");
});


process.nextTick(function C() {
	console.log("2nd process");
});
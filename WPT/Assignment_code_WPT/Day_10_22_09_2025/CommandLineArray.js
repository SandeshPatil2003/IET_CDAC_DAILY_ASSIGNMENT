

let a =[];let evensum=0,eindexsum=0,primesum=0;

for(i=0;i<10;i++)
{
    a[i]=process.argv[2+i];

    if(a[i]%2==0)
    {
        evensum+=parseInt(a[i])
    }

    if(i%2==0)
    {
        eindexsum+=parseInt(a[i])
    }
let flag=0;

    for(let j=2 ;j<a[i];j++)    
    {
        flag=0;

        

    if(a[i]%j==0)
    {
       
        flag=1;
        break;
    }
}

    if(flag==0)
    {
        primesum+=parseInt(a[i]);
    }


    



  //  console.log(a)

}


console.log(evensum);
console.log(eindexsum);
console.log(primesum);


//console.log(a)



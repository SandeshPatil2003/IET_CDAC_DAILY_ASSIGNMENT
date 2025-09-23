let num=process.argv[2]

let string=""


function pattern(num){

    if(1<=num && num<=5)
    {
        let string=""
        for(let i=0;i<num;i++)
        {
            string+="*"
             
        }

         console.log(string)

         num--;

         if(num>=1)

         pattern(num);
         

    }

    else{

        console.log("ERROR enter betwen 1-5")
    }
     // console.log(string)
}
pattern(num);
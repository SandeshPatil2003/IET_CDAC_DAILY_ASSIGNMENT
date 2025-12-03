

arr=[45,234,5,235,2,35,5]

switch(4)
{
    case 1: console.log("Popped end element choice 1 :"+arr.pop())
            console.log(arr);
            // console.log(arr.pop())
            // console.log(arr.pop())
            // console.log(arr.pop())

            break
    
    case 2: 
            arr.push(56)
            console.log("Pushed 56 into the array choice 2 :"+arr.at(-1))
            
            console.log(...arr);
    break;

    case 3:
            console.log("Removed first element using shift :"+arr.shift())
            console.log(...arr);
            break
    case 4:
        console.log("Added first element using unshift :"+arr.unshift("Added Me"))
        console.log("First element:"+arr.at(0))
        console.log(...arr);

        set1 = new Set(arr.sort((a, b) => a - b));
        console.log(...set1);
        break;

    case 5 :console.log("Exit outside program !")
    console.log(...arr);
       break;
    default:
        console.log("Invalid choice!")
        break;

}
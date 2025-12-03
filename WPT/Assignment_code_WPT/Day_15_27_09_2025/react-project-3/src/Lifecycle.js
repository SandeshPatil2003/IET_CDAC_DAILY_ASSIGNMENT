import { Component } from "react";



class Lifecycle extends Component{


    constructor(){
        super();
        this.state={
            data : "state change"
        }
         this.click=this.click.bind(this);
        console.log("This is constructor data :"+this.state.data)
        console.log("This is constructor")
       
    }
    

    static getDerivedStateFromProps()
    {
        console.log("This is getDerivedStatefromProps")


    }
    
     click(e){
        this.setState(
            {
                data:e.target.value,
            },
          () => {
            // This callback runs AFTER the state has been updated.
            console.log("This is the updated inside steState Data: " + this.state.data);
        })
        //console.log("This is updated Data :"+this.state.data)
        console.log(e.target.value)

        
    }

    render()
    {

        console.log("This is render")

        return (
        <>
        
        <button value="button1" onClick={this.click}>click</button>
        
        
        <h1>"This is render return"</h1>


        </>
    )
    
    }

   

    componentDidMount()
    {
        console.log("This is componentDidMount")


    }


    getSnapshotBeforeUpdate()
    {
        console.log("This is getSnapshotBeforeUpdate")

    }

    shouldComponentUpdate()
    {

         console.log("This is shouldComponentUpdate")

    }

    componentDidUpdate()
    {
        console.log("This is  componentDidUpdate")


    }


}

export default Lifecycle;



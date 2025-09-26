import {Component} from "react";

class CaseConverter extends Component{

    constructor(props){
        super(props);
       this.state ={
        inputValue :'',
        lowerCaseInputValue:'',
        upperCaseInputValue :''

      };
   this.handleInputChange = this.handleInputChange.bind(this);
    this.handleLowerCase = this.handleLowerCase.bind(this);
    this.handleUpperCase = this.handleUpperCase.bind(this);
      
    }
  
  
    handleInputChange(e){
    
          this.setState({
            inputValue :e.target.value,
           
        } )
   //      console.log(this.state.inputValue);

      
    }
    
    handleLowerCase(e){
    const lowerCaseText = this.state.inputValue.toLowerCase();

     this.setState({
         
            lowerCaseInputValue:lowerCaseText
        } )
    console.log("LowerCase is :" +lowerCaseText);
     
    }
       handleUpperCase(e){
    const upperCaseText = this.state.inputValue.toUpperCase();

     this.setState({
         
           upperCaseInputValue:upperCaseText
        } )
    console.log("uppercase is :"+upperCaseText);
     
    }

render(){
    return(
        <>
        <label>Enter Word :</label>
        <input type="text" name="input" id="i"
          onBlur={this.handleInputChange}
          placeholder="Enter text here"
        ></input>
        
        <button type="button" onClick={this.handleLowerCase}>Lowercase</button>
        <button type="button" onClick={this.handleUpperCase}>Uppercase</button>

        <p>UPPERCASE IS : {this.state.upperCaseInputValue}</p>
        <p>LOWERCASE IS : {this.state.lowerCaseInputValue}</p>
        </>
    )
}
}
export default CaseConverter;


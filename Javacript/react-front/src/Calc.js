import React from 'react';

class Calc extends React.Component {


    constructor(props){

    super (props)
    console.log ("constructor test");
    this.var1Change = this.var1Change.bind(this);
    this.var2Change = this.var2Change.bind(this);
    this.buttonClick = this.buttonClick.bind(this);

    }

    buttonClick(){
      console.log ("button clicked");
      let sum = parseInt(this.state.var1) + parseInt(this.state.var2);
        alert("Sum is: " + sum);
    }

    var1Change (event){
    console.log ("var1 method");
    this.setState ({var1: event.target.value});
    } 

    var2Change (event){
    console.log ("var2 method");
    this.setState ({var2: event.target.value});

    } 



    render() {
      return <div>
            <h1>Form</h1>
            <p> <input type="text" onChange={this.var1Change}/> </p>
            <p> <input type="text" onChange={this.var2Change}/> </p>
            <p> <button onClick={this.buttonClick}>Calculate</button> </p>
        </div>;

        
    }

}

export default Calc;
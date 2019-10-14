import React from 'react';

class Calc extends React.Component {

    buttonClick(){
      console.log ("button clicked");
    }

    render() {
      return <div>
            <h1>Form</h1>
            <p> <input type="text" /> </p>
            <p> <input type="text" /> </p>
            <p> <button onClick={this.buttonClick}>Calculate</button> </p>
        </div>;

        
    }

}

export default Calc;
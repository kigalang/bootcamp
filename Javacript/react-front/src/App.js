import React from 'react';
import './App.css';
import OwnComponent from './OwnComponent';
import Nappi from './Nappi';
function App() {
  return (
    <div className="App">
    
      <Nappi teksti="Oma Nappi" />
      <Nappi teksti="Lataa tiedot" />
      <Nappi teksti="Tallenna" />
      <Nappi teksti="Peruuta" />
      <OwnComponent />   
    </div>
  );
}

export default App;
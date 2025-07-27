import React from 'react';
import './App.css';
import CalculateScore from './Components/CalculateScore';

function App() {
  return (
    <div className="App">
      <CalculateScore name="Steeve" school="KIIT University" total={435} goal={500} />
    </div>
  );
}

export default App;

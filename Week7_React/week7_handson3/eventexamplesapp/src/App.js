import React from 'react';
import './App.css';
import EventExamples from './components/EventExamples';
import CurrencyConverter from './components/CurrencyConverter';

function App() {
  return (
    <div className="App">
      <h1>React Event Examples App</h1>
      <EventExamples />
      <CurrencyConverter />
    </div>
  );
}

export default App;

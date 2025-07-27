import React from 'react';
import './App.css';
import CohortDetails from './components/CohortDetails';

function App() {
  return (
    <div className="App">
      <h2>Cohort Dashboard</h2>
      <CohortDetails name="React Bootcamp" duration="6 Weeks" status="ongoing" />
      <CohortDetails name="Python DataTrack" duration="4 Weeks" status="completed" />
    </div>
  );
}

export default App;

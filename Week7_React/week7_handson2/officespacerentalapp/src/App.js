import React from 'react';
import './App.css';
function App() {
  const heading = <h1>Office Space Rental Dashboard</h1>;
  const imageUrl = "https://img.freepik.com/free-photo/3d-rendering-beautiful-luxury-bedroom-suite-hotel-with-tv-working-table_105762-2016.jpg";
  const featuredOffice = {
    name: "Sunshine Towers",
    rent: 45000,
    address: "MG Road, Mumbai"
  };
  const offices = [
    { name: "Sunshine Towers", rent: 45000, address: "MG Road, Mumbai" },
    { name: "Skyline Plaza", rent: 80000, address: "Indira Nagar, Bengaluru" },
    { name: "Pearl Heights", rent: 60000, address: "Salt Lake, Kolkata" },
    { name: "Metro Chambers", rent: 30000, address: "Baner, Pune" }
  ];
  const rentStyle = (rent) => ({
    color: rent < 60000 ? 'red' : 'green',
    fontWeight: 'bold'
  });

  return (
    <div className="App">
      {heading}

      <img src={imageUrl} alt="Office" width="500" style={{ borderRadius: '10px', margin: '20px 0' }} />

      <h2>Featured Office</h2>
      <p><strong>Name:</strong> {featuredOffice.name}</p>
      <p><strong>Rent:</strong> <span style={rentStyle(featuredOffice.rent)}>{featuredOffice.rent}</span></p>
      <p><strong>Address:</strong> {featuredOffice.address}</p>

      <h2>All Available Offices</h2>
      <ul>
        {offices.map((office, index) => (
          <li key={index} style={{ marginBottom: '15px', textAlign: 'left' }}>
            <strong>{office.name}</strong> - 
            Rent: <span style={rentStyle(office.rent)}>{office.rent}</span> - 
            Address: {office.address}
          </li>
        ))}
      </ul>
    </div>
  );
}

export default App;

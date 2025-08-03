import React from 'react';
const offices = [
  { name: 'Space A', rent: 45000, address: 'Downtown' },
  { name: 'Space B', rent: 65000, address: 'Midtown' }
];

function App() {
  return (
    <div>
      <h1>Office Space Rentals</h1>
      {offices.map((office, i) => (
        <div key={i}>
          <h2>{office.name}</h2>
          <p style={{color: office.rent > 60000 ? 'green' : 'red'}}>Rent: ₹{office.rent}</p>
          <p>Address: {office.address}</p>
        </div>
      ))}
    </div>
  );
}
export default App;

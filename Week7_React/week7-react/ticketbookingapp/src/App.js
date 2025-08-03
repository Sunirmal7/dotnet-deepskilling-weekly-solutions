import React, { useState } from 'react';

function GuestPage() {
  return <div><h2>Guest View: Browse Flights</h2></div>;
}

function UserPage() {
  return <div><h2>User View: Book Tickets</h2></div>;
}

function App() {
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  return (
    <div>
      <h1>Ticket Booking App</h1>
      <button onClick={() => setIsLoggedIn(!isLoggedIn)}>{isLoggedIn ? 'Logout' : 'Login'}</button>
      {isLoggedIn ? <UserPage /> : <GuestPage />}
    </div>
  );
}

export default App;

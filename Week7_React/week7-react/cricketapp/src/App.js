import React from 'react';
const players = [
  { name: 'Player1', score: 60 },
  { name: 'Player2', score: 75 },
  { name: 'Player3', score: 50 },
  { name: 'Player4', score: 90 }
];

const filtered = players.filter(p => p.score >= 70);

function App() {
  return (
    <div>
      <h1>Cricket Players</h1>
      <h2>Qualified Players</h2>
      <ul>
        {filtered.map((p, i) => <li key={i}>{p.name} - {p.score}</li>)}
      </ul>
    </div>
  );
}

export default App;

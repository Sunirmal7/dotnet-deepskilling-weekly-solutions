import React from 'react';
import '../Stylesheets/mystyle.css';

function CalculateScore({name, school, total, goal}) {
  const average = total / goal;
  return (
    <div className="score-box">
      <h2>{name} - {school}</h2>
      <p>Total: {total}</p>
      <p>Goal: {goal}</p>
      <p>Average Score: {average}</p>
    </div>
  );
}

export default CalculateScore;
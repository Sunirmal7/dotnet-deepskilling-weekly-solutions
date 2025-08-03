import React, { useState } from 'react';

function App() {
  const [count, setCount] = useState(0);
  const sayWelcome = (msg) => alert(msg);
  const handleClick = (e) => alert('I was clicked');

  return (
    <div>
      <h1>Event Handling</h1>
      <p>Counter: {count}</p>
      <button onClick={() => { setCount(count + 1); alert('Hello!'); }}>Increment</button>
      <button onClick={() => setCount(count - 1)}>Decrement</button>
      <button onClick={() => sayWelcome('Welcome')}>Say Welcome</button>
      <button onClick={handleClick}>OnPress</button>
    </div>
  );
}

export default App;

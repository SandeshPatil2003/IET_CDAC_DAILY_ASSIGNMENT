import React, { useState } from 'react';

function Counter({ name, willThrowError }) {
  const [count, setCount] = useState(0);

  const increment = () => {
    setCount(count + 1);
  };

  
  if (willThrowError && count >= 3) {
    throw new Error(`${name} has crashed!`);
  }

  return (
    <div >
      <h2>{name}: {count}</h2>
      <button onClick={increment}>Increment</button>
      {willThrowError && <p style={{ color: 'red' }}>This counter will crash at 3</p>}
    </div>
  );
}

export default Counter;
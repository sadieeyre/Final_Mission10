import React from 'react';
import './App.css';
import Header from './header';
import BowlerList from './Bowler/BowlerList';
import 'bootstrap/dist/css/bootstrap.min.css';

function App() {
  return (
    <div className="App">
      <Header />
      <br />
      <BowlerList />
    </div>
  );
}

export default App;

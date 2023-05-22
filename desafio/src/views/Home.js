import { Component } from 'react';
import '../App.css';
import Header from './shared/Header';

class Home extends Component {
  render() {
    return (
      <div className="App">
        <Header></Header>
       <h1>Home</h1>

      </div>
    );
  }
}

export default Home;

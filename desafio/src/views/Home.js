import { Component } from 'react';
import '../App.css';
import Header from './shared/Header';

class Home extends Component {
  render() {
    return (
      <div className="App">
        <Header></Header>
        <div className='home'>

          <h1>Welcome !</h1>
        </div>
        <div className='textHome'>
          <h3>To start go to import pages or click in link below</h3>
          <a href='/Import'>Import</a>
        </div>
        
      </div>
    );
  }
}

export default Home;

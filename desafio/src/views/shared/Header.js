import { Component } from 'react';
import '../../App.css';
import { NavLink } from 'react-router-dom';

class Header extends Component {
  render() {
    return (
      <div className="box-header">
        <link rel="preconnect" href="https://fonts.googleapis.com" />
        <link rel="preconnect" href="https://fonts.gstatic.com" crossOrigin="anonymous" />
        <link href="https://fonts.googleapis.com/css2?family=Merriweather:ital,wght@1,300&family=Poppins&family=Ubuntu:wght@300&display=swap" rel="stylesheet"></link>
        <nav>
          <div className="Logo">Gabriel Coradini</div>
          <div className='Links'>
            <ul className='nav-items'>
              <li><NavLink className="nav-link"  exac="true" to="/Import">Import</NavLink></li>
              <li><NavLink className="nav-link"  exact="true" to="/Sales">Sales</NavLink></li>
              <li><NavLink className="nav-link"  exact="true" to="/Sellers">Sellers</NavLink></li>
              <li><NavLink className="nav-link"  exact="true" to="/Login">Login</NavLink></li>
              
            </ul>
            
          </div>
          <button className="btn-logout" href='#'>Logout</button>

        </nav>


      </div>
    );
  }
}

export default Header;

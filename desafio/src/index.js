import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import Home from './views/Home';
import Import from './views/Import';
import Sales from './views/Sales';
import Types from './views/Types';
import Sellers from './views/Sellers';
import LoginForm from './components/loginform';
import {BrowserRouter, Routes, Route} from 'react-router-dom';

import reportWebVitals from './reportWebVitals';

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <BrowserRouter>
  <Routes>
    <Route path='/' exact={true} Component={Home}></Route>
    <Route path='/Import' exact={true} Component={Import}></Route>
    <Route path='/Sales' exact={true} Component={Sales}></Route>
    <Route path='/Sellers' exact={true} Component={Sellers}></Route>
    <Route path='/Types' exact={true} Component={Types}></Route>
    <Route path='/Login' exact={true} Component={LoginForm}></Route>
  </Routes>
  </BrowserRouter>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();

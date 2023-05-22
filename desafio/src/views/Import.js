import { Component } from 'react';
import '../App.css';
import Header from './shared/Header';
import React from 'react';
import Upload from '../components/upload';

class Import extends Component {



  render() {
    return (
      <div className="App">
        <Header></Header>
        <div className="titleUpload">
          <h1>Upload</h1>
        </div>
        <div className="upload">
          <Upload></Upload>
        </div>
        
      </div>
    );
  }
}

export default Import;

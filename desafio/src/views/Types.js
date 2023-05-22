import { Component } from 'react';
import '../App.css';
import Header from './shared/Header';
import axios from 'axios';

class Types extends Component {

  state = {
    varieties: []
  }
  

  componentDidMount() {
    axios.get('https://localhost:7299/api/Variety').then((response) => {
      const varieties = response.data;
      this.setState({ varieties });
      console.log(response);
    }).catch((err) =>{
      if(err.response){
          console.log(err.response);
      }else{
          console.log("Erro: Tente mais tarde");
      }
  })
  }

  render() {
    return (
      <div className="App">
        <Header></Header>
        <div >
          <h1 className='nameSellers' >Types</h1>
        </div>

        <div className='tableDiv'>
          <table>
            <thead className='table-title'>
              <tr>
                <th >Type </th>
                <th >Description </th>
                <th >Kind </th>
                <th >Signal </th>
              </tr>
            </thead>
            <tbody>
              {
                this.state.varieties.map(type => {
                  return <tr key={type.id}>
                    <td >{type.sort}</td>
                    <td >{type.description}</td>
                    <td >{type.kind}</td>
                    <td >{type.signal}</td>
                  </tr>
                })
              }


            </tbody>
          </table>
        </div>
      </div>
    );
  }

}

export default Types;

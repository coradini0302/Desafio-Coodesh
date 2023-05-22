import { Component } from 'react';
import '../App.css';
import Header from './shared/Header';
import axios from 'axios';

class Sellers extends Component {
  state = {
    sellers: []
  }

  componentDidMount(){
    axios.get('https://localhost:7299/api/Seller').then( (response) => {
      const sellers = response.data;
      this.setState({sellers});
      console.log(response);
    }).catch((err) =>{
      if(err.response){
          console.log(err.response);
      }else{
          console.log("Erro: Tente mais tarde")
      }
  })
  }


  render() {
    return (
      <div className="App">
        <Header></Header>
        <div >
          <h1 className='nameSellers' >Sellers </h1>
        </div>

        <div className='tableDiv'>
          <table>
            <thead className='table-title'>
              <tr><th colSpan="4">Names </th></tr>
            </thead>
            <tbody>
              {
                this.state.sellers.map(seller => {
                  return <tr key={seller.id}>
                    <td >{seller.name}</td>
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

export default Sellers;

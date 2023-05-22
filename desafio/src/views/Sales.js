import { Component } from 'react';
import '../App.css';
import Header from './shared/Header';
import axios from 'axios';

class Sales extends Component {
  state = {
    sales: []
  }

  componentDidMount(){
    axios.get('https://localhost:7299/api/GeneralSales').then( (response) => {
      const sales = response.data;
      this.setState({sales});
      console.log(response);
    })
  }


  render() {
    return (
      <div className="App">
        <Header></Header>
        <div >
          <h1 className='sales' >Sales </h1>
        </div>

        <div className='tableDiv'>
          <table>
            <thead className='table-title'>
              <tr><th colSpan="4">Type </th>
              <th colSpan="4">Date </th>
              <th colSpan="4">Product </th>
              <th colSpan="4">Value </th>
              <th colSpan="4">Name </th></tr>
            </thead>
            <tbody>
              {
                this.state.sales.map(seller => {
                  return <tr key={seller.id}>
                    <td >{seller.name}</td>
                    <td >{seller.name}</td>
                    <td >{seller.name}</td>
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

export default Sales;

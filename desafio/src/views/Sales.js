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
    }).catch((err) =>{
      if(err.response){
          console.log(err.response);
      }else{
          alert("Connection Error: Try Later!")
      }
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
              <tr>
                <th >Type </th>
                <th >Date </th>
                <th >Product </th>
                <th >Value </th>
                <th >Name </th>
              </tr>
            </thead>
            <tbody>
              {
                this.state.sales.map(sales => {
                  return <tr key={sales.id}>
                    <td >{sales.variety.sort}</td>
                    <td >{sales.date}</td>
                    <td >{sales.product.name}</td>
                    <td >{sales.value}</td>
                    <td >{sales.seller.name}</td>
                    
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

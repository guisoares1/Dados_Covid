import './App.css';
import React,{Component} from 'react'
import api from './Api';

export class Semana1 extends Component{
  
  state={
    CasosSemana1: [],
    MortesSemana1: [],
  }

  async componentDidMount(){
    const response = await api.get('api/Casos/1');
    this.setState({CasosSemana1: response.data});
    const response4 = await api.get('api/Mortes/1');
    this.setState({MortesSemana1: response4.data});  
  }
  
  render(){

    const {CasosSemana1} = this.state;
    const {MortesSemana1} = this.state;
    return(
      <div>
          <ul>
            {CasosSemana1.map(caso =>(
              <li key={caso.media} >
                 <h4>{caso.periodo}</h4>  
                 <h4>Casos: {caso.media}</h4> 
              </li>
            ))}
          </ul>
          <ul>
          {MortesSemana1.map(caso =>(
              <li key={caso.media} >
                 <h4>{caso.periodo}</h4>  
                 <h4>Mortes: {caso.media}</h4> 
              </li>
            ))}
          </ul>
      </div>
    );
  };
};
 
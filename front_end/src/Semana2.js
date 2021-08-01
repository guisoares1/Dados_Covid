import './App.css';
import React,{Component} from 'react'
import api from './Api';

export class Semana2 extends Component{
  
  state={
    CasosSemana2: [],
    MortesSemana2: [],
  }

  async componentDidMount(){
    const response = await api.get('api/Casos/2');
    this.setState({CasosSemana2: response.data});
    const response4 = await api.get('api/Mortes/2');
    this.setState({MortesSemana2: response4.data});  
  }
  
  render(){

    const {CasosSemana2} = this.state;
    const {MortesSemana2} = this.state;
    return(
      <div>
          <ul>
            {CasosSemana2.map(caso =>(
              <li key={caso.media}>
               <h4>{caso.periodo}</h4>  
               <h4>Casos: {caso.media}</h4> 
              </li>
            ))}
          </ul>
          <ul>
          {MortesSemana2.map(caso =>(
              <li key={caso.media}>
                <h4>{caso.periodo}</h4>  
                <h4>Mortes: {caso.media}</h4> 
              </li>
            ))}
          </ul>
      </div>
    );
  };
};
 
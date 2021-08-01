import './App.css';
import React,{Component} from 'react'
import api from './Api';

export class Semana3 extends Component{
  
  state={
    CasosSemana3: [],
    MortesSemana3: [],
  }

  async componentDidMount(){
    const response = await api.get('api/Casos/3');
    this.setState({CasosSemana3: response.data});
    const response4 = await api.get('api/Mortes/3');
    this.setState({MortesSemana3: response4.data});  
  }
  
  render(){

    const {CasosSemana3} = this.state;
    const {MortesSemana3} = this.state;
    return(
      <div>
          <ul>
            {CasosSemana3.map(caso =>(
              <li key={caso.media}>
                <h4>{caso.periodo}</h4>  
                <h4>Casos: {caso.media}</h4> 
              </li>
            ))}
          </ul>
          <ul>
          {MortesSemana3.map(caso =>(
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
 
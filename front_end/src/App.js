import './App.css';
import React,{Component} from 'react'
import api from './Api';

class App extends Component{
  
  state={
    CasosSemana1: [],
    CasosSemana2: [],
    CasosSemana3: [],
    MortesSemana1: [],
    MortesSemana2: [],
    MortesSemana3: [],
  }

  async componentDidMount(){
    const response = await api.get('api/Casos/1');
    this.setState({CasosSemana1: response.data});
    const response2 = await api.get('api/Casos/2');
    this.setState({CasosSemana2: response2.data});
    const response3 = await api.get('api/Casos/3');
    this.setState({CasosSemana3: response3.data});
    const response4 = await api.get('api/Mortes/1');
    this.setState({MortesSemana1: response4.data});
    const response5 = await api.get('api/Mortes/2');
    this.setState({MortesSemana2: response5.data});
    const response6 = await api.get('api/Mortes/3');  
    this.setState({MortesSemana3: response6.data});  
    
  }
  
  render(){

    const {CasosSemana1} = this.state;
    const {CasosSemana2} = this.state;
    const {CasosSemana3} = this.state;
    const {MortesSemana1} = this.state;
    const {MortesSemana2} = this.state;
    const {MortesSemana3} = this.state;
    return(
      <div>
          <h1 className="App">Média móvel Covid</h1>
          <h3>Casos</h3>
          <ul>
            {CasosSemana1.map(caso =>(
              <li key={caso.media}>
                <h3>{caso.semana} {caso.periodo}</h3>  
                 <p>{caso.media}</p> 
              </li>
            ))}
            {CasosSemana2.map(caso =>(
              <li key={caso.media}>
                <h3>{caso.semana} {caso.periodo}</h3>  
                 <p>{caso.media}</p> 
              </li>
            ))}
            {CasosSemana3.map(caso =>(
              <li key={caso.media}>
                <h3>{caso.semana} {caso.periodo}</h3>  
                 <p>{caso.media}</p> 
              </li>
            ))}
          </ul>
          <h3>Mortes</h3>
          <ul>
          {MortesSemana1.map(caso =>(
              <li key={caso.media}>
                <h3>{caso.semana} {caso.periodo}</h3>  
                 <p>{caso.media}</p> 
              </li>
            ))}
            {MortesSemana2.map(caso =>(
              <li key={caso.media}>
                <h3>{caso.semana} {caso.periodo}</h3>  
                 <p>{caso.media}</p> 
              </li>
            ))}
            {MortesSemana3.map(caso =>(
              <li key={caso.media}>
                <h3>{caso.semana} {caso.periodo}</h3>  
                 <p>{caso.media}</p> 
              </li>
            ))}
          </ul>
      </div>
    );
  };
};

export default App;

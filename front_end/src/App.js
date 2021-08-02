import './App.css';
import {Home} from './home'
import {Semana1} from './Semana1'
import {Semana2} from './Semana2'
import {Semana3} from './Semana3'
import {Navigation} from './Navigation'

import {BrowserRouter, Route, Switch} from 'react-router-dom'


function App() {
  return (
    <BrowserRouter>
      <div className="container">
        <h1 className = "m-3 d-flex justify-content-center">
          Média móvel Covid-19 
        </h1> 

        <Navigation/>
        <Switch>
          <Route path='/' component={Home} exact/>
          <Route path='/semana1' component={Semana1} />
          <Route path='/semana2' component={Semana2} />
          <Route path='/semana3' component={Semana3} />
        </Switch>

      </div>
    </BrowserRouter>
  );
}

export default App;

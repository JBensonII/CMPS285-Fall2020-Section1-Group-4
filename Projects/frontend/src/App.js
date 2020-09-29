import React from 'react';
import logo from './logo.svg';
import './App.css';
import { Button } from 'reactstrap';
import Login from './Components/Login/Login';
import MyNavBar from './Components/MyNavBar/MyNavBar';
import Jumbo from './Components/Jumbo/Jumbo';


import {
  BrowserRouter as Router,
  Switch,
  Route,
  Link, BrowserRouter
} from "react-router-dom";

function App() {
  return (
    <div className="App">
     <BrowserRouter>
      <Login/>
     
      <Switch>
        <Route exact path ="/jumbo" component={Jumbo}/>
      </Switch>
     </BrowserRouter> 
      
      

    </div>
  );
}

export default App;

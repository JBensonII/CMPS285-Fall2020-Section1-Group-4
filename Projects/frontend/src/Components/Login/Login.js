import React from 'react';
import { Button, Form, FormGroup, Label, Input, FormText } from 'reactstrap';
import './Login.css';


const Login = (props) => {
  return (
    <Form className = "Login">
      <FormGroup>
      <h2 class="Gray">Login</h2>
        <br></br>
      </FormGroup>
      <FormGroup>
        <Input type="username" name="username" id="exampleUsername" placeholder="Username" />
      </FormGroup>
      <br></br>
      <FormGroup>
        <Input type="password" name="password" id="examplePassword" placeholder="Password" />
      </FormGroup>
     
      <Button color="secondary" size="lg" block>Sign In</Button>

      
    </Form>
  );
}

export default Login;
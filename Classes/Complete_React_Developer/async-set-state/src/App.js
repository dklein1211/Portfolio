import React, {Component} from 'react';
import logo from './logo.svg';
import './App.css';

class App extends Component {
  constructor(props) {
    super(props);

    this.state = {
      counter: 0 + this.props.increment
    }
    this.props = props
  }

  handleClick = () => {
    this.setState((prevState, prevProps) => {
      console.log('args', prevState, prevProps)
      return {counter: prevState.counter + prevProps.increment}
    },
      () => console.log(this.state.counter));
  }

  render() {
    return (
      <div className="App">
        <header className="App-header">
          <img src={logo} className="App-logo" alt="logo" />
          <p>
            {this.state.counter}
          </p>
          <button 
            onClick = {this.handleClick}
          > 
            Update State
          </button>
        </header>
      </div>
    )
  }
}

export default App;

import React, { Component } from 'react';
import './App.css';
import Person from '../Person/Person';

//This is a class based component
class App extends Component {
  state = {
    persons: [
      {id: "343", name: 'Max', age: 28},
      {id: "342", name: 'Mark', age: 22},
      {id: "341", name: 'Phil', age: 27}
    ],
    showPersons : false
  }

 deletePersonHandler = (personIndex) => {
   //const persons = this.state.persons.slice(); //Slice copies the array and saves it to the const person.
   const persons = [...this.state.persons]; //ES6 way of doing the above slice but uses SPREAD opperator into a new array. ALWAYS CREATE A COPY BEFORE UPDATING THE STATE
   persons.splice(personIndex, 1);
   this.setState({persons: persons});
 }

  nameChangeHandler = (event, id) => {
    const personIndex = this.state.persons.findIndex(p => {
      return p.id === id;
    }); //Find the person

    const person = {
      ...this.state.persons[personIndex]
    }; //Store the person
    
    person.name = event.target.value; //Upates the name
    
    const persons = [...this.state.persons];
    persons[personIndex] = person;
    
    this.setState({persons: persons}); //updates the origonal array

   this.setState(  {
      persons:[    //Updates the dom
        {name: event.target.value, age: 3},
        {name: 'Mark', age: 0},
        {name: 'Phil', age: 0}
      ]
    } )
  }

  togglePersonsHandler = () => {
    const doesShow = this.state.showPersons;
    this.setState({showPersons: !doesShow});
  }

  render() {
    const style = {
      backgroundColor: 'white',
      font: 'inherit',
      border: '1x solid blue',
      padding: '8px',
      cursor: 'pointer'
    };

    let persons = null;

    if ( this.state.showPersons ) { // Output lists dynamically
      persons = (
        <div>
          {this.state.persons.map((person , index )=> { // map converts the array in JS to JSX by mapping every element in the data array persons
              return <Person
                click={() => this.deletePersonHandler(index)}
                name={person.name}
                age={person.age}
                key={person.id} //Important for the DOM to keep track of changes and acts like the primary key
                changed={(event) => this.nameChangeHandler(event, person.id)}/>
                
          })}          
        </div>
      );
    }
    
    //Javascript Area///////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////
    return (
      <div className="App">
        <h1>This is a test!</h1>
        <button 
          style={style}
          onClick={this.togglePersonsHandler}>Toggle Persons</button>         
          {persons}
      </div>
      
    );
    //return React.createElement('div',{className: 'App'}, React.createElement('h1', null, "Does this work?"));
  }
}

export default App;

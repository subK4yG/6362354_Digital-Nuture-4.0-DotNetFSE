import React, { Component } from 'react';

class EventExamples extends Component {
  constructor(props) {
    super(props);
    this.state = {
      count: 0,
      message: '',
    };
    this.incrementAndGreet = this.incrementAndGreet.bind(this);
    this.sayWelcome = this.sayWelcome.bind(this);
    this.handleClick = this.handleClick.bind(this);
  }

  incrementAndGreet() {
    this.setState({ count: this.state.count + 1 });
    this.sayHello();
  }

  sayHello() {
    alert('Hello!"React is fun!"');
  }

  sayWelcome(msg) {
    alert(msg);
  }

  handleClick(e) {
    e.preventDefault();
    alert('I was clicked!');
  }

  render() {
    return (
      <div>
        <h2>Event Handling Example</h2>
        <p>Counter: {this.state.count}</p>

        <button onClick={this.incrementAndGreet}>Increment</button>
        <button onClick={() => this.setState({ count: this.state.count - 1 })}>Decrement</button>

        <br /><br />
        <button onClick={() => this.sayWelcome('Welcome to Event Handling in React!')}>Say Welcome</button>

        <br /><br />
        <button onClick={this.handleClick}>OnPress</button>
      </div>
    );
  }
}

export default EventExamples;

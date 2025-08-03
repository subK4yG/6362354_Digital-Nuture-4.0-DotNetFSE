import React, { Component } from 'react';

class CurrencyConverter extends Component {
  constructor(props) {
    super(props);
    this.state = {
      rupees: '',
      euro: '',
      rate: 0.0100
    };
  }

  handleChange = (event) => {
    this.setState({ rupees: event.target.value });
  };

  handleSubmit = (event) => {
    event.preventDefault();
    alert("Converting INR to Euro..."); 

    const rupees = parseFloat(this.state.rupees);
    if (!isNaN(rupees)) {
      const euro = rupees * this.state.rate;
      this.setState({ euro: euro.toFixed(2) });
    } else {
      alert("Please enter a valid number");
    }
  };

  render() {
    return (
      <div style={{ marginTop: '30px' }}>
        <h2>Currency Converter</h2>
        <form onSubmit={this.handleSubmit}>
          <input
            type="text"
            placeholder="Enter amount in INR"
            value={this.state.rupees}
            onChange={this.handleChange}
          />
          <button type="submit">Convert</button>
        </form>
        <p>Converted Amount in Euro: € {this.state.euro}</p>
      </div>
    );
  }
}

export default CurrencyConverter;

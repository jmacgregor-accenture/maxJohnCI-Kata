import React, { Component } from 'react';

export default class App extends Component{
    constructor(props){
        super(props);
        this.state = { result: 'Nothing has been called...' };
    }

    getInfo() {
        fetch('http://localhost:8001/api/values')
            .then(response => response.json())
            .then(data => {
                this.setState({result: data})})
            .catch(error => {
                console.log(error.toString());
                this.setState({ result: error.toString()})
            })
    }

    render(){
        
        return (

            <div>
                <button onClick={this.getInfo.bind(this)}>Press the Button!</button>

                <p>{this.state.result}</p>
            </div>
        )
    }
}
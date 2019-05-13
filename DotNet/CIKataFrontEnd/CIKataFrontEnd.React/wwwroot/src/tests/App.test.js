import React from 'react';
import { shallow } from 'enzyme';
import App from '../Components/App';
import "isomorphic-fetch";

describe('App', () => {
    it('should contain a button', () => {
        const component = shallow(<App />);

        expect(component.find('button').length).toBe(1);
    })
});





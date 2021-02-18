import * as React from 'react';
import { Route } from 'react-router';
import Layout from './components/Layout';
import Home from './components/Home';
import AboutMe from './components/AboutMe';
import Resume from './components/Resume';
import Contact from './components/Contact';
import Login from './auth/Login';

import './custom.css'

export default () => (
    <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/aboutme' component={AboutMe} />
        <Route path='/resume' component={Resume} />
        <Route path='/contact' component={Contact} />
    </Layout>
);

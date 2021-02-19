import React, { useState } from 'react';
import * as axios from 'axios';
import { AuthForm } from './auth.components';

//const axiosInstance = axios.create({
//    baseUrl: 'https://localhost:5001/login',
//})

const LoginPage = () => {

    const [{username, password}, setCredentials] = useState({
        username: '',
        password: ''
    });

    return(
    <AuthForm>
        <label htmlFor="username">Username</label>
        <input placeholder="username" value={username} onChange={(event) => setCredentials({
           username: event.target.value,
           password 
        })} />
        <label htmlFor="password">Password</label>
        <input placeholder="Password" type="password" value={password} onChange={(event) => setCredentials({
           username,
           password: event.target.value
        })} />
        <button type="submit">Login</button>
    </AuthForm>
    )}

export default LoginPage;
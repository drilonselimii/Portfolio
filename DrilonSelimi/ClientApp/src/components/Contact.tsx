import * as React from 'react';
import { connect } from 'react-redux';
import './Contact.css';
import phone from '../assets/phone.png';
import email from '../assets/email.png';
import lin from '../assets/linkedin.png';
import ig from '../assets/instagram.png';
import fb from '../assets/facebook.png';

const Contact = () => (
  <div className="contact">
    <h2>Contact</h2>
    <div className="contact_email_phone">
      <ul>
        <li>
          <img src={email} height="45" width="42"/>
          <p>drilon.selimii@hotmail.com</p>
        </li>
        <li>
          <img src={phone} height="45" width="45"/>
          <p>+383 45 42 16 42</p>
        </li>
      </ul>      
    </div>
    <div className="contact_lin_fb_ig">
      <p>
      <a href="https://www.linkedin.com/public-profile/in/drilon-selimi-7113141a2" target="_blank">
        <img src={lin} height="80" width="80"/></a>
        <a href="https://www.instagram.com/drilon.selimii/" target="_blank">
        <img src={ig} height="80" width="80"/></a>
      <a href="https://www.facebook.com/DrilonSelimii" target="_blank">
        <img src={fb} height="80" width="80"/></a>
        </p>
    </div>
    
  </div>
);

export default connect()(Contact);
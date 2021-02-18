import * as React from 'react';
import { connect } from 'react-redux';
import cv from '../assets/cv.jpg';
import './Resume.css'

const Resume = () => (
  <div className="resume">
    <img className="resume_image" src={cv} alt="Resume" />

  </div>
); 

export default connect()(Resume);

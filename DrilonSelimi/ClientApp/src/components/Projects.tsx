import * as React from 'react';
import { connect } from 'react-redux';
import './Projects.css';



const Projects = () => (
    <div className="projects">
      <ul>
        <li>
        <p>Fasonet - mini social network</p>
        <a href="https://github.com/drilonselimii/fasonet" target="_blank">https://github.com/drilonselimii/fasonet</a>
        </li>
        <li>
        <p>Weather App</p>
        <a href="https://github.com/drilonselimii/weather-app" target="_blank">https://github.com/drilonselimii/weather-app</a>
        </li>
        <li>
        <p>Portfolio</p>
        <a href="https://github.com/drilonselimii/Portfolio" target="_blank">https://github.com/drilonselimii/Portfolio</a>
        </li>
      </ul>
      
    </div>
  );
  
  export default connect()(Projects);
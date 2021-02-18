import * as React from 'react';
import { connect } from 'react-redux';
import prog from '../assets/prog.jpg';
import './Home.css'

const Home = () => (
  <div className="home">
    <div className="home_text">
      <h4 style={{color: "#008000"}}>Hi there,</h4>
      <h3>I am a Software Developer</h3><br/>
      <p className="home_paragraph">I am an aspirant Software Developer.<br/>
        As it is known,&nbsp; the technology is finding use almost eveywhere.&nbsp; My goal is to lead a team
         of Software Developers,&nbsp; who will come up with softwares that
         will make people's life easier. </p>
    </div>
    <img className="home_image" src={prog} alt="The Laptop" />
  </div>
);

export default connect()(Home);

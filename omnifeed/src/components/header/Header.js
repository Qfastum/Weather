import React from "react";
import styles from "./Header.module.css";
import { NavLink } from "react-router-dom";

function Header() {
  return (
    <header className={styles.header}>
      <NavLink to="/">
        <img
          className={styles.logo}
          src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQbkG1OycocW2d2N6KLPKOagBB4ZPtqRcSASw&s"
          alt="Weather App Logo"
        />
      </NavLink>


      <div className={styles.servicesContainer}>
        <div className={styles.service}>
          <NavLink to="/openWeather" className={({ isActive }) => isActive ? styles.activeLink : ""}>OpenWeather</NavLink>
        </div>
        <div className={styles.service}>
          <NavLink to="/gismeteo" className={({ isActive }) => isActive ? styles.activeLink : ""} >Gismeteo</NavLink>
        </div>
      </div>
    </header>
  )
}

export default Header;
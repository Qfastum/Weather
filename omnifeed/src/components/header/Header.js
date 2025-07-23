import React from "react";
import styles from "./Header.module.css";

function Header() {
    return(
    <header className={styles.header}>
      <img
        className={styles.logo}
        src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQbkG1OycocW2d2N6KLPKOagBB4ZPtqRcSASw&s"
        alt="Weather App Logo"
      />
      
      <div className={styles.servicesContainer}>
        <div className={styles.service}>OpenWeather</div>
        <div className={styles.service}>Gismeteo</div>
      </div>
    </header>
    )    
}

export default Header;
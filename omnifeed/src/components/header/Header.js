import React from "react";
import styles from "./Header.module.css";

function Header() {
  return (
    <header className={styles.header}>
      <a href="/home">
        <img
          className={styles.logo}
          src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQbkG1OycocW2d2N6KLPKOagBB4ZPtqRcSASw&s"
          alt="Weather App Logo"
        />
      </a>


      <div className={styles.servicesContainer}>
        <div className={styles.service}>
          <a href="/openWeather">OpenWeather</a>
        </div>
        <div className={styles.service}>
          <a href="/gismeteo">Gismeteo</a>
        </div>
      </div>
    </header>
  )
}

export default Header;
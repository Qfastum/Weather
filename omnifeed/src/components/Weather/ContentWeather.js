import React from "react";
import styles from "./Content.module.css";

function ContentWeather() {
    return(
        <div className={styles.content}>
            <div className={styles.weatherContainer}>
                <div className={styles.searchSection}>
                    <input 
                        type="text" 
                        placeholder="Введите город..." 
                        className={styles.searchInput}
                    />
                    <button className={styles.searchButton}>
                        Поиск
                    </button>
                </div>
                <div className={styles.weatherData}>
                    {/* Здесь будут данные о погоде */}
                    <div className={styles.weatherCard}>
                        Погодные данные будут здесь
                    </div>
                </div>
            </div>
        </div>
    )
}

export default ContentWeather
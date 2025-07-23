import React from "react";
import styles from "./weatherData.module.css";

function WeatherData(props) {
    return (
        <div className={styles.weatherData}>
            {/* Здесь будут данные о погоде */}
            <div className={styles.weatherCard}>
                Погодные данные будут здесь из {props.site}
            </div>
        </div>
    )
}

export default WeatherData;
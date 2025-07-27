import React from "react";
import styles from "./weatherData.module.css";

function WeatherData(props) {
    return (
        <div className={styles.weatherContainer}>
            <div className={styles.weatherCard}>
                <h2>Погода в городе {props.City}</h2>
                <div className={styles.weatherMain}>
                    <div className={styles.weatherIcon}>
                        {props.weatherData.icon && <img
                            src={`https://openweathermap.org/img/wn/${props.weatherData.icon}@2x.png`}
                            alt={props.weatherData.weatherConditions}
                        />
                        }
                        <span>{props.weatherData.weatherConditions}</span>
                    </div>
                    <div className={styles.temperature}>
                        <span className={styles.currentTemp}>
                            {props.weatherData.temp}°C
                        </span>
                        <div className={styles.tempRange}>
                            <span>Макс: {props.weatherData.tempMax}°C</span>
                            <span>Мин: {props.weatherData.tempMin}°C</span>
                        </div>
                    </div>
                </div>

                <div className={styles.weatherDetails}>
                    <div className={styles.detailItem}>
                        <span> Описание:</span>
                        <span>{props.description}</span>
                    </div>
                    <div className={styles.detailItem}>
                        <span>Скорость ветра:</span>
                        <span>{props.windSpeed}</span>
                    </div>
                </div>
            </div>
        </div>
    )
}

export default WeatherData;
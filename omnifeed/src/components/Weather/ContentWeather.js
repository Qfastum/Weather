import React from "react";
import styles from "./Content.module.css";
import SearchSection from "./searchSection/searchSection";
import WeatherData from "./weatherData/weatherData";

function ContentWeather({ weatherServiceConfig }) {

    if (!weatherServiceConfig) {
        return (
            <div className={styles.weatherContainer}>
            </div>
        )
    }
    else
        return (
            <div className={styles.weatherContainer}>
                <SearchSection site={weatherServiceConfig.name} />
                <WeatherData site={weatherServiceConfig.name} />
            </div>
        )
}

export default ContentWeather;
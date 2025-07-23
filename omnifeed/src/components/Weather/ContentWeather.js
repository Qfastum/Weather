import React from "react";
import styles from "./Content.module.css";
import SearchSection from "./searchSection/searchSection";
import WeatherData from "./weatherData/weatherData";

function ContentWeather({ site }) {

    if (!site) {
        return (
            <div className={styles.weatherContainer}>
            </div>
        )
    }
    else
        return (
            <div className={styles.weatherContainer}>
                <SearchSection site={site} />
                <WeatherData site={site} />
            </div>
        )
}

export default ContentWeather;
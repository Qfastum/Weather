import React from "react";
import styles from "./Content.module.css";
import SearchSectionContainer from "./searchSection/searchSectionContainer";
import WeatherDataContainer from "./weatherData/weatherDataContainer";

function ContentWeather({ weatherServiceConfig }) {

    if (weatherServiceConfig.name === 'Default') {
        return (
            <div className={styles.weatherContainer}>
            </div>
        )
    }
    else
        return (
            <div className={styles.weatherContainer}>
                <SearchSectionContainer/>
                <WeatherDataContainer/>
            </div>
        )
}

export default ContentWeather;
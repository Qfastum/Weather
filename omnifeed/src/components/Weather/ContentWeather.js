import React from "react";
import styles from "./Content.module.css";
import SearchSectionContainer from "./searchSection/searchSectionContainer";
import WeatherData from "./weatherData/weatherData";

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
                {/* <SearchSection site={weatherServiceConfig.name} /> */}
                <WeatherData site={weatherServiceConfig.name} />
            </div>
        )
}

export default ContentWeather;
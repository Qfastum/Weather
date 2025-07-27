import React from "react";
import styles from "./searchSection.module.css";

function SearchSection(props) {

let updateWeather = () => {
    props.updateWeather();
}

let onCityChange = (e) => {
    let text = e.target.value;
    props.updateCiteText(text);
}



    return (
        <div className={styles.searchSection}>
            <input
                type="text"
                placeholder="Введите город..."
                value={props.newWeatherCity}
                onChange={onCityChange}
                className={styles.searchInput}
            />
            <button className={styles.searchButton}
                onClick={updateWeather}
            >
                Поиск в {props.site}
            </button>
        </div>
    )
}

export default SearchSection;
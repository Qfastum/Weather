import styles from "./searchSection.module.css";

function SearchSection(props) {
    
    let updateWeather = () => {
        props.updateWeather(props.City);
    }

    let onCityChange = (e) => {
        let text = e.target.value;
        props.updateCityText(text);
    }

    return (
        <div className={styles.searchSection}>
            <input
                type="text"
                placeholder="Введите город..."
                value={props.City}
                onChange={onCityChange}
                className={styles.searchInput}
            />
            <button className={styles.searchButton}
                onClick={updateWeather}
            >
                Погода из {props.site}
            </button>
        </div>
    )
}

export default SearchSection;
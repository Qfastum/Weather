import React from "react";
import styles from "./searchSection.module.css";

function SearchSection(props) {
    return (
        <div className={styles.searchSection}>
            <input
                type="text"
                placeholder="Введите город..."
                className={styles.searchInput}
            />
            <button className={styles.searchButton}>
                Поиск в {props.site}
            </button>
        </div>
    )
}

export default SearchSection;
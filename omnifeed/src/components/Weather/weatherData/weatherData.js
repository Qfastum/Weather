import styles from "./weatherData.module.css";
import Preloader from "../../common/Preloader/Preloader"

function WeatherData(props) {
    return (
        <div className={styles.weatherContainer}>
            {props.isFetching ? <Preloader/> : null}
            <div className={styles.weatherCard}>
                <h2>Погода в городе {props.City}</h2>
                <div className={styles.weatherMain}>
                    <div className={styles.weatherIconContainer}>
                        {props.weatherData.icon &&
                            (<div className={styles.weatherIconWrapper}>
                                <img
                                    className={styles.weatherIconImage}
                                    src={`https://openweathermap.org/img/wn/${props.weatherData.icon}@2x.png`}
                                    alt=''
                                />
                                <span className={styles.weatherIconCaption}>
                                    {props.weatherData.weatherConditions}
                                </span>
                            </div>
                            )}

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
                        <span> {props.weatherData.description}</span>
                    </div>
                    <div className={styles.detailItem}>
                        <span>Скорость ветра:</span>
                        <span> {props.weatherData.windSpeed}</span>
                    </div>
                </div>
            </div>
        </div>
    )
}

export default WeatherData;
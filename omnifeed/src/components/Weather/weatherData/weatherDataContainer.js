import { connect } from "react-redux";
import WeatherData from "./weatherData";

const mapStateToProps = (state) => ({
    weatherData: state.weather.weatherData,
    City: state.weather.foundCity,
})

const WeatherDataContainer = connect(mapStateToProps) (WeatherData);
export default WeatherDataContainer;
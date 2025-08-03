import SearchSection from "./searchSection";
import { connect } from "react-redux";
import { fetchWeatherData, updateNewWeatherCityText} from "../../../redux/weather/weatherSlice";

const mapStateToProps = (state) => ({
    City: state.weather.newWeatherCity,
});


const SearchSectionContainer = connect(mapStateToProps, {
        updateWeather: fetchWeatherData,
        updateCityText: updateNewWeatherCityText,
    })(SearchSection);

export default SearchSectionContainer;
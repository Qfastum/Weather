import SearchSection from "./searchSection";
import { connect } from "react-redux";
import { updateNewWeatherCityText, updateWeather } from "../../../redux/weather/weatherSlice";

const mapStateToProps = (state) => ({
    City: state.weather.newWeatherCity,
})

const mapDispatchToProps = (dispatch) => ({
    updateCityText: (text) => {
        dispatch(updateNewWeatherCityText(text));
    },

    updateWeather: () => {
        dispatch(updateWeather());
    }

});


const SearchSectionContainer = connect(mapStateToProps, mapDispatchToProps)(SearchSection)

export default SearchSectionContainer;
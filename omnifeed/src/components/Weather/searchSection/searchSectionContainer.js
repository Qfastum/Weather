import SearchSection from "./searchSection";
import { connect } from "react-redux";
import { updateNewWeatherCityText, updateWeather } from "../../../redux/weather/weatherSlice";

const mapStateToProps = (state) => ({
    newWeatherCity: state.weather.newWeatherCity,
})

const mapDispatchToProps = (dispatch) => ({
    updateCiteText: (text) => {
        dispatch(updateNewWeatherCityText(text));
    },

    updateWeather: () => {
        dispatch(updateWeather());
    }

});


const SearchSectionContainer = connect(mapStateToProps, mapDispatchToProps)(SearchSection)

export default SearchSectionContainer;
import { createSlice } from "@reduxjs/toolkit";

export const weatherSlice = createSlice({
    name: 'weather',
    initialState: {
        weatherData: {
            description: "1",
            icon: "1",
            weatherConditions: "1",
            temp: 0,
            tempMax: 0,
            tempMin: 0,
            windSpeed: 0,
        },
        newWeatherCity: "1",
        foundCity: "1",
    },

    reducers: {
        updateWeather: (state) => {
            state.foundCity = state.newWeatherCity;
            state.newWeatherCity = "";
        },

        updateNewWeatherCityText: (state, action) => {
            state.newWeatherCity = action.payload;
        }

    },

})

export const { updateWeather,updateNewWeatherCityText } = weatherSlice.actions   

export default weatherSlice.reducer
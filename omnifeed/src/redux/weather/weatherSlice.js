import { createSlice } from "@reduxjs/toolkit";

export const weatherSlice = createSlice({
    name: 'weather',
    initialState: {
        weatherData: {
            description: "",
            icon: "",
            weatherConditions: "",
            temp: 0,
            tempMax: 0,
            tempMin: 0,
            windSpeed: 0,
        },
        newWeatherCity: "1",
    },

    reducers: {
        updateWeather: (state, action) => {
            
            state.newWeatherCity = "";
        },

        updateNewWeatherCityText: (state, action) => {
            state.newWeatherCity = action.text;
        }

    },

})

export const { updateWeather,updateNewWeatherCityText } = weatherSlice.actions   

export default weatherSlice.reducer
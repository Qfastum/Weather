import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import { WeatherApi } from "../../api/weathere";


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
        newWeatherCity: "Минск",
        foundCity: "",
        status: "idle",
        error: null,
    },

    reducers: {
        updateNewWeatherCityText: (state, action) => {
            state.newWeatherCity = action.payload;
        }

    },

    extraReducers: (builder) => {
        builder
            .addCase(fetchWeatherData.pending, (state) => {
                state.status = 'loading';
                state.status = null;
            })
            .addCase(fetchWeatherData.fulfilled, (state, action) => {
                state.status = 'succeeded';
                state.foundCity = state.newWeatherCity;
                state.newWeatherCity = "";
                state.weatherData = {
                    description: action.payload.weather.description,
                    icon: action.payload.weather.icon,
                    weatherConditions: action.payload.weather.weatherConditions,
                    temp: action.payload.weather.temp,
                    tempMax: action.payload.weather.tempMax,
                    tempMin: action.payload.weather.tempMin,
                    windSpeed: action.payload.weather.windSpeed,
                }
            })
            .addCase(fetchWeatherData.rejected, (state, action) => {
                state.status = 'failed';
                state.error = action.payload;
            });
    },


})

export const fetchWeatherData = createAsyncThunk(
    'weather/fetchWeatherData',
    async (city, { rejectWithValue }) => {
        try {
            const weatherData = await WeatherApi.getOpenWeather(city);
            console.log('Данные о погоде:', weatherData);

            let temp = weatherData.temp - 273.15
            let tempMax = weatherData.tempMax - 273.15
            let tempMin = weatherData.tempMin - 273.15

            return {
                weather: {
                    description: weatherData.description,
                    icon: weatherData.icon,
                    weatherConditions: weatherData.weatherConditions,
                    temp: temp.toFixed(2),
                    tempMax: tempMax.toFixed(2),
                    tempMin: tempMin.toFixed(2),
                    windSpeed: weatherData.windSpeed,
                },
            }
        }
        catch (error) {
            console.error('Ошибка:', error.message);
            return rejectWithValue({
                message: error.response?.data?.message || error.message,
                status: error.response?.status
            });
        }
    }
)

export const { updateNewWeatherCityText } = weatherSlice.actions

export default weatherSlice.reducer
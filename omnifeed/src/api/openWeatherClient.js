import axios from 'axios';

const openWeatherClient = axios.create({
    baseURL: 'https://localhost:7128',
    headers: {
        'Accept': '*/*',
    },
})

export default openWeatherClient;
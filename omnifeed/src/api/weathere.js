import axios from 'axios';

const apiClient = axios.create({
    baseURL: 'https://localhost:7128',
    headers: {
        'Accept': '*/*',
    },
})


export const WeatherApi = {
    getOpenWeather: async (city) => {
        try {
            const response = await apiClient.get('/Weather/get-open-weather', {
                params: {
                    city: encodeURIComponent(city)
                }
            });
            return response.data;
        }
        catch (error) {
            if (error.response) {
                // Сервер ответил с ошибкой
                console.error('Ошибка сервера:', error.response.status, error.response.data);
                throw new Error(`Ошибка сервера: ${error.response.status}`);
            } else if (error.request) {
                // Запрос был сделан, но ответ не получен
                console.error('Нет ответа от сервера');
                throw new Error('Сервер не отвечает');
            } else {
                // Ошибка настройки запроса
                console.error('Ошибка запроса:', error.message);
                throw error;
            }
        }
    },
}
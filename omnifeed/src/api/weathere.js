import openWeatherClient from "./openWeatherClient"

export const WeatherApi = {
    getOpenWeather: async (city) => {
        try {
            const response = await openWeatherClient.get('/Weather/get-open-weather', {
                params: {
                    city: encodeURIComponent(city)
                }
            });
            return response.data;
        }
        catch (error) {
            if (error.response) {
                // Сервер ответил с ошибкой
                console.error("Server error:", error.response.status, error.response.data);
                throw new Error(`Server error: ${error.response.status}`);
            } else if (error.request) {
                // Запрос был сделан, но ответ не получен
                console.error("No response from server");
                throw new Error("Server is not responding");
            } else {
                // Ошибка настройки запроса
                console.error("Request Error:", error.message);
                throw error;
            }
        }
    },
}
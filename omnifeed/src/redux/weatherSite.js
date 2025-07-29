export const WEATHER_SERVICES = {
    default: {
        name: "Default",
        path: "/",
    },
    openWeather:{
        name: "openWeather",
        path: "/openWeather",
    },
    gismeteo:{
        name: "gismeteo",
        path: "/gismeteo",
    }
}

export const serviceList = Object.values(WEATHER_SERVICES)
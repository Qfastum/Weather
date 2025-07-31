import axios from 'axios';

const gismeteoClient = axios.create({
    baseURL: 'https://localhost:7128',
    headers: {
        'Accept': '*/*',
    },
})

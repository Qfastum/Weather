import './App.css';
import ContentWeather from './components/Weather/ContentWeather';
import Header from './components/header/Header';
import { BrowserRouter, Route, Routes } from "react-router-dom";
import { serviceList } from './redux/weatherSite';

function App() {
  return (
    <BrowserRouter>
      <div className="app-wrapper">
        <Header />
        <Routes>
          {
            serviceList.map((service)=>(
              <Route path={service.path} element={ <ContentWeather weatherServiceConfig = {service}/>} />
            ))
          }
        </Routes>

      </div>
    </BrowserRouter>
  );
}

export default App;

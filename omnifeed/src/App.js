import './App.css';
import ContentWeather from './components/Weather/ContentWeather';
import Header from './components/header/Header';
import { BrowserRouter, Route, Routes } from "react-router-dom";

function App() {
  return (
    <BrowserRouter>
      <div className="app-wrapper">
        <Header />
        <Routes>
           <Route path='/' element={ <ContentWeather />}/>
          <Route path='/openWeather' element={ <ContentWeather site="OpenWeather" />}/>
          <Route path='/gismeteo' element={<ContentWeather site="Gismeteo" />}/>
        </Routes>

      </div>
    </BrowserRouter>
  );
}

export default App;

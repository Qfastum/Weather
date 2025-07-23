import './App.css';
import ContentWeather from './components/Weather/ContentWeather';
import Header from './components/header/Header';

function App() {
  return (
    <div className="app-wrapper">
      <Header />
      <ContentWeather /> 
      
    </div>
  );
}

export default App;

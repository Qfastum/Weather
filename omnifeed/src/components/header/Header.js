import React from "react";
import style from "./Header.module.css";

function Header() {
    return(
        <header className={style.header}>
        <img className={style.img} src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQbkG1OycocW2d2N6KLPKOagBB4ZPtqRcSASw&s" alt="logo" />
        <div>
          <div>
            OpenWeather
          </div>
          <div>
            Gismeteo
          </div>
        </div>
      </header>
    )    
}

export default Header;
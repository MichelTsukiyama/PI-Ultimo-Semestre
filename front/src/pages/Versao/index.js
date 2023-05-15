import React from "react";
import { useNavigate } from "react-router-dom";
import { useLocation } from 'react-router-dom';

import "./styles.css";

export default function Versao() {
  const navigate = useNavigate();
  const location = useLocation();

  function versao() {
    console.log(location.pathname);

    location.pathname === "/search" ? navigate("/") : navigate("/search");
  }

  return (
    <div>
      <header>
        <p onClick={versao}> {location.pathname === "/search" ? "Versão com IA" : "Versão anterior" }</p>
      </header>
    </div>
  );
}
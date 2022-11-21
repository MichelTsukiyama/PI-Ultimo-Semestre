import React from "react";
import { useNavigate } from "react-router-dom";

import "./styles.css";

export default function Result() {
  const navigate = useNavigate();

  const linguagem = localStorage.getItem("linguagem");
  const imagem = localStorage.getItem("imagem");
  const documentacao = localStorage.getItem("documentacao");
  const videoAulas = localStorage.getItem("videoAulas");
  const roadMap = localStorage.getItem("roadMap");

  function back() {
    localStorage.clear();

    navigate("/");
  }

  return (
    <div>
      <header>
        <p onClick={back}> &lt; voltar</p>
      </header>

      <section className="result-container">
        <img src={imagem} alt={"logo " + linguagem} />

        <a href={documentacao} target="_blank">
          <button className="button">Documentação</button>
        </a>

        <a href={videoAulas} target="_blank">
          <button className="button">Video Aulas</button>
        </a>

        <a href={roadMap} target="_blank">
          <button className="button">Roadmap</button>
        </a>
      </section>
    </div>
  );
}

import React, { useState } from "react";
import api from "../../services/api";
import { Prism as SyntaxHighlighter } from "react-syntax-highlighter";
import { tomorrow } from "react-syntax-highlighter/dist/esm/styles/prism";
import Versao from "../../pages/Versao";

import "./styles.css";
import iconSearch from "../../assets/icon-search.png";
import { tomorrowNight, tomorrowNightBlue } from "react-syntax-highlighter/dist/esm/styles/hljs";

export default function Completion() {
  const [texto, setTexto] = useState("");
  const [chat, setChat] = useState([]);

  const handleButtonClick = (data, response) => {
    const newQuestion = "Pergunta: \n" + data.texto;
    const newAnswer = "Resposta: \n" + response.data.content;

    setChat([...chat, { question: newQuestion, answer: newAnswer }]);

    resetInput();
  };

  const resetInput = () => {
    setTexto("");
  };

  async function completion(e) {
    e.preventDefault();

    const data = {
      texto,
    };

    try {
      const response = await api.get(`Completion`, {
        params: { content: texto },
      });

      if (response.data.content === undefined) {
        alert(
          "Oops, algo deu errado. Por favor tente novamente em alguns segundos..."
        );
      }

      handleButtonClick(data, response);
    } catch (error) {
      alert(
        "Oops, algo deu errado. Por favor tente novamente em alguns segundos..."
      );
    }
  }

  return (
    <div>
      <Versao></Versao>
      <div className="container">
        <section className="form">
          <div>
            <ul>
              {chat.map((item, index) => (
                <li key={index}>
                  <SyntaxHighlighter
                    className="Highlighter"
                    language="java"
                    style={tomorrowNight}
                    wrapLines={true}
                    wrapLongLines={40}
                  >
                    {item.question}
                  </SyntaxHighlighter>
                  <SyntaxHighlighter
                    className="Highlighter"
                    language="java"
                    style={tomorrow}
                    wrapLines={true}
                    wrapLongLines={40}
                  >
                    {item.answer}
                  </SyntaxHighlighter>
                </li>
              ))}
            </ul>
          </div>

          <form onSubmit={completion}>
            <input
              type="text"
              placeholder="digite sua dúvida para obter uma resposta"
              value={texto}
              onChange={(e) => setTexto(e.target.value)}
            />
            <span>
              <button className="button" type="submit">
                <img src={iconSearch} alt="Símbolo de uma lupa" />
              </button>
            </span>
          </form>
        </section>
      </div>
    </div>
  );
}

# Projeto Integrador

Desenvolver uma aplicação orientada a dispositivos móveis e web que auxilie os usuários a buscar conteúdo de valor sobre diversas linguagens de programação.

- [**Vídeo do projeto**](https://youtu.be/qs8_zdKtHQA?t=189)
- [**Como rodar o projeto + vídeo do projeto**](https://youtu.be/qs8_zdKtHQA?t)

----
<br>

## Grupo 22

**Integrantes**

- Erick Von Rondow Neves
- Leonardo Pereira Grosser
- Lucas dos Santos Camilo
- Mayan Barros da Silva
- Michel Tsukiyama de Souza
- William Viana Dantas da Nobrega

----
<br>

## Como utilizar este aplicativo?

<br>

**Requisitos**

Ter previamente instalado os itens abaixo:

- Seu editor de código/IDE preferido (VS Code, Eclipse, Intellij...)
- SDK .Net 6;
- SDK Node.js v16.17.1
- MySql v8.0
- Git latest

<br>

**Clonando o Projeto**

Utilize o comando abaixo no GitBash / prompt de comando, no diretório em que deseja clonar este projeto.

    git clone https://github.com/MichelTsukiyama/PI-Grupo22.git

<br>

**Iniciando o Back-end**

Acessar o diretório do Back-end:

        PI-Senac/back

Utilizar o comando abaixo para restaurar as depêndencias do projeto:

        dotnet restore

Acessar o arquivo 'appsettings.json' e alterar os valores 'root' em: 
- uid=root 
- pwd=root

**No lugar de root deve ser inserido o usuário e senha do MySQL**

Iniciar o projeto com o comando abaixo:

        dotnet run

<br>

**Iniciando o Front-end**

Acessar o diretório do Front-end:

        PI-Senac/front

Utilizar o comando abaixo para restaurar as depêndencias do projeto:

        npm install

Iniciar o projeto com o comando abaixo:

        npm start

Acessar o link [http://localhost:3000](http://localhost:3000) ou copiar a url abaixo e colar no navegador:

    http://localhost:3000


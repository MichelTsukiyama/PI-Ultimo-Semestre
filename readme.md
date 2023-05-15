# Projeto Integrador

Implementar integração com a rota Completions do ChatGPT da OpenAPI, para que o usuário possa usufruir de recursos de Inteligência Artificial em sua rotina de estudos. Assim nosso usuário pode tirar dúvidas, solicitar recomendação de cursos, documentações, entre outros.

- [**Vídeo do projeto**](https://youtu.be/ei1V-fPp79k?t=412)
- [**Como rodar o projeto + vídeo do projeto**](https://youtu.be/ei1V-fPp79k)

Verifique abaixo como era a versão anterior:

[Readme da versão anterior](https://github.com/MichelTsukiyama/PI-Ultimo-Semestre/blob/develop/readme-v1.md).

----
<br>

## Grupo

**Integrantes**

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
- SDK Node.js v16.17.1 ;
- MySql v8.0 ;
- Git latest ;
- Possuir uma API Key da OpenAI;

<br>


## Obter API Key da OpenAI

<br>

Você pode obter sua API Key para testes seguindo a documentação da propria OpenAPI.

[Faça seu cadastro na OpenAI](https://auth0.openai.com/u/signup/identifier?state=hKFo2SBzRHZiVGpnb0prQzhyS19BT0hGaFQzYjNnT1BCVldlT6Fur3VuaXZlcnNhbC1sb2dpbqN0aWTZIE5Ea1VCaW5GMGhrZHRQT2x0b3M4VURZNm90VW16U2Vmo2NpZNkgRFJpdnNubTJNdTQyVDNLT3BxZHR3QjNOWXZpSFl6d0Q).

[Crie sua API Key](https://platform.openai.com/docs/quickstart/add-your-api-key).

<br>

-----

<br>

**Clonando o Projeto**

Utilize o comando abaixo no GitBash / prompt de comando, no diretório em que deseja clonar este projeto.

    git clone https://github.com/MichelTsukiyama/PI-Ultimo-Semestre.git

<br>

**Iniciando o Back-end**

Acessar o diretório do Back-end:

        ./back

Utilizar o comando abaixo para restaurar as depêndencias do projeto:

        dotnet restore

Acessar o arquivo 'appsettings.json' e alterar os valores 'root' em: 
- uid=root 
- pwd=root

**No lugar de root deve ser inserido o usuário e senha do MySQL**

**Insira sua API Key**

No arquivo 'appsettings.json' coloque sua API Key na linha correspondente, conforme exemplo abaixo:

    "OpenAI_Api_Key" : "SUBSTITUA SUA API KEY AQUI",


Iniciar o projeto com o comando abaixo:

        dotnet run


**Caso receba o erro: *Unhandled exception. System.InvalidOperationException: Unable to configure HTTPS endpoint. No server certificate was specified, and the default developer certificate could not be found or is out of date.* . Execute o comando abaixo:**

        dotnet dev-certs https

<br>

**Iniciando o Front-end**

Acessar o diretório do Front-end:

        ./front

Utilizar o comando abaixo para restaurar as depêndencias do projeto:

        npm install

Iniciar o projeto com o comando abaixo:

        npm start

Acessar o link [http://localhost:3000](http://localhost:3000) ou copiar a url abaixo e colar no navegador:

    http://localhost:3000


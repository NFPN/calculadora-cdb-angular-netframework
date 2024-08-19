# Teste Sinacor - C�lculo de CDB

## Vis�o Geral

Este projeto � uma aplica��o web para calcular o rendimento de Certificados de Dep�sito Banc�rio (CDB), composta por uma API desenvolvida em **ASP.NET Framework 4.8.1** e uma aplica��o web front-end desenvolvida em **Angular**.

### Estrutura do Projeto

- teste-sinacor-gft
	- Projeto.API
	- Projeto.Web

	
## Requisitos

### Backend (API ASP.NET)

- .NET Framework 4.8.1 ou superior
- Visual Studio 2019 ou superior

### Frontend (Angular)

- Node.js v22.6.0 ou superior
- Angular CLI 18.2.0 ou superior

## Configura��o do Ambiente

### Passos para rodar a API (Backend)

1. **Instalar Depend�ncias**:
   - Abra a solu��o `Projeto.sln` no Visual Studio e restaure as depend�ncias (`NuGet`).

2. **Executar a API**:
   - Defina o projeto Projeto.SelfHost como `Startup project`
   - Clique em `Run` ou `F5` no Visual Studio para iniciar a API.

### Passos para rodar o Frontend (Angular)

1. **Instalar Depend�ncias**:
   - Navegue at� a pasta `Projeto.WEB` usando o terminal:
     ```bash
     cd Projeto.WEB
     ```
   - Instale as depend�ncias do projeto usando o npm:
     ```bash
     npm install
     ```

2. **Configurar a Base URL da API**:
   - No arquivo `environment.ts` dentro de `src/app/environments/`, ajuste a `baseUrl` para apontar para o endere�o onde a API est� rodando (ex: `http://localhost:9000/api/CalculaCDB`).

3. **Executar o Servidor de Desenvolvimento**:
   - Inicie a aplica��o Angular com o comando:
     ```bash
     ng serve
     ```
   - O front-end estar� dispon�vel em `http://localhost:4200`.

### Passos para Build (Produ��o)

1. **Build da Aplica��o Angular**:
   - Execute o comando para gerar o build de produ��o:
     ```bash
     ng build --prod
     ```
   - O build ser� gerado na pasta `dist/`.

2. **Deploy**:
   - Os arquivos dentro da pasta `dist/` podem ser servidos via qualquer servidor web como IIS, Nginx ou Apache.

## Testes

### Testes Unit�rios no Backend (ASP.NET)

1. **Executar Testes Unit�rios**:
   - Abra o projeto no Visual Studio.
   - No menu, v� para **Test > Run All Tests** para executar todos os testes unit�rios e verificar a cobertura.

2. **Cobertura de Testes**:
   - A cobertura de c�digo dos testes unit�rios est� acima de 90% para a camada de l�gica de neg�cios (`CdbService`).

### Testes Unit�rios no Frontend (Angular)

1. **Executar Testes Unit�rios**:
   - Navegue at� a pasta `Projeto.WEB` e execute o seguinte comando:
     ```bash
     ng test
     ```
   - Isso iniciar� o **Karma** para executar os testes unit�rios escritos com **Jasmine**.

2. **Relat�rio de Cobertura**:
   - Ap�s a execu��o dos testes, um relat�rio de cobertura ser� gerado na pasta `coverage/`.

## Linting

### Linting no Backend

- Utilize o **SonarLint** para verificar a conformidade com boas pr�ticas de c�digo. O c�digo foi testado e n�o cont�m alertas cr�ticos de an�lise de c�digo.

### Linting no Frontend

- Utilize o comando abaixo para verificar erros de lint no projeto Angular:
  ```bash
  ng lint

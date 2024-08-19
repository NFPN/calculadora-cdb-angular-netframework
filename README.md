# Teste Sinacor - Cálculo de CDB

## Visão Geral

Este projeto é uma aplicação web para calcular o rendimento de Certificados de Depósito Bancário (CDB), composta por uma API desenvolvida em **ASP.NET Framework 4.8.1** e uma aplicação web front-end desenvolvida em **Angular**.

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

## Configuração do Ambiente

### Passos para rodar a API (Backend)

1. **Instalar Dependências**:
   - Abra a solução `Projeto.sln` no Visual Studio e restaure as dependências (`NuGet`).

2. **Executar a API**:
   - Defina o projeto Projeto.SelfHost como `Startup project`
   - Clique em `Run` ou `F5` no Visual Studio para iniciar a API.

### Passos para rodar o Frontend (Angular)

1. **Instalar Dependências**:
   - Navegue até a pasta `Projeto.WEB` usando o terminal:
     ```bash
     cd Projeto.WEB
     ```
   - Instale as dependências do projeto usando o npm:
     ```bash
     npm install
     ```

2. **Configurar a Base URL da API**:
   - No arquivo `environment.ts` dentro de `src/app/environments/`, ajuste a `baseUrl` para apontar para o endereço onde a API está rodando (ex: `http://localhost:9000/api/CalculaCDB`).

3. **Executar o Servidor de Desenvolvimento**:
   - Inicie a aplicação Angular com o comando:
     ```bash
     ng serve
     ```
   - O front-end estará disponível em `http://localhost:4200`.

### Passos para Build (Produção)

1. **Build da Aplicação Angular**:
   - Execute o comando para gerar o build de produção:
     ```bash
     ng build --prod
     ```
   - O build será gerado na pasta `dist/`.

2. **Deploy**:
   - Os arquivos dentro da pasta `dist/` podem ser servidos via qualquer servidor web como IIS, Nginx ou Apache.

## Testes

### Testes Unitários no Backend (ASP.NET)

1. **Executar Testes Unitários**:
   - Abra o projeto no Visual Studio.
   - No menu, vá para **Test > Run All Tests** para executar todos os testes unitários e verificar a cobertura.

2. **Cobertura de Testes**:
   - A cobertura de código dos testes unitários está acima de 90% para a camada de lógica de negócios (`CdbService`).

### Testes Unitários no Frontend (Angular)

1. **Executar Testes Unitários**:
   - Navegue até a pasta `Projeto.WEB` e execute o seguinte comando:
     ```bash
     ng test
     ```
   - Isso iniciará o **Karma** para executar os testes unitários escritos com **Jasmine**.

2. **Relatório de Cobertura**:
   - Após a execução dos testes, um relatório de cobertura será gerado na pasta `coverage/`.

## Linting

### Linting no Backend

- Utilize o **SonarLint** para verificar a conformidade com boas práticas de código. O código foi testado e não contém alertas críticos de análise de código.

### Linting no Frontend

- Utilize o comando abaixo para verificar erros de lint no projeto Angular:
  ```bash
  ng lint

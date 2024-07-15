# TarefasAcademicas.API

## Descrição

TarefasAcademicas.API é uma API desenvolvida em ASP.NET Core para gerenciar tarefas acadêmicas. Esta API fornece endpoints para operações CRUD em tarefas, além de funcionalidades de autenticação e autorização, facilitando a integração com sistemas front-end. Este projeto foi criado durante a docência da disciplina Projeto Integrado Multidisciplinar do curso de Analise e Desenvolvimento de Sistemas.

## Índice

- [Descrição](#descrição)
- [Tecnologias Utilizadas](#tecnologias-utilizadas)
- [Funcionalidades](#funcionalidades)
- [Instalação](#instalação)
- [Uso](#uso)
- [Contribuição](#contribuição)
- [Licença](#licença)
- [Contato](#contato)

## Tecnologias Utilizadas

- ASP.NET Core 6
- Entity Framework Core
- Swagger
- SQL Server
- Git

## Funcionalidades

- **CRUD de Tarefas**: Criação, leitura, atualização e exclusão de tarefas acadêmicas.
- **Atribuição de Tarefas**: Atribuição de tarefas a alunos.
- **Autenticação e Autorização**: Controle de acesso para diferentes tipos de usuários.
- **Documentação com Swagger**: Documentação automática e interativa da API.
- **Injeção de Dependência**: Facilita a manutenção e testabilidade do código.
- **Redirecionamento HTTPS**: Garante que todas as requisições sejam seguras.
- **Tratamento de Exceções**: Feedback detalhado em ambiente de desenvolvimento.

## Instalação

### Pré-requisitos

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/)
- [SQL Server](https://www.microsoft.com/sql-server)

### Passos

1. Clone o repositório:
    ```bash
    git clone https://github.com/seu-usuario/TarefasAcademicas.API.git
    cd TarefasAcademicas.API
    ```

2. Restaure as dependências do projeto:
    ```bash
    dotnet restore
    ```

3. Configure a string de conexão com o SQL Server no arquivo `appsettings.json`:
    ```json
    "ConnectionStrings": {
        "DefaultConnection": "Server=SEU_SERVIDOR;Database=TarefasAcademicasDB;User Id=SEU_USUARIO;Password=SUA_SENHA;"
    }
    ```

4. Atualize o banco de dados:
    ```bash
    dotnet ef database update
    ```

5. Execute a aplicação:
    ```bash
    dotnet run
    ```

## Uso

Após seguir os passos de instalação, a API estará disponível em `https://localhost:5001/swagger`. Navegue até esta URL no seu navegador para acessar a documentação interativa da API.

### Endpoints Principais

- **Tarefas**:
  - `GET /api/tarefas`: Lista todas as tarefas.
  - `POST /api/tarefas`: Cria uma nova tarefa.
  - `GET /api/tarefas/{id}`: Obtém uma tarefa por ID.
  - `PUT /api/tarefas/{id}`: Atualiza uma tarefa por ID.
  - `DELETE /api/tarefas/{id}`: Exclui uma tarefa por ID.

- **Alunos**:
  - `GET /api/alunos`: Lista todos os alunos.
  - `POST /api/alunos`: Cria um novo aluno.
  - `GET /api/alunos/{id}`: Obtém um aluno por ID.
  - `PUT /api/alunos/{id}`: Atualiza um aluno por ID.
  - `DELETE /api/alunos/{id}`: Exclui um aluno por ID.

## Contribuição

Contribuições são bem-vindas! Siga os passos abaixo para contribuir:

1. Fork o repositório
2. Crie um branch para sua feature (`git checkout -b feature/nova-feature`)
3. Commit suas mudanças (`git commit -m 'Adiciona nova feature'`)
4. Faça o push para o branch (`git push origin feature/nova-feature`)
5. Abra um Pull Request

## Licença

Este projeto está licenciado sob a Licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

## Contato

- **Seu Nome** - ordabelem@hotmail.com
- **GitHub** - https://github.com/rodneyvictorsoares/tarefas-academicas-web

---

<p align="center">
  <img src="https://img.shields.io/badge/Made_with-ASP.NET_Core-1f425f.svg" alt="Feito com ASP.NET Core">
  <img src="https://img.shields.io/badge/Deployed_on-GitHub_Pages-1f425f.svg" alt="Deploy no GitHub Pages">
</p>

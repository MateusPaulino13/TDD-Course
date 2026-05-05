# Curso TDD

Este repositório contém o projeto desenvolvido durante o curso de **Test-Driven Development (TDD)**, focando em boas práticas de teste e refatoração de código.

## 📚 Descrição

Criação de testes unitários e integrados utilizando os principais frameworks e ferramentas da plataforma .NET:

- **NUnit**: Framework robusto para testes unitários
- **Moq**: Biblioteca para criação de mocks e stubs
- **AutoFixture**: Gerador automático de dados para testes

Além disso, o projeto aborda:

- ✅ Utilização de scripts para criação e exclusão de bancos de dados para testes integrados
- ✅ Refatoração de código de teste utilizando padrões que auxiliam na manutenção
- ✅ Utilização do **Dapper** para acessar o banco de dados, reduzindo código boilerplate

## 🛠️ Tecnologias Utilizadas

- **.NET / C#**
- **NUnit** - Framework de testes
- **Moq** - Biblioteca de mocking
- **AutoFixture** - Gerador de dados para testes
- **Dapper** - Micro-ORM para acesso a dados
- **SQL Server** - Banco de dados para testes integrados

## 📋 Requisitos

- .NET SDK 6.0 ou superior
- SQL Server (local ou containerizado)
- Visual Studio 2022 ou VS Code

## 🚀 Como Executar os Testes

```bash
# Restaurar dependências
dotnet restore

# Executar todos os testes
dotnet test

# Executar com verbosidade
dotnet test --verbosity normal
```

## 🧪 Padrões e Práticas Utilizadas

- **Arrange-Act-Assert (AAA)**: Estrutura clara dos testes
- **Builder Pattern**: Para construção de dados de teste
- **Object Mother**: Para criação de objetos de teste
- **Fixtures**: Para compartilhamento de setup entre testes

## 📝 Licença

Este projeto é utilizado para fins educacionais.

## 👨‍💻 Autor

[Mateus Paulino](https://github.com/MateusPaulino13)

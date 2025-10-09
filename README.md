# 🎓 Sistema de Gestão Acadêmica

> **Status: Em Desenvolvimento** 🚧  
> *Projeto em construção com planos de expansão para aplicações Desktop, Mobile e Web*

Um sistema completo de gestão acadêmica desenvolvido em C# com arquitetura em camadas (N-Tier), aplicando os principais conceitos de Programação Orientada a Objetos. O projeto simula o cadastro e gerenciamento de alunos, cursos e unidades educacionais.

## 🎯 Visão do Projeto

Este sistema está sendo desenvolvido como uma solução completa para gestão acadêmica, com planos de evolução para múltiplas plataformas:

- **Fase Atual**: Console Application (MVP)
- **Próximas Fases**: 
  - 📱 **Mobile App** (Android/iOS)
  - 🖥️ **Desktop Application** (WPF/MAUI)
  - 🌐 **Web Application** (ASP.NET Core/Blazor)

## 🏗️ Arquitetura

O sistema utiliza uma arquitetura em camadas bem definida, seguindo as melhores práticas de desenvolvimento:

```
📦 TransformeseApp2
├── 🎨 TransformeseApp2.UI          # Camada de Apresentação
├── 💼 TransformeseApp2.BLL         # Camada de Regras de Negócio
├── 🗄️ TransformeseApp2.DAL         # Camada de Acesso a Dados
└── 📋 TransformeseApp2.DTO         # Objetos de Transferência de Dados
```

### Camadas do Sistema

| Camada | Responsabilidade | Tecnologias |
|--------|------------------|-------------|
| **UI** | Interface do usuário | Console App → Desktop/Mobile/Web |
| **BLL** | Regras de negócio e validações | C# .NET 8.0 |
| **DAL** | Persistência de dados | In-Memory → Entity Framework |
| **DTO** | Modelos de dados | C# Classes |

## 🚀 Funcionalidades Atuais

### ✅ Implementado
- [x] Cadastro de Alunos
- [x] Cadastro de Cursos
- [x] Cadastro de Unidades
- [x] Listagem de registros
- [x] Busca por ID
- [x] Validações básicas
- [x] Arquitetura em camadas
- [x] Banco de dados em memória

### 🔄 Em Desenvolvimento
- [ ] Interface de usuário interativa
- [ ] Relacionamento entre entidades
- [ ] Relatórios e estatísticas
- [ ] Sistema de autenticação

### 📋 Roadmap
- [ ] **v2.0**: Desktop Application (WPF/MAUI)
- [ ] **v3.0**: Mobile App (MAUI)
- [ ] **v4.0**: Web Application (Blazor)
- [ ] **v5.0**: API RESTful
- [ ] **v6.0**: Banco de dados real (SQL Server/PostgreSQL)

## 🎨 Conceitos de POO Aplicados

O projeto demonstra diversos conceitos fundamentais da Programação Orientada a Objetos:

- **🏛️ Abstração**: Classe base `PessoaDTO` com métodos abstratos
- **🔒 Encapsulamento**: Propriedades e validações encapsuladas
- **👥 Herança**: `AlunoDTO` herda de `PessoaDTO`
- **🔄 Polimorfismo**: Sobrecarga de métodos na classe `CursoDTO`
- **⚡ Expressões Lambda**: Utilizadas em consultas LINQ
- **🎯 Operadores Ternários**: Para lógicas condicionais concisas

## 🛠️ Tecnologias

- **Framework**: .NET 8.0
- **Linguagem**: C# 12
- **Arquitetura**: N-Tier (Multi-camadas)
- **Padrões**: DTO, Repository Pattern (planejado)
- **Futuras**: Entity Framework, ASP.NET Core, MAUI

## 🚀 Como Executar

### Pré-requisitos
- .NET 8.0 SDK ou superior
- Visual Studio 2022 ou VS Code

### Executando o projeto
```bash
# Clone o repositório
git clone https://github.com/Milonesco/Sistema-de-Gestao-Academica/.git

# Navegue até o diretório
cd Sistema-de-Gestao-Academica

# Restaure as dependências
dotnet restore

# Execute o projeto
dotnet run --project TransformeseApp2.UI
```

## 📁 Estrutura do Projeto

```
TransformeseApp2/
│
├── TransformeseApp2.UI/           # 🎨 Interface de Usuário
│   └── Program.cs                 # Ponto de entrada da aplicação
│
├── TransformeseApp2.BLL/          # 💼 Camada de Negócios
│   ├── AlunoBLL.cs               # Regras de negócio para alunos
│   ├── CursoBLL.cs               # Regras de negócio para cursos
│   └── UnidadeBLL.cs             # Regras de negócio para unidades
│
├── TransformeseApp2.DAL/          # 🗄️ Camada de Dados
│   └── Database.cs               # Simulação de banco de dados
│
└── TransformeseApp2.DTO/          # 📋 Modelos de Dados
    ├── PessoaDTO.cs              # Classe base abstrata
    ├── AlunoDTO.cs               # Modelo de aluno
    ├── CursoDTO.cs               # Modelo de curso
    └── UnidadeDTO.cs             # Modelo de unidade
```

## 🤝 Contribuições

Este projeto está em desenvolvimento ativo! Contribuições são bem-vindas:

1. Fork o projeto
2. Crie uma branch para sua feature (`git checkout -b feature/nova-funcionalidade`)
3. Commit suas mudanças (`git commit -m 'Adiciona nova funcionalidade'`)
4. Push para a branch (`git push origin feature/nova-funcionalidade`)
5. Abra um Pull Request

## 📝 Licença

Este projeto está sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

## 👨‍💻 Autor

**Milonesco**
- GitHub: [@Milonesco](https://github.com/Milonesco)

## 📊 Status do Desenvolvimento

![Progresso](https://progress-bar.dev/20/?title=Desenvolvimento&width=300&color=yellow)

- **Arquitetura**: ✅ Completa
- **Modelos**: ✅ Completa
- **Business Logic**: ✅ Básica
- **Interface**: 🔄 Em desenvolvimento
- **Testes**: 📋 Planejado
- **Documentação**: 🔄 Em progresso

---

⭐ **Deixe uma estrela se este projeto foi útil para você!**

*Projeto desenvolvido como parte do aprendizado em C# e arquitetura de software.*

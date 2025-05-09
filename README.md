
# MOTIX

Solução desenvolvida para o desafio proposto pela empresa Mottu: transformar pátios desorganizados de motocicletas em ambientes inteligentes, eficientes e rastreáveis.

## Integrantes

| Nome                           | RM       |
|--------------------------------|----------|
| Kleber da Silva Duarte         | RM557887 |
| Lucas Rainha Domingues         | RM558471 |
| Nicolas Candido Barutti Jacuck| RM554944 |

## Visão Geral do Projeto

O MOTIX foi idealizado para resolver o problema logístico enfrentado pela Mottu no gerenciamento de pátios com alto volume de motocicletas, muitas vezes sem identificação visível e mal organizadas.

O sistema visa:

- Mapear e localizar motos com precisão em pátios divididos por setores.
- Exibir em tempo real a disposição das motos.
- Permitir cadastro manual de motos sem placa.
- Automatizar o monitoramento e gerar relatórios de movimentação.

## Como a aplicação .NET contribui para a solução

A aplicação ASP.NET Core serve como a espinha dorsal da solução Motix. Com ela:

- Criamos uma API RESTful robusta e escalável.
- A comunicação com banco de dados Oracle permite persistência segura e consulta eficiente de dados.
- O sistema permite o cadastro de motos, setores, pátios e o rastreio de movimentações.
- A API é documentada automaticamente via Swagger, facilitando testes e futuras integrações com visão computacional.
- O uso de Entity Framework Core com migrations garante uma estrutura de dados padronizada e fácil de evoluir.
- O projeto segue uma arquitetura baseada em Domain-Driven Design, separando lógica de negócio, contexto e mapeamentos.

## Tecnologias Utilizadas

- ASP.NET Core 7 (Web API)
- Entity Framework Core
- Oracle Database
- Swagger (Swashbuckle)
- C#

## Estrutura do Projeto

- /Controllers: endpoints da API
- /Domain: entidades principais (Motorcycle, Sector, Yard, Movement)
- /Infrastructure/Context: DbContext da aplicação
- /Infrastructure/Mapping: configurações de mapeamento com EF Core
- /Program.cs: configuração da aplicação e serviços

## Instruções para Rodar o Projeto

Pré-requisitos:

- .NET SDK 7.0 ou superior
- Banco de dados Oracle com conexão ativa
- Visual Studio ou VS Code

1. Clone o repositório:

```bash
git clone https://github.com/seuusuario/motix.git
cd motix
```

2. Configure a string de conexão em appsettings.json:

```json
"ConnectionStrings": {
  "Oracle": "Data Source=oracle.fiap.com.br:1521/orcl;User ID=RM554944;Password=030903;"
}
```

3. Instale as dependências:

```bash
dotnet restore
```

4. Rode as migrations para criar o banco de dados (caso aplicável):

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

5. Execute a aplicação:

```bash
dotnet run
```

6. Acesse a documentação Swagger:

http://localhost:5000/swagger (ou porta indicada no terminal)

## Endpoints Disponíveis (exemplo)

| Método | Rota                        | Descrição                             |
|--------|-----------------------------|---------------------------------------|
| GET    | /api/motorcycle             | Lista todas as motos                  |
| GET    | /api/motorcycle/{id}        | Retorna uma moto por ID               |
| POST   | /api/motorcycle             | Cadastra uma nova moto                |
| PUT    | /api/motorcycle/{id}        | Atualiza uma moto existente           |
| DELETE | /api/motorcycle/{id}        | Remove uma moto                       |
| GET    | /api/sector                 | Lista setores                         |
| GET    | /api/yard                   | Lista pátios cadastrados              |
| POST   | /api/movement               | Registra movimentação de motocicleta |

## Conclusão

O MOTIX é a base tecnológica que permitirá à Mottu transformar seus pátios em ambientes inteligentes, reduzindo erros, tempo perdido e aumentando a eficiência da operação. A aplicação .NET é essencial para dar suporte a essa transformação de forma segura, escalável e extensível.

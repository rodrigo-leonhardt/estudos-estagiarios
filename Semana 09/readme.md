# Exercícios

1) O arquivo Exemplo.db é um banco de dados SQLite que possui a tabela Cliente, que deve ser mapeada e utilizada através do Entity Framework.
Consulte as referências abaixo para realizar o scaffold (geração do DbContext e modelos) e depois realize as alterações nos trechos destacados do código, para que o resultado da execução seja o seguinte:

```sh
> Deletando clientes
> Incluindo cliente 1 Rodrigo
> Incluindo cliente 2 Natália
> Incluindo cliente 3 Yuri
> Listando clientes ordenados
- 2 Natália
- 1 Rodrigo
- 3 Yuri
```

# Referências

## Ferramentas de Entity Framework Core-CLI do .NET Core

Se as ferramentas do Entity Framework ainda não estiverem instaladas, executar o comando abaixo:
```bash
dotnet tool install --global dotnet-ef
```
Mais detalhes em https://docs.microsoft.com/pt-br/ef/core/cli/dotnet

## Scaffold (engenharia reversa)

Para utilizar o scaffold do Entity Framework neste projeto, execute o comando abaixo na raiz da solução:
```bash
dotnet ef dbcontext scaffold "DataSource=Exemplo.db" -o Modelos Microsoft.EntityFrameworkCore.Sqlite -c ContextoExemplo -f 
```
Mais detalhes em https://docs.microsoft.com/pt-br/ef/core/managing-schemas/scaffolding?tabs=dotnet-core-cli
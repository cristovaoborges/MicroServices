# MicroServices

Banco de Dados: SQL SERVER
ORM : EntityFramework

O Sistema funciona com migrations para as aplicações StoneEstabelecimento, StoneExtrato, StoneLancamentos

Necessário apontar a conexão do  banco de dados nas aplicações (não é necessário criar as bases)

API ESTABELECIMENTOS
Stone.Estabelecimentos\Stone.Estabelecimentos.API\appsettings.json
Stone.Estabelecimentos\Stone.Estabelecimentos.INFRA\Repository\Context\SqlServerContext.cs

API LANCAMENTOS
Stone.Lancamentos\Stone.Lancamentos.API\appsettings.json
Stone.Lancamentos\Stone.Lancamentos.INFRA\Repository\Context\SqlServerContext.cs

Gerar o banco de dados e os registros base

Base Estabelecimento
Acessar o diretório abaixo e executar o comando: dotnet ef database update
Stone.Estabelecimentos\Stone.Estabelecimentos.INFRA>

Base Lancamento
Acessar o diretório abaixo e executar o comando: dotnet ef database update
Stone.Lancamentos\Stone.Lancamentos.INFRA>



 

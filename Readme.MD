


Organização das pastas

Controllers - Cliente - Exemplos Postman, Web, Mobile - Irão fazer "Request" e sempre vira para o "Controllers". O "Controller" não sabe pegar os dados então ele pede ao "Services"

Services - Casos de uso - Regras de negocio. Por sua vez tambem não pega dados solicita ao "Repositories".

Repositories - Busca do Dados para o Services.

Data - DbComtext - ORM - Ligação com as tabelas dos DB.


### Para instalação do Postegres v18 
Não acompanha no setup de instalação o Npgsql

Instale: PS: Install-Package Npgsql ou Bash: dotnet add package Npgsql
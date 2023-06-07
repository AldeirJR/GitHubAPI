# GitHubAPI
O principal objetivo deste projeto é simplificar a interação com a API do GitHub, fornecendo um conjunto conveniente e consistente de endpoints. Ele abstrai as complexidades de fazer solicitações diretas à API do GitHub e fornece uma superfície de API mais direta para os clientes consumirem.

A API da Web oferece os seguintes pontos de extremidade:

GET - /api/users?since={number}:

Descrição: recupera uma lista de usuários do GitHub.
Parâmetros: since (opcional) - Especifica o ID do usuário para iniciar a lista.
Resposta: retorna uma lista de usuários do GitHub e um link para a próxima página.
GET - /api/users/:nome de usuário/detalhes:

Descrição: recupera os detalhes de um usuário específico do GitHub.
Parâmetros: username - Especifica o nome de usuário do usuário do GitHub.
Resposta: retorna os detalhes do usuário do GitHub, incluindo nome de usuário, biografia, contagem de seguidores, etc.
GET - /api/users/:username/repos:

Descrição: recupera uma lista de repositórios pertencentes a um usuário específico do GitHub.
Parâmetros: username - Especifica o nome de usuário do usuário do GitHub.
Resposta: retorna uma lista de repositórios pertencentes ao usuário do GitHub, incluindo detalhes como nome do repositório, descrição, contagem de estrelas, etc.
O projeto é implementado usando ASP.NET Core, fornecendo uma estrutura de aplicativo da Web escalável e eficiente. Ele aproveita a classe HttpClient para fazer solicitações à API do GitHub e, em seguida, transforma e encaminha as respostas para o cliente.

O projeto também inclui testes de unidade usando a estrutura de teste MSTest. Esses testes abrangem todos os endpoints da API, garantindo sua correção e verificando o comportamento esperado da API.

No geral, a API da Web do GitHub API Proxy simplifica a integração com a API do GitHub, fornecendo uma interface simplificada e padronizada, permitindo que os clientes recuperem informações do usuário e dados do repositório do GitHub de maneira mais conveniente e eficiente.

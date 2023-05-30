# GitHubAPI
The GitHub API Proxy Web API is a service that acts as a proxy for client requests to the GitHub API. It allows clients to interact with various GitHub endpoints through a unified interface provided by the Web API.

The main purpose of this project is to simplify the interaction with the GitHub API by providing a convenient and consistent set of endpoints. It abstracts away the complexities of making direct requests to the GitHub API and provides a more straightforward API surface for clients to consume.

The Web API offers the following endpoints:

GET - /api/users?since={number}:

Description: Retrieves a list of GitHub users.
Parameters: since (optional) - Specifies the ID of the user to start the list from.
Response: Returns a list of GitHub users and a link to the next page.
GET - /api/users/:username/details:

Description: Retrieves the details of a specific GitHub user.
Parameters: username - Specifies the username of the GitHub user.
Response: Returns the details of the GitHub user, including their username, bio, followers count, etc.
GET - /api/users/:username/repos:

Description: Retrieves a list of repositories owned by a specific GitHub user.
Parameters: username - Specifies the username of the GitHub user.
Response: Returns a list of repositories owned by the GitHub user, including details such as repository name, description, stars count, etc.
The project is implemented using ASP.NET Core, providing a scalable and efficient web application framework. It leverages the HttpClient class to make requests to the GitHub API and then transforms and forwards the responses to the client.

The project also includes unit tests using the testing framework MSTest. These tests cover all the API endpoints, ensuring their correctness and verifying the expected behavior of the API.

Overall, the GitHub API Proxy Web API simplifies the integration with the GitHub API by providing a streamlined and standardized interface, allowing clients to retrieve user information and repository data from GitHub in a more convenient and efficient manner.

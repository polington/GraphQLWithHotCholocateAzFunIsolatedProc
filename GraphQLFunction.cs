using HotChocolate.AzureFunctions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace IsolatedProcessAzFun
{
    public class GraphQLFunction
    {
        private readonly ILogger<GraphQLFunction> _logger;
        private readonly IGraphQLRequestExecutor _executor;

        public GraphQLFunction(ILogger<GraphQLFunction> logger, IGraphQLRequestExecutor executor)
        {
            _logger = logger;
            _executor = executor;
        }

        [Function("GraphQLHttpFunction")]
        public Task<HttpResponseData> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "graphql/{**slug}")] HttpRequestData request)
        => _executor.ExecuteAsync(request);
    }
}

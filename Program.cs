using IsolatedProcessAzFun;
using IsolatedProcessAzFun.Repository;
using IsolatedProcessAzFun.Schema;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWebApplication()
    //.AddGraphQLFunction(b => b.AddQueryType<Query>().AddMutationType<Mutation>())//GraphQL server and Azure Functions integration set up
    .AddGraphQLFunction(b => b.AddQueryType<Query>().AddMutationType<Mutation>())//GraphQL server and Azure Functions integration set up
    .ConfigureServices(services =>
    {
        services.AddApplicationInsightsTelemetryWorkerService();
        services.ConfigureFunctionsApplicationInsights();
        services.AddSingleton<PersonRepository>();
    })
    .Build();

host.Run();

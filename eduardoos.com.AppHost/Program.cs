var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.eduardoos_com_ApiService>("apiservice");

builder.AddProject<Projects.eduardoos_com_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();

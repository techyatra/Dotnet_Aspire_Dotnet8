

var builder = DistributedApplication.CreateBuilder(args);
var apiService = builder.AddProject<Projects.WEBAPI>("api");
builder.AddProject<Projects.WEBAPP>("webapp").WithReference(apiService);

builder.Build().Run();



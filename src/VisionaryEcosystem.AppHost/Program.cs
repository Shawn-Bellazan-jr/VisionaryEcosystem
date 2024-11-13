var builder = DistributedApplication.CreateBuilder(args);

var api = builder.AddProject<Projects.VisionaryEcosystem_API>("visionaryecosystem-api");
builder.AddProject<Projects.VisionaryEcosystem_BlazorApp>("visionaryecosystem-blazorapp")
    .WithReference(api);

builder.Build().Run();

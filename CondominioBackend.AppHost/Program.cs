var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Reserva_API>("reserva-api");

builder.Build().Run();

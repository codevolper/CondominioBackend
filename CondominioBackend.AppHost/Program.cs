var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Reserva_API>("reserva-api");

builder.AddProject<Projects.GerenciaUsuario_API>("gerenciausuario-api");

builder.Build().Run();

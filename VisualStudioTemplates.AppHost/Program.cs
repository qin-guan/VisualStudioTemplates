var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.VueApp_Server>("vueapp-server");

builder.Build().Run();

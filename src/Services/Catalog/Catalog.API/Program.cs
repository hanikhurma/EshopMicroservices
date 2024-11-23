using Carter;

var builder = WebApplication.CreateBuilder(args);

// Add the Services to the container

builder.Services.AddCarter();
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssemblies(typeof(Program).Assembly);
});

var app = builder.Build();


//Confige the http request pipeline 
app.MapCarter();
app.Run();


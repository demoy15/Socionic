var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var services = builder.Services;
services.AddControllers();

var app = builder.Build();

app.UseSwagger();

app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Events Service API V1");
})
    .UseRouting()
    .UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
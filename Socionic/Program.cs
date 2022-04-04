using Microsoft.EntityFrameworkCore;
using Socionic.DBContext;
using Socionic.Services;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddEndpointsApiExplorer();
services.AddSwaggerGen();
var connectionString = builder.Configuration.Get<PostgresOptions>(op => op.BindNonPublicProperties = true).ConnectionString;

services.AddDbContext<DbContext, SocionicContext>(o =>
{
    o.UseNpgsql(connectionString);
});

services.AddTransient<IQuestionService, QuestionService>();

services.AddControllers();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<SocionicContext>();
    db.Database.Migrate();
}

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
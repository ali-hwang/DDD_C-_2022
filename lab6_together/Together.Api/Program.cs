using Together.Application;
using Together.Application.Services;
using Together.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    // Add services to the container.
    builder.Services.AddControllers();
    //builder.Services.AddScoped<IEventService,EventService>();
    builder.Services.AddApplication();
    builder.Services.AddInfrastructure();
}
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

var app = builder.Build();
{
    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();
}
app.Run();

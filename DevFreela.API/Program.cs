using DevFreela.API.Options;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.Configure<OpeningTimeOptions>(builder.Configuration.GetSection("OpeningTime"));

    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
}

var app = builder.Build();
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}

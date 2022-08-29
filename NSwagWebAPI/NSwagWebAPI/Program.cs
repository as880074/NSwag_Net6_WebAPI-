var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// Add OpenAPI v3 document
builder.Services.AddOpenApiDocument();
// Add Swagger v2 document
// builder.Services..AddSwaggerDocument();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseOpenApi();       // serve OpenAPI/Swagger documents
    app.UseSwaggerUi3();    // serve Swagger UI
    app.UseReDoc();         // serve ReDoc UI
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(policies =>
{
    policies.AddDefaultPolicy(bydefault =>
    {
        bydefault.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
    });
});


builder.Services.AddScoped(typeof(di_demo.Employee));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(); //middleware

app.UseAuthorization();

app.MapControllers();

app.Run();

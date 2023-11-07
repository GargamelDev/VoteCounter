using VoutesCounter.Persistance;
using Microsoft.EntityFrameworkCore;
using VoutesCounter.Core;

var builder = WebApplication.CreateBuilder(args);

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("*");
                          policy.WithHeaders("*");
                          policy.WithMethods("*");
                      });
});

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<IVoterRepository, VoterRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
// Add services to the container.
var connectionString = builder
        .Configuration
        .GetConnectionString("Default");

builder.Services.AddDbContext<VoutesCounterDbContext>(
    options => options.UseSqlServer(connectionString));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
app.UseSwagger();
app.UseSwaggerUI();
// }

app.UseHttpsRedirection();

app.UseCors(MyAllowSpecificOrigins);
app.UseAuthorization();

app.MapControllers();

app.Run();

using Microsoft.EntityFrameworkCore;
using MuitaCoisaCSharp.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MuitasCoisasDbContext>(
    options => options.UseSqlServer(
        Environment.GetEnvironmentVariable("SQL_CONNECTION")
    )
);

var app = builder.Build();

app.MapGet("/", () => "Hello World");

app.Run();

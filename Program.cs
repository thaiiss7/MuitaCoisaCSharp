using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MuitaCoisaCSharp.Implementations;
using MuitaCoisaCSharp.Models;
using MuitaCoisaCSharp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MuitasCoisasDbContext>(
    options => options.UseSqlServer(
        Environment.GetEnvironmentVariable("SQL_CONNECTION")
    )
);

builder.Services.AddTransient<IDivaRepository, MockDivaRepository>();

var app = builder.Build();

app.MapControllers();

app.Run();

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

app.MapGet("divas/{search}", async (string search, [FromServices] IDivaRepository repo) =>
{
    var divas = await repo.Search(search);
    if (divas.Count() == 0)
        return Results.NotFound();

    return Results.Ok(divas);
});

// app.MapPost("divas", async ([FromBody]DivaCreatePayload diva, [FromServices]IDivaRepository repo) =>
// {
//     var divas = await repo.Search(diva.Name);
//     if (divas.Any )

//     await repo.Create(new Diva
//     {
//         Name = diva.Name
//     });
//     return Results.Ok();
// })

app.Run();

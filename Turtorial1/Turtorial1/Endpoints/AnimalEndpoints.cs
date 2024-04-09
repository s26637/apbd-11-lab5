using Turtorial1.Database;
using Turtorial1.Models;

namespace Turtorial1.Endpoints;

public static class AnimalEndpoints
{

    public static void MapAnimalEndpoints(this WebApplication app)
    {
        //Minimal API
        app.MapGet("/animals", () =>
        {
            // 200 - Ok
            // 201 - Created
            // 400 - Bad request
            // 401 - Unauthorized
            // 403 - Forbidden
            // 404 - Not found 
            var animals = StaticData.Animals;
            return Results.Ok();
        });

        app.MapGet("/animals/{id}", (int id) =>
        {
            return Results.Ok(id);
        });

        app.MapPost("/animals", (Animal animal ) =>
        {
            return Results.Created("", animal);
        });
    }
}
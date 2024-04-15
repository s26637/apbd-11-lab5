using Microsoft.AspNetCore.Mvc;
using Turtorial1.Database;
using Turtorial1.Models;

namespace Turtorial1.Controllers;

[ApiController]
[Route("/animals-controller")]
//[Route("Controller")]
public class AnimalsController : ControllerBase
{

    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok(StaticData.Animals);
    }
    
    [HttpGet("{id}")]
    public IActionResult GetAnimals(int id)
    {
        return Ok(StaticData.getAnimalUsingId(id));
    }

    [HttpPost]
    public IActionResult AddAnimal(int id, string imie, string kategoria, double masa, string kolor)
    {
        StaticData.Animals.Add(new Animal(id, imie, kategoria, masa,kolor));
        return Ok();
    }

    [HttpPost ("{id}")]
    public IActionResult changeAnimalMass(int id, double masa)
    {
        Animal animal = StaticData.getAnimalUsingId(id);
        if (animal != null)
        {
            animal.masa = masa;
        }
        return Ok();
    }
    

    [HttpDelete("{id}")]
    public IActionResult AnimalDelete(int id)
    {
        StaticData.deleteAnimalUsingId(id);
        return Ok();
    }
    

    

}
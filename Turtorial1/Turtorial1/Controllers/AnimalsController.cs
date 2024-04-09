using Microsoft.AspNetCore.Mvc;

namespace Turtorial1.Controllers;

[ApiController]
[Route("/animals-controller")]
//[Route("Controller")]
public class AnimalsController : ControllerBase
{

    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok();
    }
    
    [HttpGet]
    public IActionResult GetAnimals(int id)
    {
        return Ok(id);
    }

    [HttpPost]
    public IActionResult AddAnimal()
    {
        return Ok();
    }


    

}
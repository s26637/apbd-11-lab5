using Microsoft.AspNetCore.Mvc;
using Turtorial1.Database;
using Turtorial1.Models;


[ApiController]
[Route("/visit-controller")]

public class VisitController : ControllerBase
{
    
        
    [HttpPost]
    public IActionResult addAnimalVisits(string data, int id, string opis, double cena)
    {
        StaticData.dodajWizyte(data, id, opis, cena);
        return Ok();
    }
    
    [HttpGet("{id}")]
    public IActionResult getAnimalsVisits(int id)
    {
        
        return Ok(StaticData.listaWizyt(id));
    }
    
    
}
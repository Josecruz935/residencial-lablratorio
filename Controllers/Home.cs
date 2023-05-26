using Residencial;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class HomeController : ControllerBase
{


Residencialcontext Dbcontext;


public HomeController(Residencialcontext db){
Dbcontext = db;

}

[HttpGet]
[Route("ConnDB")]
public IActionResult ConnDB(){
Dbcontext.Database.EnsureCreated();
return Ok();

}
}
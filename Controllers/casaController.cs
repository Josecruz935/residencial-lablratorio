using Residencial.Service;
using Microsoft.AspNetCore.Mvc;
namespace Residencial.MapControllers;

//atributos para los controles
[ApiController]
[Route("[controller]")]

public class casaController: ControllerBase
{

        IcasaService casaService;
    public casaController(IcasaService servicecasa) => casaService = servicecasa;

    //atributos para los endpoint 

    //Create
    [HttpPost]
public async Task<IActionResult> PostAutors([FromBody] casa newcasa) {
    await casaService.insertar(newcasa);
    var result = newcasa.casaId;
    if(result == null){
        return BadRequest();
    }
return Ok("Se ingreso Correctamente");

}
//Read
[HttpGet]
public IActionResult Getcasa() {

return Ok(casaService.obtener());
}

//Update
[HttpPut("{id}")]
public IActionResult Updatecasa([FromBody] casa casaActualizar, Guid id) {
    casaService.Actualizar(id,casaActualizar);
return Ok("Actualizado Corretcamente");
}

//Delete
[HttpDelete("{id}")]

public IActionResult DeleteAutores(Guid id) {
return Ok(casaService.eliminar(id));



}




}
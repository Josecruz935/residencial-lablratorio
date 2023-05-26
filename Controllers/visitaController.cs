using Residencial.Service;
using Microsoft.AspNetCore.Mvc;
namespace Residencial.MapControllers;

//atributos para los controles
[ApiController]
[Route("[controller]")]

public class visitaController: ControllerBase
{

        IvisitaService visitaService;
    public visitaController(IvisitaService servicevisita) => visitaService = servicevisita;

    //atributos para los endpoint 

    //Create
    [HttpPost]
public async Task<IActionResult> PostAutors([FromBody] visita newvisita) {
    await visitaService.insertar(newvisita);
    var result = newvisita.visitaId;
    if(result == null){
        return BadRequest();
    }
return Ok("Se ingreso Correctamente");

}
//Read
[HttpGet]
public IActionResult Getcasa() {

return Ok(visitaService.obtener());
}

//Update
[HttpPut("{id}")]
public IActionResult Updatecasa([FromBody] visita visitaActualizar, Guid id) {
    visitaService.Actualizar(id,visitaActualizar);
return Ok("Actualizado Corretcamente");
}

//Delete
[HttpDelete("{id}")]

public IActionResult DeleteAutores(Guid id) {
return Ok(visitaService.eliminar(id));



}




}
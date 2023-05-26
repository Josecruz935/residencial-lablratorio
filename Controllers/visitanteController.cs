using Residencial.Service;
using Microsoft.AspNetCore.Mvc;
namespace Residencial.MapControllers;

//atributos para los controles
[ApiController]
[Route("[controller]")]

public class visitanteController: ControllerBase
{

        IvisitanteService visitanteService;
    public visitanteController(IvisitanteService servicevisitante) => visitanteService = servicevisitante;

    //atributos para los endpoint 

    //Create
    [HttpPost]
public async Task<IActionResult> PostAutors([FromBody] visitante newvisitante) {
    await visitanteService.insertar(newvisitante);
    var result = newvisitante.visitanteId;
    if(result == null){
        return BadRequest();
    }
return Ok("Se ingreso Correctamente");

}
//Read
[HttpGet]
public IActionResult Getcasa() {

return Ok(visitanteService.obtener());
}

//Update
[HttpPut("{id}")]
public IActionResult Updatecasa([FromBody] visitante visitanteActualizar, Guid id) {
    visitanteService.Actualizar(id,visitanteActualizar);
return Ok("Actualizado Corretcamente");
}

//Delete
[HttpDelete("{id}")]

public IActionResult DeleteAutores(Guid id) {
return Ok(visitanteService.eliminar(id));



}




}
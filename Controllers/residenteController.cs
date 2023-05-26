using Residencial.Service;
using Microsoft.AspNetCore.Mvc;
namespace Residencial.MapControllers;

//atributos para los controles
[ApiController]
[Route("[controller]")]

public class residenteController: ControllerBase
{

        IresidenteService residenteService;
    public residenteController(IresidenteService serviceresidente) => residenteService = serviceresidente;

    //atributos para los endpoint 

    //Create
    [HttpPost]
public async Task<IActionResult> PostAutors([FromBody] residente newresidente) {
    await residenteService.insertar(newresidente);
    var result = newresidente.residenteId;
    if(result == null){
        return BadRequest();
    }
return Ok("Se ingreso Correctamente");

}
//Read
[HttpGet]
public IActionResult Getresidente() {

return Ok(residenteService.obtener());
}

//Update
[HttpPut("{id}")]
public IActionResult Updateresidente([FromBody] residente residenteActualizar, Guid id) {
    residenteService.Actualizar(id,residenteActualizar);
return Ok("Actualizado Corretcamente");
}

//Delete
[HttpDelete("{id}")]

public IActionResult DeleteAutores(Guid id) {
return Ok(residenteService.eliminar(id));



}




}
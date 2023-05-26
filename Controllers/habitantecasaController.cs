using Residencial.Service;
using Microsoft.AspNetCore.Mvc;
namespace Residencial.MapControllers;

//atributos para los controles
[ApiController]
[Route("[controller]")]

public class habitantecasaController: ControllerBase
{

        IhabitantecasaService habitantecasaService;
    public habitantecasaController(IhabitantecasaService servicehabitantecasa) => habitantecasaService = servicehabitantecasa;

    //atributos para los endpoint 

    //Create
    [HttpPost]
public async Task<IActionResult> PostAutors([FromBody] habitantecasa newhabitantecasa) {
    await habitantecasaService.insertar(newhabitantecasa);
    var result = newhabitantecasa.habitantecasaId;
    if(result == null){
        return BadRequest();
    }
return Ok("Se ingreso Correctamente");

}
//Read
[HttpGet]
public IActionResult Gethabitantecasa() {

return Ok(habitantecasaService.obtener());
}

//Update
[HttpPut("{id}")]
public IActionResult Updatehabitantecasa([FromBody] habitantecasa habitantecasaActualizar, Guid id) {
    habitantecasaService.Actualizar(id,habitantecasaActualizar);
return Ok("Actualizado Corretcamente");
}

//Delete
[HttpDelete("{id}")]

public IActionResult DeleteAutores(Guid id) {
return Ok(habitantecasaService.eliminar(id));



}




}
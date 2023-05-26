namespace Residencial.Service;



public class visitanteService : IvisitanteService {
//Inyeccion de dependencias.
Residencialcontext context5;

public visitanteService(Residencialcontext DbContext) => context5 = DbContext;

//CRUD

//Create

//Async await

public async Task insertar(visitante inputvisitante ){
   await context5.AddAsync(inputvisitante);
    await context5.SaveChangesAsync();
}


    //READ - obtener de la db 
    public IEnumerable<visitante> obtener() => context5.visitante;

    //UPDATE
    public async Task Actualizar(Guid id, visitante inputvisitante){
    var visitante = context5.visitante.Find(id);
    if(visitante != null){
        visitante.nombre = inputvisitante.nombre;
        visitante.identificacion = inputvisitante.identificacion;
        visitante.sexo = inputvisitante.sexo;
        visitante.edad = inputvisitante.edad;
        await context5.SaveChangesAsync();
    }
}




public async Task eliminar(Guid id){
    var visitante = context5.visitante.Find(id);
    if(visitante != null){
        context5.Remove(visitante);
        await context5.SaveChangesAsync();
    }
}

public async Task<bool> Existevisitante(Guid visitanteId) {
    var visitante = await context5.visitante.FindAsync(visitanteId);
    return visitante != null;
}}


public interface IvisitanteService{
Task insertar(visitante inputvisitante);
IEnumerable<visitante> obtener();
Task Actualizar(Guid id, visitante visitante);
Task eliminar(Guid Id);

}
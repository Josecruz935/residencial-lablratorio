namespace Residencial.Service;



public class visitaService : IvisitaService {
//Inyeccion de dependencias.
Residencialcontext context4;

public visitaService(Residencialcontext DbContext) => context4 = DbContext;

//CRUD

//Create

//Async await

public async Task insertar(visita inputvisita ){
   await context4.AddAsync(inputvisita);
    await context4.SaveChangesAsync();
}


    //READ - obtener de la db 
    public IEnumerable<visita> obtener() => context4.visita;

    //UPDATE
    public async Task Actualizar(Guid id, visita inputvisita){
    var visita = context4.visita.Find(id);
    if(visita != null){
        visita.FechadeEntrada = inputvisita.FechadeEntrada;
        visita.Fechadesalida = inputvisita.Fechadesalida;
        visita.visitanteId = inputvisita.visitanteId;
        visita.hogarId = inputvisita.hogarId;
        visita.codigoqr = inputvisita.codigoqr;
        visita.estado = inputvisita.estado;

        await context4.SaveChangesAsync();
    }
}




public async Task eliminar(Guid id){
    var visita = context4.visita.Find(id);
    if(visita != null){
        context4.Remove(visita);
        await context4.SaveChangesAsync();
    }
}

public async Task<bool> Existevisita(Guid visitaId) {
    var visita = await context4.visita.FindAsync(visitaId);
    return visita != null;
}}


public interface IvisitaService{
Task insertar(visita inputvisita);
IEnumerable <visita> obtener();
Task Actualizar(Guid id, visita visita);
Task eliminar(Guid Id);

}
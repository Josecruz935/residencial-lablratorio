namespace Residencial.Service;



public class casaService : IcasaService {
//Inyeccion de dependencias.
Residencialcontext context;

public casaService(Residencialcontext DbContext) => context = DbContext;

//CRUD

//Create

//Async await

public async Task insertar(casa inputcasa ){
   await context.AddAsync(inputcasa);
    await context.SaveChangesAsync();
}


    //READ - obtener de la db 
    public IEnumerable<casa> obtener() => context.casa;

    //UPDATE
    public async Task Actualizar(Guid id, casa inputcasa){
    var casa = context.casa.Find(id);
    if(casa != null){
        casa.numero = inputcasa.numero;
        casa.bloque = inputcasa.bloque;
        casa.calle = inputcasa.calle;
        casa.referencia = inputcasa.referencia;
        await context.SaveChangesAsync();
    }
}




public async Task eliminar(Guid id){
    var casa = context.casa.Find(id);
    if(casa != null){
        context.Remove(casa);
        await context.SaveChangesAsync();
    }
}

public async Task<bool> Existecasa(Guid casaId) {
    var casa = await context.casa.FindAsync(casaId);
    return casa != null;
}}


public interface IcasaService{
Task insertar(casa inputcasa);
IEnumerable<casa> obtener();
Task Actualizar(Guid id, casa casa);
Task eliminar(Guid Id);

}
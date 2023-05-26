namespace Residencial.Service;



public class residenteService : IresidenteService {
//Inyeccion de dependencias.
Residencialcontext context3;

public residenteService(Residencialcontext DbContext) => context3 = DbContext;

//CRUD

//Create

//Async await

public async Task insertar(residente inputresidente ){
   await context3.AddAsync(inputresidente);
    await context3.SaveChangesAsync();
}


    //READ - obtener de la db 
    public IEnumerable<residente> obtener() => context3.residente;

    //UPDATE
    public async Task Actualizar(Guid id, residente inputresidente){
    var residente = context3.residente.Find(id);
    if(residente != null){
        residente.nombre = inputresidente.nombre;
        residente.identificacion = inputresidente.identificacion;
        residente.telefono = inputresidente.telefono;
        await context3.SaveChangesAsync();
    }
}




public async Task eliminar(Guid id){
    var residente = context3.residente.Find(id);
    if(residente != null){
        context3.Remove(residente);
        await context3.SaveChangesAsync();
    }
}

public async Task<bool> Existeresidente(Guid residenteId) {
    var residente = await context3.residente.FindAsync(residenteId);
    return residente != null;
}}


public interface IresidenteService{
Task insertar(residente inputresidente);
IEnumerable<residente> obtener();
Task Actualizar(Guid id, residente residente);
Task eliminar(Guid Id);

}
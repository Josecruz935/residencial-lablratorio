namespace Residencial.Service;



public class habitantecasaService : IhabitantecasaService {
//Inyeccion de dependencias.
Residencialcontext context1;

public habitantecasaService(Residencialcontext DbContext) => context1 = DbContext;

//CRUD

//Create

//Async await

public async Task insertar(habitantecasa inputhabitantecasa ){
   await context1.AddAsync(inputhabitantecasa);
    await context1.SaveChangesAsync();
}


    //READ - obtener de la db 
    public IEnumerable<habitantecasa> obtener() => context1.habitantecasa;

    //UPDATE
    public async Task Actualizar(Guid id, habitantecasa inputhabitantecasa){
    var habitantecasa = context1.habitantecasa.Find(id);
    if(habitantecasa != null){
        habitantecasa.casaid = inputhabitantecasa.casaid;
        habitantecasa.residenteid = inputhabitantecasa.residenteid;
        habitantecasa.parentesco = inputhabitantecasa.parentesco;
        await context1.SaveChangesAsync();
    }
}




public async Task eliminar(Guid id){
    var habitantecasa = context1.habitantecasa.Find(id);
    if(habitantecasa != null){
        context1.Remove(habitantecasa);
        await context1.SaveChangesAsync();
    }
}

public async Task<bool> Existehabitantecasa(Guid habitantecasaId) {
    var habitantecasa = await context1.habitantecasa.FindAsync(habitantecasaId);
    return habitantecasa != null;
}}


public interface IhabitantecasaService{
Task insertar(habitantecasa inputhabitantecasa);
IEnumerable<habitantecasa> obtener();
Task Actualizar(Guid id, habitantecasa habitantecasa);
Task eliminar(Guid Id);

}
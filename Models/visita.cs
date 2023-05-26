using System.ComponentModel.DataAnnotations;

public class visita{
[Key]
 public Guid visitaId { get; set; } = Guid.NewGuid();
[Required]
public int FechadeEntrada{get; set;}
[Required]
public int Fechadesalida {get;set;}
[Required]

public int visitanteId {get;set;}
[Required]


public int hogarId{get;set;} 
[Required]

public int codigoqr{get;set;} 
[Required] 

public Boolean estado{get;set;}

    
}
using System.ComponentModel.DataAnnotations;

public class casa{
[Key]
 public Guid casaId { get; set; } = Guid.NewGuid();
[Required]
public int numero{get; set;}
[Required]
public int bloque {get;set;}
[Required]

public int calle {get;set;}
[Required]


public int referencia{get;set;}



}
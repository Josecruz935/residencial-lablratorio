using System.ComponentModel.DataAnnotations;

public class visitante{
[Key]
 public Guid visitanteId { get; set; } = Guid.NewGuid();
[Required]
public int identificacion{get; set;}
[Required]
public Boolean nombre{get;set;}
[Required]

public Boolean sexo {get;set;}
[Required]


public int edad {get;set;} 





}
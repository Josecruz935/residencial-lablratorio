using System.ComponentModel.DataAnnotations;

public class residente{
[Key]
 public Guid residenteId { get; set; } = Guid.NewGuid();
[Required]
public int identificacion{get; set;}
[Required]
public int nombre{get;set;}
[Required]


public int telefono{get;set;} 





}
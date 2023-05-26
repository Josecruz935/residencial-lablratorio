using System.ComponentModel.DataAnnotations;

public class habitantecasa{
[Key]
 public Guid habitantecasaId { get; set; } = Guid.NewGuid();
[Required]
public int casaid{get; set;}
[Required]
public int residenteid {get;set;}
[Required]


public int parentesco{get;set;} 





}
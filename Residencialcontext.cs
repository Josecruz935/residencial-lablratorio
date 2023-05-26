using Microsoft.EntityFrameworkCore;

namespace Residencial{
    
public class Residencialcontext: DbContext {
  public DbSet <casa> casa {get;set;}
public DbSet <visita> visita {get; set;}
public DbSet <visitante> visitante {get; set;}
public DbSet <habitantecasa> habitantecasa {get; set;}

public DbSet<residente> residente {get; set;}


public Residencialcontext(DbContextOptions<Residencialcontext> options) : base(options){}
}}
#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace FirstConnection.Models;
public class Mascota
{
    [Key]
    public int Id { get; set; }

    
    public string Nombre { get; set; }


    public string Tipo { get; set; }


    public int Edad {get;set;}


    public bool Pelaje {get;set;}

    public DateTime FechaCreacion {get; set;} = DateTime.Now;

    public DateTime FechaActualizacion {get; set;} = DateTime.Now;
}
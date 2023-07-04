using System.ComponentModel.DataAnnotations;

namespace MvcCarRent.Models;

public class Client {
    public int Id { get; set; }
    [Required]
    [Display(Name="Nombre")]
    public string? Name { get; set; }
    [Required]
    [Display(Name="Apellido")]
    public string? Surname { get; set; }
    [Required]
    [Display(Name="Número de Documento")]
    public int IdCardNumber { get; set; }
    [Required]
    [Display(Name="Licencia de Conducir")]
    public string? DriverLicense { get; set; }
    [Required]
    public string? Email { get; set; }
    [Required]
    [Display(Name="Número de  teléfono")]
    public int PhoneNumber {get; set;}
}
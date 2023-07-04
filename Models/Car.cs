using MvcCarRent.Utils;
using System.ComponentModel.DataAnnotations;

namespace MvcCarRent.Models;

public class Car {
    public int Id { get; set; }
    [Required]
    [Display(Name="Marca")]
    public string? Brand { get; set; }
    [Required]
    [Display(Name="Modelo")]
    public string? Model { get; set; }
    [Display(Name="Anio")]
    public int Year { get; set; }
    [Required]
    [Display(Name="Patente")]
    public string? LicensePlate { get; set; }
    [Display(Name="Está Rentado")]
    public bool IsRented { get; set; } = false;
    [Display(Name="Transmision")]
    public TransmissionType Transmission { get; set; }
    [Display(Name="Precio por Día")]
    public decimal PricePerDay { get; set; }
}
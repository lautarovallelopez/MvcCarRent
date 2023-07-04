namespace MvcCarRent.Models;

public class Rent {
    public int Id { get; set; }
    public int CarId { get; set; }
    public int ClientId { get; set; }
    public DateTime DateFrom { get; set; }
    public DateTime DateTo { get; set; }
}
using MvcCarRent.Utils;

namespace MvcCarRent.Models;

public class Bill {
    public int Id { get; set; }
    public int RentId { get; set; }
    public decimal FinalPrice { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
}
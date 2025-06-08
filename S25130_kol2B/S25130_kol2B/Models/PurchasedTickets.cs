using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace S25130_kol2B.Models;

[Table("PurchasedTickets")]
[PrimaryKey(nameof(TicketConcert), nameof(Customer))]
public class PurchasedTickets
{
    [ForeignKey(nameof(TicketConcert))]
    public int TicketConcertID { get; set; }
    [ForeignKey(nameof(Customer))]
    public int CustomerID { get; set; }
    public DateTime PurchaseDate { get; set; }

    public TicketConcert TicketConcert { get; set; } = null!;
    public Customer Customer { get; set; } = null!;
    public int TicketConcertId { get; set; }
    public int CustomerId { get; set; }
}
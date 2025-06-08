using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace S25130_kol2B.Models;

[Table("Ticket")]
public class Ticket
{
    [Key]
    public int TicketId { get; set; }
    [MaxLength(50)]
    public string SerialNumber { get; set; } = null!;
    
    public string SeatNumber { get; set; } = null!;

    public ICollection<Ticket> Tickets { get; set; } = null!;
}
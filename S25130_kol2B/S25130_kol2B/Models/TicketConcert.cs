using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace S25130_kol2B.Models;

[Table("TicketConcert")]
public class TicketConcert
{
    [Key]
    public int TicketConcertId { get; set; }
    
    [ForeignKey(nameof(Ticket))]
    public int TicketId { get; set; }
    
    [ForeignKey(nameof(Concert))]
    public int ConcertID { get; set; }
    
    [Column(TypeName = "decimal")]
    [Precision(10, 2)]
    public double Price { get; set; }

    public Ticket Ticket { get; set; } = null!;
    public Concert Concert { get; set; } = null!;
    
    public ICollection<TicketConcert> TicketConcerts { get; set; } = null!;
}
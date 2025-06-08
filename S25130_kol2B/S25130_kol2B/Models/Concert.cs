using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace S25130_kol2B.Models;

[Table("Concert")]
public class Concert
{
    [Key]
    public int ConcertId { get; set; }
    [MaxLength(100)]
    public string Name { get; set; } = null!;
    public DateTime Date { get; set; }
    public int AvaibleTickets { get; set; }
    
    public ICollection<Concert> Concerts { get; set; } = null!;
}
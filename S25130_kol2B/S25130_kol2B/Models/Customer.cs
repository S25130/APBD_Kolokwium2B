using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace S25130_kol2B.Models;

[Table("Customer")]
public class Customer
{
    [Key]
    public int CustomerId { get; set; }

    [MaxLength(50)] 
    public string FirstName { get; set; }
    
    [MaxLength(100)]
    public string LastName { get; set; }

    [MaxLength(100)] 
    public string PhoneNumber { get; set; } = null;
    
    public ICollection<Customer> Customers { get; set; } = null!;
}
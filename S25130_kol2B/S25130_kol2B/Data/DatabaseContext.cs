using S25130_kol2B.Models;
using Microsoft.EntityFrameworkCore;

namespace S25130_kol2B.Data;

public class DatabaseContext : DbContext
{
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<Concert> Concerts { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<TicketConcert> TicketConcerts { get; set; }
    public DbSet<PurchasedTickets> PurchasedTickets { get; set; }
    
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ticket>().HasData(new List<Ticket>()
        {
            new Ticket() { TicketId = 1, SerialNumber = "John", SeatNumber = "Doe" },
            new Ticket() { TicketId = 2, SerialNumber = "Jane", SeatNumber = "Doe" },
            new Ticket() { TicketId = 3, SerialNumber = "Julie", SeatNumber = "Doe" },
        });
        
        modelBuilder.Entity<Concert>().HasData(new List<Concert>()
        {
            new Concert() { ConcertId = 1, Name = "Created", Date = DateTime.Parse("2025-05-01"), AvaibleTickets = 20 },
            new Concert() { ConcertId = 2, Name = "Ongoing", Date = DateTime.Parse("2025-05-01"), AvaibleTickets = 20  },
            new Concert() { ConcertId = 3, Name = "Completed", Date = DateTime.Parse("2025-05-01"), AvaibleTickets = 20  },
        });
        
        modelBuilder.Entity<Customer>().HasData(new List<Customer>()
        {
            new Customer() { CustomerId = 1, FirstName = "John", LastName = "Doe", PhoneNumber = "987123456"},
            new Customer() { CustomerId = 2, FirstName = "John", LastName = "Doe", PhoneNumber = "987123456"},
            new Customer() { CustomerId = 3, FirstName = "John", LastName = "Doe", PhoneNumber = "987123456"},
        });
        
        modelBuilder.Entity<TicketConcert>().HasData(new List<TicketConcert>()
        {
            new TicketConcert() { TicketConcertId = 1, TicketId = 1, ConcertID = 1, Price = 1200},
            new TicketConcert() { TicketConcertId = 2, TicketId = 2, ConcertID = 2, Price = 300},
            new TicketConcert() { TicketConcertId = 3, TicketId = 3, ConcertID = 3, Price = 2300},
        });
        
        modelBuilder.Entity<PurchasedTickets>().HasData(new List<PurchasedTickets>()
        {
            new PurchasedTickets() { TicketConcertId = 1, CustomerId = 1, PurchaseDate = DateTime.Parse("2024-05-01")},
            new PurchasedTickets() { TicketConcertId = 2, CustomerId = 1, PurchaseDate = DateTime.Parse("2023-05-01")},
            new PurchasedTickets() { TicketConcertId = 3, CustomerId = 1, PurchaseDate = DateTime.Parse("2022-05-01")},
        });
    }
}
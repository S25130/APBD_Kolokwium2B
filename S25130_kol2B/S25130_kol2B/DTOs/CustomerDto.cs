namespace S25130_kol2B.DTOs;

public class CustomerDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; } = null;
    public List<PurchasedTicketDto> Purchases { get; set; } = null!;
}

public class PurchasedTicketDto
{
    public DateTime PurchaseDate { get; set; }
    public double Price { get; set; }
    public TicketConcertDto Ticket { get; set; } = null!;
    public ConcertDto Concert { get; set; } = null!;


}
public class TicketConcertDto
{
    public string SerialNumber { get; set; } = null!;
    public string SeatNumber { get; set; } = null!;
}

public class ConcertDto
{
    public string Name { get; set; } = null!;
    public DateTime Date { get; set; }
}
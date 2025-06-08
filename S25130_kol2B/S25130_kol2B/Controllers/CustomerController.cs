using S25130_kol2B.DTOs;
using S25130_kol2B.Exceptions;
using S25130_kol2B;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace S25130_kol2B.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomerController : ControllerBase
{
    private readonly IDbService _dbService;

    public OrdersController(IDbService dbService)
    {
        _dbService = dbService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetOrder(int id)
    {
        try
        {
            var order = await _dbService.GetOrderById(id);
            return Ok(order);
        }
        catch (NotFoundException e)
        {
            return NotFound();
        }
    }
}
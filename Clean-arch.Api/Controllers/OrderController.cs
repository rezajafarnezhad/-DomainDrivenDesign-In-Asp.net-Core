using Clean_arch.Application.Order.OrderService;
using Microsoft.AspNetCore.Mvc;

namespace Clean_arch.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly IOrderService _orderService;

    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet]
    public IActionResult GetOrders()
    {
        return Ok(_orderService.GetOrders());
    }
}
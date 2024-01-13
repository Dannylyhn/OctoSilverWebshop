using Microsoft.AspNetCore.Mvc;

namespace Store.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ItemController : ControllerBase
{
    public ItemController()
    {
        
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetItem(int id)
    {
        
        return Ok("Hello world");
    }
    
    [HttpGet]
    public async Task<IActionResult> GetItems(int id)
    {
        
        return Ok("All items");
    }

    [HttpDelete("{id}")]
    public async Task DeleteItem()
    {
        
    }
    
    
}
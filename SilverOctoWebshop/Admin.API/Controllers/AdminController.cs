using Microsoft.AspNetCore.Mvc;

namespace Admin.API;

[Route("api/[controller]")]
[ApiController]
public class AdminController : ControllerBase
{

    public AdminController(){
        
    }

    [HttpGet("Item/{id}")]
    public async Task<IActionResult> GetItem(int id)
    {
        
        return Ok("Hello world");
    }

    [HttpPost("Item/{id}")]
    public async Task<IActionResult> AddItem(int id)
    {
        Guid guid = new Guid();
        

        return Ok("Hello world");
    }

    [HttpDelete("Item/{id}")]
    public async Task<IActionResult> DeleteItem(int id)
    {
        
        return Ok("Hello world");
    }

}

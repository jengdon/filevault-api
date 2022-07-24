namespace FileVault.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    [HttpGet]
    public IEnumerable<string> List() => new List<string>();
}

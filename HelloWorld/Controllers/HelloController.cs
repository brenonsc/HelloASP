using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers;

[Route("~/")]
[ApiController]
public class HelloController
{
    [HttpGet]
    public string Hello()
    {
        return "Hello ASP.NET!";
    }
}
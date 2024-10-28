using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace CuzinhadoGallo.Controllers;

[Authorize(Roles = "Administrador")]
public class AdminController 
{
    private readonly ILogger<AdminController> _logger;

    public AdminController(ILogger<AdminController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    private IActionResult View()
    {
        throw new NotImplementedException();
    }

    private IActionResult View(string v)
    {
        throw new NotImplementedException();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult error()
    {
        return View("Error!")
    }
}
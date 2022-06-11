using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Temp.Models;

namespace Temp.Controllers;

public class HelloController : Controller
{
    private readonly ILogger<HelloController> _logger;

    public HelloController(ILogger<HelloController> logger)
    {
        _logger = logger;
    }

    // GET: /Hello/name
    public string Hello(string name)
    {
        return $"Hello, {name}!";
    }
}
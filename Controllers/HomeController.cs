using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LoginRegistration.Models;
namespace LoginRegistration.Controllers;

public class HomeController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return View("Index");
    }

    [HttpPost("register")]
    public IActionResult RegisterUser(IndexViewModel modelData)
    {
        Register? submitUser = modelData.NewUser;
        if (ModelState.IsValid)
        {
            return RedirectToAction("Successful");
        }
        else {
            Console.WriteLine("ModelState Invalid");
        }
        return Index();
    }

    [HttpPost("login")]
    public IActionResult LogInUser(IndexViewModel modelData)
    {
        SignIn? submitUser = modelData.ReturningUser;
        // Console.WriteLine(submitUser.Email);
        // Console.WriteLine(submitUser.Pw);
        if (ModelState.IsValid)
        {
            return RedirectToAction("Successful");
        } else {
            Console.WriteLine("ModelState Invalid");
        }
        return Index();
    }

    [HttpGet("success")]
    public ViewResult Successful()
    {
        return View("Success");
    }
    
}

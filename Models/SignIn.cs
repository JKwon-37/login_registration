#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace LoginRegistration.Models;
public class SignIn
{
    [Required(ErrorMessage = " is required!")]
    public string Email {get;set;}
    [Required(ErrorMessage = " is required!")]
    public string Pw {get;set;}
}
#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace LoginRegistration.Models;
public class Register
{
    [Required(ErrorMessage = " is required!")]
    [MinLength(2, ErrorMessage = " must be at least 2 characters long!")]
    public string FirstName {get;set;}

    [Required(ErrorMessage = " is required!")]
    [MinLength(2, ErrorMessage = " must be at least 2 characters long!")]
    public string LastName {get;set;}

    [Required(ErrorMessage = " is required!")]
    [EmailAddress(ErrorMessage = " must be an email address!")]
    public string Email {get;set;}

    [Required(ErrorMessage = " is required!")]
    [MinLength(8, ErrorMessage = " must be at least 8 characters long!")]
    public string Pw {get;set;}

    [Required(ErrorMessage = " is required!")]
    [Compare("Pw", ErrorMessage = " must be the same as password!")]
    public string ConfirmPw {get;set;}

}
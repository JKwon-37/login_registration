#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using LoginRegistration.Models;
public class IndexViewModel
{
    public Register? NewUser {get;set;}
    public SignIn? ReturningUser {get;set;}
}


using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.DTOs;

public class AuthUserDto{
    [Required]
    public string Username {get;set;}
    [Required]

    public string Password {get;set;}
}
public class UserTokenDto{
    [MaxLength(256)]
    public string Username {get;set;}

    [MaxLength(256)]
    public string Token {get;set;}
}
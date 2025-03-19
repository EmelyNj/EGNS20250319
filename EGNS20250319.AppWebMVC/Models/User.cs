using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EGNS20250319.AppWebMVC.Models;

public partial class User
{
    [Display(Name = "ID de la Usuario")]
    public int UserId { get; set; }

    [Display(Name = "Nombre de Usuario")]
    public string Username { get; set; } = null!;

    [Display(Name = "Correo electrónico del Usuario")]
    public string Email { get; set; } = null!;

    [Display(Name = "Hash de la contraseña del Usuario")]
    public string PasswordHash { get; set; } = null!;

    [Display(Name = "Rol del Usuario")]
    public string Role { get; set; } = null!;
}

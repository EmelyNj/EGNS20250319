using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace EGNS20250319.AppWebMVC.Models;

public partial class User
{
    [Display(Name = "ID de la Usuario")]
    public int UserId { get; set; }

    [Required(ErrorMessage = "El dato es requerido.")]
    [Display(Name = "Nombre de Usuario")]
    public string Username { get; set; } = null!;

    [Required(ErrorMessage ="El dato es requerido.")]
    [EmailAddress(ErrorMessage = "El correo electrónico no tiene formato valido.")]
    [Display(Name = "Correo electrónico del Usuario")]
    public string Email { get; set; } = null!;

    [DataType(DataType.Password)]
    [Display(Name = "Hash de la contraseña del Usuario")]
    public string PasswordHash { get; set; } = null!;

    [Required(ErrorMessage = "El dato es requerido.")]
    [Display(Name = "Rol del Usuario")]

    public string Role { get; set; } = null!;
}

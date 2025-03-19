using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EGNS20250319.AppWebMVC.Models;

public partial class Category
{
    [Display(Name = "ID de la Categoría")]
    public int CategoryId { get; set; }

    [Display(Name = "Nombre de la Categoría")]
    public string CategoryName { get; set; } = null!;

    [Display(Name = "Descripción de la Categoría")]
    public string? Description { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}

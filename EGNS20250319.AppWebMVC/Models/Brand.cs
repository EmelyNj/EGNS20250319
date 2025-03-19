﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EGNS20250319.AppWebMVC.Models;

public partial class Brand
{
    [Display(Name ="ID de la Marca")]
    public int BrandId { get; set; }

    [Display(Name = "Nombre de la Marca")]
    public string BrandName { get; set; } = null!;

    [Display(Name = "País de origen de la marca")]
    public string? Country { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}

﻿using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace MVC_OneToMany.Models;

public class Category
{
    public int Id { get; set; }

    [MaxLength(16)]
    public string Name { get; set; }
    public IEnumerable<Product?> Products { get; set; }

}

using System;
using System.Collections.Generic;

namespace PizzariaMdS09.Models;

public partial class Sabore
{
    public int Id { get; set; }

    public string? Sabor { get; set; }

    public virtual ICollection<PizzaSabore> PizzaSabores { get; set; } = new List<PizzaSabore>();
}

using System;
using System.Collections.Generic;

namespace PizzariaMdS09.Models;

public partial class Bordum
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public virtual ICollection<Pizza> Pizzas { get; set; } = new List<Pizza>();
}

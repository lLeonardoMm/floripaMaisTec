using System;
using System.Collections.Generic;

namespace PizzariaMdS09.Models;

public partial class PizzaSabore
{
    public int Id { get; set; }

    public int? IdPizzas { get; set; }

    public int? IdSabores { get; set; }

    public virtual Pizza? IdPizzasNavigation { get; set; }

    public virtual Sabore? IdSaboresNavigation { get; set; }
}

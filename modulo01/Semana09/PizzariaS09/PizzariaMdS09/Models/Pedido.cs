using System;
using System.Collections.Generic;

namespace PizzariaMdS09.Models;

public partial class Pedido
{
    public int Id { get; set; }

    public int? IdStatus { get; set; }

    public int? IdPizzas { get; set; }

    public virtual Pizza? IdPizzasNavigation { get; set; }

    public virtual StatusDaPizza? IdStatusNavigation { get; set; }
}

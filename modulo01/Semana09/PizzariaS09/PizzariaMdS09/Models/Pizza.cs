using System;
using System.Collections.Generic;

namespace PizzariaMdS09.Models;

public partial class Pizza
{
    public int Id { get; set; }

    public int? IdMassas { get; set; }

    public int? IdBordas { get; set; }

    public virtual Bordum? IdBordasNavigation { get; set; }

    public virtual Massa? IdMassasNavigation { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public virtual ICollection<PizzaSabore> PizzaSabores { get; set; } = new List<PizzaSabore>();
}

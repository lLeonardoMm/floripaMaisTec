using System;
using System.Collections.Generic;

namespace PizzariaMdS09.Models;

public partial class StatusDaPizza
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}

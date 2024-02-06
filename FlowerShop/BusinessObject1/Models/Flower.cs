using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Flower
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Season { get; set; }

    public decimal? UnitPrice { get; set; }

    public string? Description { get; set; }

    public int? Stock { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}

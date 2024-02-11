using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Order
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public DateOnly? OrderedDate { get; set; }

    public DateOnly? ShippedDate { get; set; }

    public decimal? TotalPrice { get; set; }

    public string? PaymentMethod { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual User? User { get; set; }
}

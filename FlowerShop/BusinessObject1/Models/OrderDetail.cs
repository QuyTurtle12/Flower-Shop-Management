using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class OrderDetail
{
    public string OrderDetailId { get; set; } = null!;

    public string? OrderId { get; set; }

    public string? FlowerId { get; set; }

    public int? Amount { get; set; }

    public decimal? Price { get; set; }

    public virtual Flower? Flower { get; set; }

    public virtual Order? Order { get; set; }
}

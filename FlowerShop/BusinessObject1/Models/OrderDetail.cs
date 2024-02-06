using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class OrderDetail
{
    public int OrderDetailId { get; set; }

    public int? OrderId { get; set; }

    public int? FlowerId { get; set; }

    public int? Amount { get; set; }

    public decimal? Price { get; set; }

    public virtual Flower? Flower { get; set; }

    public virtual Order? Order { get; set; }
}

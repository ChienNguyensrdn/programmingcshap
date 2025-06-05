using System;
using System.Collections.Generic;

namespace MyStore.Business;

public partial class Order
{
    public int OrderId { get; set; }

    public int? MemberId { get; set; }

    public DateTime? OrderDate { get; set; }

    public decimal? TotalAmount { get; set; }

    public virtual AccountMember? Member { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}

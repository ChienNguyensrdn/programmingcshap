using System;
using System.Collections.Generic;

namespace MyStore.Business;

public partial class AccountMember
{
    public int MemberId { get; set; }

    public string MemberPassword { get; set; } = null!;

    public string? FullName { get; set; }

    public string? EmailAddress { get; set; }

    public string? MemberRole { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}

using System;
using System.Collections.Generic;

namespace Proj1BasicApp.Data;

public partial class CstTable
{
    public int CstId { get; set; }

    public string CstName { get; set; } = null!;

    public string CstAddress { get; set; } = null!;

    public DateTime? BillDate { get; set; }

    public decimal? BillAmount { get; set; }
}

using System;
using System.Collections.Generic;

namespace Proj1BasicApp.Data;

public partial class CustomerAudit
{
    public int Id { get; set; }

    public string Details { get; set; } = null!;
}

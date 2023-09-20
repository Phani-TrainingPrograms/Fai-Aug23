using System;
using System.Collections.Generic;

namespace Proj1BasicApp.Data;

public partial class DeptTable
{
    public int DeptId { get; set; }

    public string DeptName { get; set; } = null!;

    public virtual ICollection<Emptable> Emptables { get; set; } = new List<Emptable>();
}

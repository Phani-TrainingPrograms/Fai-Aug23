using System;
using System.Collections.Generic;

namespace Proj1BasicApp.Data;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal ProductPrice { get; set; }

    public string ProductImage { get; set; } = null!;

    public int StockCount { get; set; }
}

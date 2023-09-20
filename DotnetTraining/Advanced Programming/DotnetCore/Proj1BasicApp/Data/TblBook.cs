using System;
using System.Collections.Generic;

namespace Proj1BasicApp.Data;

public partial class TblBook
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public string Author { get; set; } = null!;

    public int Price { get; set; }
}

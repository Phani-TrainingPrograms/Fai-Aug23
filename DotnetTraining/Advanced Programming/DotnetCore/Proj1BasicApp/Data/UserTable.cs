using System;
using System.Collections.Generic;

namespace Proj1BasicApp.Data;

public partial class UserTable
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int? Otp { get; set; }

    public DateTime? Expiry { get; set; }
}

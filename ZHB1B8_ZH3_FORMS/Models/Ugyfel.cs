using System;
using System.Collections.Generic;

namespace ZHB1B8_ZH3_FORMS.Models;

public partial class Ugyfel
{
    public int Id { get; set; }

    public string Nev { get; set; } = null!;

    public string? Email { get; set; }

    public DateTime? RegDatum { get; set; }
}

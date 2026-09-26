using System;
using System.Collections.Generic;

namespace Vha2410900007_exam.Models;

public partial class VhaStudent
{
    public int Id { get; set; }

    public string VhaName { get; set; } = null!;

    public bool VhaGender { get; set; }

    public DateOnly? VhaBirthDay { get; set; }

    public string? VhaEmail { get; set; }

    public string? VhaPhone { get; set; }

    public bool VhaActive { get; set; }
}

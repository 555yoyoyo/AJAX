using System;
using System.Collections.Generic;

namespace TEST.Models;

public partial class SpotImage
{
    public int ImageId { get; set; }

    public int? SpotId { get; set; }

    public string? ImageTitle { get; set; }

    public string? ImagePath { get; set; }
}

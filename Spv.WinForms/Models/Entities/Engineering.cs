﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace Spv.WinForms.Models;

public partial class Engineering
{
    public Guid EngineeringId { get; set; }

    public string MaterialNb { get; set; } = null!;

    public double? UpperTolerance { get; set; }

    public double? LowerTolerance { get; set; }

    public string? Pressure { get; set; }

    public double? Vessel { get; set; }

    public double? Time { get; set; }

    public double? Q5baro { get; set; }

    public string? Remarks { get; set; }

    public string? Valvetype { get; set; }

    public int? Deleted { get; set; }
}
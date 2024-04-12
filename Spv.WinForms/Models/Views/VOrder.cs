﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace Spv.WinForms.Models;

public partial class VOrder
{
    public Guid OrderId { get; set; }

    public string OrderNb { get; set; } = null!;

    public int? OrderType { get; set; }

    public DateTime? OrderDate { get; set; }

    public int? OrderStateId { get; set; }

    public Guid Serialid { get; set; }

    public string? SerialNb { get; set; }

    public string? ValveType { get; set; }

    public string? Drawing { get; set; }

    public int? Type { get; set; }

    public string? MatNb { get; set; }

    public string? MatDesc { get; set; }

    public long? Id { get; set; }

    public double? P1 { get; set; }

    public double? P2 { get; set; }

    public double? Innerrate { get; set; }

    public double? Innertime { get; set; }

    public double? Outerrate { get; set; }

    public double? Outertime { get; set; }

    public double? Pressure { get; set; }

    public double? Vessel { get; set; }

    public double? Intern { get; set; }

    public string? UnitIntern { get; set; }

    public DateTime? DateInner { get; set; }

    public double? Extern { get; set; }

    public string? UnitExtern { get; set; }

    public DateTime? DateOuter { get; set; }

    public int? State { get; set; }

    public DateTime? Send2esm { get; set; }

    public int? Send2esmBy { get; set; }

    public int? Issend2esm { get; set; }

    public Guid? TestId { get; set; }

    public string? Q5 { get; set; }

    public string? Q5inner { get; set; }

    public string? Q5outer { get; set; }

    public string? PressureUnit { get; set; }

    public string? PressureP1 { get; set; }

    public string? PressureP2 { get; set; }

    public string? Volume { get; set; }

    public string? Time { get; set; }

    public int? Testtype { get; set; }

    public string? Nachname { get; set; }

    public string? Vorname { get; set; }

    public string? TimeUnit { get; set; }
}
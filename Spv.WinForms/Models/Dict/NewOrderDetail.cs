﻿namespace Spv.WinForms.Models.Dict;

internal class NewOrderDetail
{
    public int npp { get; set; }
    public string Serialnb { get; set; } = string.Empty;
    public string ValveType { get; set; } = string.Empty;
    public string Drawing { get; set; } = string.Empty;
    public int? TypeParam { get; set; }
    public string MatNb { get; set; } = string.Empty;
    public string MatDesc { get; set; } = string.Empty;
    public long? Id { get; set; }
    public float? p1 { get; set; }
    public float? p2 { get; set; }
    public double? innerrate { get; set; }
    public double? innertime { get; set; }
    public double? outerrate { get; set; }
    public double? outertime { get; set; }
    public double? pressure { get; set; }
    public double? vessel { get; set; }
    public double? ValueInner { get; set; }
    public double? ValueOuter { get; set; }
}

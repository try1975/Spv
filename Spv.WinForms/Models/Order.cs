﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace Spv.WinForms.Models;

public partial class Order
{
    public Guid OrderId { get; set; }

    public string OrderNb { get; set; } = null!;

    public int? OrderType { get; set; }

    public DateTime? OrderDate { get; set; }

    public int? OrderStateId { get; set; }

    public DateTime? Opened { get; set; }

    public int? OpenedBy { get; set; }

    public DateTime? Closed { get; set; }

    public int? ClosedBy { get; set; }

    public DateTime? Created { get; set; }

    public int? CreatedBy { get; set; }

    public int? Isdeleted { get; set; }

    public DateTime? Deleted { get; set; }

    public int? DeletedBy { get; set; }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spv.WinForms.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace Spv.WinForms.Models.Configurations
{
    public partial class VOrderConfiguration : IEntityTypeConfiguration<VOrder>
    {
        public void Configure(EntityTypeBuilder<VOrder> entity)
        {
            entity
                .HasNoKey()
                .ToView("v_order");

            entity.Property(e => e.DateInner).HasColumnType("datetime");
            entity.Property(e => e.DateOuter).HasColumnType("datetime");
            entity.Property(e => e.Drawing).HasMaxLength(50);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Innerrate).HasColumnName("innerrate");
            entity.Property(e => e.Innertime).HasColumnName("innertime");
            entity.Property(e => e.Issend2esm).HasColumnName("issend2esm");
            entity.Property(e => e.MatDesc).HasMaxLength(255);
            entity.Property(e => e.MatNb).HasMaxLength(20);
            entity.Property(e => e.Nachname)
                .HasMaxLength(50)
                .HasColumnName("nachname");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.OrderNb).HasMaxLength(20);
            entity.Property(e => e.OrderStateId).HasColumnName("OrderStateID");
            entity.Property(e => e.Outerrate).HasColumnName("outerrate");
            entity.Property(e => e.Outertime).HasColumnName("outertime");
            entity.Property(e => e.Pressure).HasColumnName("pressure");
            entity.Property(e => e.PressureP1).HasMaxLength(20);
            entity.Property(e => e.PressureP2).HasMaxLength(20);
            entity.Property(e => e.PressureUnit).HasMaxLength(20);
            entity.Property(e => e.Q5).HasMaxLength(20);
            entity.Property(e => e.Q5inner).HasMaxLength(20);
            entity.Property(e => e.Q5outer).HasMaxLength(20);
            entity.Property(e => e.Send2esm)
                .HasColumnType("datetime")
                .HasColumnName("send2esm");
            entity.Property(e => e.Send2esmBy).HasColumnName("send2esm_by");
            entity.Property(e => e.SerialNb).HasMaxLength(20);
            entity.Property(e => e.Serialid).HasColumnName("serialid");
            entity.Property(e => e.TestId).HasColumnName("TestID");
            entity.Property(e => e.Testtype).HasColumnName("testtype");
            entity.Property(e => e.Time).HasMaxLength(20);
            entity.Property(e => e.TimeUnit).HasMaxLength(20);
            entity.Property(e => e.UnitExtern).HasMaxLength(20);
            entity.Property(e => e.UnitIntern).HasMaxLength(20);
            entity.Property(e => e.ValveType).HasMaxLength(20);
            entity.Property(e => e.Vessel).HasColumnName("vessel");
            entity.Property(e => e.Volume).HasMaxLength(20);
            entity.Property(e => e.Vorname)
                .HasMaxLength(50)
                .HasColumnName("vorname");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VOrder> entity);
    }
}

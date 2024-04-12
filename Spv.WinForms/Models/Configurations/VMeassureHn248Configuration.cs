﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spv.WinForms.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace Spv.WinForms.Models.Configurations
{
    public partial class VMeassureHn248Configuration : IEntityTypeConfiguration<VMeassureHn248>
    {
        public void Configure(EntityTypeBuilder<VMeassureHn248> entity)
        {
            entity
                .HasNoKey()
                .ToView("v_meassure_hn248");

            entity.Property(e => e.Drawing).HasMaxLength(50);
            entity.Property(e => e.MatNb).HasMaxLength(20);
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.OrderNb).HasMaxLength(20);
            entity.Property(e => e.OrderStateId).HasColumnName("OrderStateID");
            entity.Property(e => e.Serialid).HasColumnName("serialid");
            entity.Property(e => e.Serialnb)
                .HasMaxLength(20)
                .HasColumnName("serialnb");
            entity.Property(e => e.TestId).HasColumnName("TestID");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.ValveType).HasMaxLength(20);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VMeassureHn248> entity);
    }
}

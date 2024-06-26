﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spv.WinForms.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace Spv.WinForms.Models.Configurations
{
    public partial class VSelftestConfiguration : IEntityTypeConfiguration<VSelftest>
    {
        public void Configure(EntityTypeBuilder<VSelftest> entity)
        {
            entity
                .HasNoKey()
                .ToView("v_selftest");

            entity.Property(e => e.DebitValueUnit).HasMaxLength(20);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.FlowValueUnit).HasMaxLength(20);
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Meassuredate)
                .HasColumnType("datetime")
                .HasColumnName("meassuredate");
            entity.Property(e => e.P1calc).HasColumnName("P1Calc");
            entity.Property(e => e.P2calc).HasColumnName("P2Calc");
            entity.Property(e => e.Pressure).HasMaxLength(20);
            entity.Property(e => e.PressureP1).HasMaxLength(20);
            entity.Property(e => e.PressureP2).HasMaxLength(20);
            entity.Property(e => e.Q5).HasMaxLength(20);
            entity.Property(e => e.Q5calc).HasColumnName("Q5Calc");
            entity.Property(e => e.Q5inner).HasMaxLength(20);
            entity.Property(e => e.Q5innerCalc).HasColumnName("Q5InnerCalc");
            entity.Property(e => e.Q5outer).HasMaxLength(20);
            entity.Property(e => e.Q5outerCalc).HasColumnName("Q5OuterCalc");
            entity.Property(e => e.SelfTestDate).HasColumnType("datetime");
            entity.Property(e => e.TestedBy).HasMaxLength(50);
            entity.Property(e => e.Time).HasMaxLength(20);
            entity.Property(e => e.Volume).HasMaxLength(20);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VSelftest> entity);
    }
}

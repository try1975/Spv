﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spv.WinForms.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace Spv.WinForms.Models.Configurations
{
    public partial class VLimitConfiguration : IEntityTypeConfiguration<VLimit>
    {
        public void Configure(EntityTypeBuilder<VLimit> entity)
        {
            entity
                .HasNoKey()
                .ToView("v_limits");

            entity.Property(e => e.Drawing)
                .HasMaxLength(50)
                .HasColumnName("drawing");
            entity.Property(e => e.EngineeringId).HasColumnName("engineeringID");
            entity.Property(e => e.Innerrate).HasColumnName("innerrate");
            entity.Property(e => e.Innertime).HasColumnName("innertime");
            entity.Property(e => e.Konz).HasColumnName("konz");
            entity.Property(e => e.LowerTolerance).HasColumnName("lower_tolerance");
            entity.Property(e => e.Outerrate).HasColumnName("outerrate");
            entity.Property(e => e.Outertime).HasColumnName("outertime");
            entity.Property(e => e.Remarks)
                .HasMaxLength(2048)
                .HasColumnName("remarks");
            entity.Property(e => e.Testpressure).HasColumnName("testpressure");
            entity.Property(e => e.UpperTolerance).HasColumnName("upper_tolerance");
            entity.Property(e => e.Valvetype)
                .HasMaxLength(50)
                .HasColumnName("valvetype");
            entity.Property(e => e.Vessel).HasColumnName("vessel");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VLimit> entity);
    }
}

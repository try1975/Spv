﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spv.WinForms.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace Spv.WinForms.Models.Configurations
{
    public partial class Engineeringhn248Configuration : IEntityTypeConfiguration<Engineeringhn248>
    {
        public void Configure(EntityTypeBuilder<Engineeringhn248> entity)
        {
            entity.HasKey(e => e.EngineeringId).HasName("PK_engineeringh248");

            entity.ToTable("engineeringhn248");

            entity.Property(e => e.EngineeringId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("engineeringID");
            entity.Property(e => e.Deleted)
                .HasDefaultValue(0)
                .HasColumnName("deleted");
            entity.Property(e => e.LowerTolerance).HasColumnName("lower_tolerance");
            entity.Property(e => e.MaterialNb)
                .HasMaxLength(50)
                .HasColumnName("materialNb");
            entity.Property(e => e.Pressure)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("pressure");
            entity.Property(e => e.Remarks)
                .HasMaxLength(2048)
                .HasColumnName("remarks");
            entity.Property(e => e.Time).HasColumnName("time");
            entity.Property(e => e.UpperTolerance).HasColumnName("upper_tolerance");
            entity.Property(e => e.Valvetype)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))")
                .HasColumnName("valvetype");
            entity.Property(e => e.Vessel).HasColumnName("vessel");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Engineeringhn248> entity);
    }
}
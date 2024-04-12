﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spv.WinForms.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace Spv.WinForms.Models.Configurations
{
    public partial class Hn248Configuration : IEntityTypeConfiguration<Hn248>
    {
        public void Configure(EntityTypeBuilder<Hn248> entity)
        {
            entity
                .HasNoKey()
                .ToTable("hn248");

            entity.Property(e => e.Bemerkungen).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(255)
                .HasColumnName("modifiedBy");
            entity.Property(e => e.Pressure).HasMaxLength(10);
            entity.Property(e => e.ValveType).HasMaxLength(50);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Hn248> entity);
    }
}

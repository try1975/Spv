﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spv.WinForms.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace Spv.WinForms.Models.Configurations
{
    public partial class PruefstatiConfiguration : IEntityTypeConfiguration<Pruefstati>
    {
        public void Configure(EntityTypeBuilder<Pruefstati> entity)
        {
            entity.HasKey(e => e.Pruefstatusid);

            entity.ToTable("pruefstati");

            entity.Property(e => e.Pruefstatusid)
                .ValueGeneratedNever()
                .HasColumnName("pruefstatusid");
            entity.Property(e => e.Pruefstatus)
                .HasMaxLength(50)
                .HasColumnName("pruefstatus");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Pruefstati> entity);
    }
}
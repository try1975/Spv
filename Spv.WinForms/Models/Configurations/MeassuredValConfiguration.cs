﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spv.WinForms.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace Spv.WinForms.Models.Configurations
{
    public partial class MeassuredValConfiguration : IEntityTypeConfiguration<MeassuredVal>
    {
        public void Configure(EntityTypeBuilder<MeassuredVal> entity)
        {
            entity
                .HasNoKey()
                .ToTable("meassured_val");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mdate)
                .HasColumnType("datetime")
                .HasColumnName("mdate");
            entity.Property(e => e.MeassureDate).HasColumnType("datetime");
            entity.Property(e => e.Mtime).HasColumnName("MTime");
            entity.Property(e => e.Mvalue).HasColumnName("MValue");
            entity.Property(e => e.TestId).HasColumnName("TestID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<MeassuredVal> entity);
    }
}

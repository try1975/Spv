﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spv.WinForms.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace Spv.WinForms.Models.Configurations
{
    public partial class SelftestDetailConfiguration : IEntityTypeConfiguration<SelftestDetail>
    {
        public void Configure(EntityTypeBuilder<SelftestDetail> entity)
        {
            entity
                .HasNoKey()
                .ToTable("selftest_detail");

            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.SelfTestDate).HasColumnType("datetime");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SelftestDetail> entity);
    }
}

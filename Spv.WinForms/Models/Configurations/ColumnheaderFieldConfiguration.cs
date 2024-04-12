﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spv.WinForms.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace Spv.WinForms.Models.Configurations
{
    public partial class ColumnheaderFieldConfiguration : IEntityTypeConfiguration<ColumnheaderField>
    {
        public void Configure(EntityTypeBuilder<ColumnheaderField> entity)
        {
            entity.HasKey(e => e.Fieldname);

            entity.ToTable("columnheader_fields");

            entity.Property(e => e.Fieldname)
                .HasMaxLength(255)
                .HasColumnName("fieldname");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ColumnheaderField> entity);
    }
}
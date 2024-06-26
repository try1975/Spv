﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spv.WinForms.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace Spv.WinForms.Models.Configurations
{
    public partial class FileConfiguration : IEntityTypeConfiguration<File>
    {
        public void Configure(EntityTypeBuilder<File> entity)
        {
            entity.HasKey(e => e.Filename);

            entity.ToTable("files");

            entity.Property(e => e.Filename)
                .HasMaxLength(255)
                .HasColumnName("filename");
            entity.Property(e => e.Datum)
                .HasColumnType("datetime")
                .HasColumnName("datum");
            entity.Property(e => e.Filedate)
                .HasColumnType("datetime")
                .HasColumnName("filedate");
            entity.Property(e => e.Filepath)
                .HasMaxLength(512)
                .HasColumnName("filepath");
            entity.Property(e => e.Filesize).HasColumnName("filesize");
            entity.Property(e => e.Queueindex).HasColumnName("queueindex");
            entity.Property(e => e.Userid).HasColumnName("userid");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<File> entity);
    }
}

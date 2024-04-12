﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spv.WinForms.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace Spv.WinForms.Models.Configurations
{
    public partial class UserSettingConfiguration : IEntityTypeConfiguration<UserSetting>
    {
        public void Configure(EntityTypeBuilder<UserSetting> entity)
        {
            entity
                .HasNoKey()
                .ToTable("user_settings");

            entity.Property(e => e.Keystr)
                .HasMaxLength(255)
                .HasColumnName("keystr");
            entity.Property(e => e.Keyvalue)
                .HasMaxLength(4000)
                .HasColumnName("keyvalue");
            entity.Property(e => e.Userid).HasColumnName("userid");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<UserSetting> entity);
    }
}

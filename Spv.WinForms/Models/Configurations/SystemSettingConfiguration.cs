﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spv.WinForms.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace Spv.WinForms.Models.Configurations
{
    public partial class SystemSettingConfiguration : IEntityTypeConfiguration<SystemSetting>
    {
        public void Configure(EntityTypeBuilder<SystemSetting> entity)
        {
            entity
                .HasNoKey()
                .ToTable("system_settings");

            entity.Property(e => e.SysAutomaticMeassure).HasColumnName("sysAutomaticMeassure");
            entity.Property(e => e.SysEngImportPath)
                .HasMaxLength(255)
                .HasColumnName("sysEngImportPath");
            entity.Property(e => e.SysHasSapinterface).HasColumnName("sysHasSAPInterface");
            entity.Property(e => e.SysHasWebService).HasColumnName("sysHasWebService");
            entity.Property(e => e.SysIsStandalone).HasColumnName("sysIsStandalone");
            entity.Property(e => e.SysRelPressureTimeout).HasColumnName("sysRelPressureTimeout");
            entity.Property(e => e.SysSelfTest).HasColumnName("sysSelfTest");
            entity.Property(e => e.SysSwupdateLink)
                .HasMaxLength(255)
                .HasColumnName("sysSWUpdateLink");
            entity.Property(e => e.SysWaitForUserResponse).HasColumnName("sysWaitForUserResponse");
            entity.Property(e => e.SysWebserviceLink)
                .HasMaxLength(255)
                .HasColumnName("sysWebserviceLink");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SystemSetting> entity);
    }
}
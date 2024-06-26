﻿using Microsoft.EntityFrameworkCore;

namespace Spv.WinForms.Models;

public partial class SpvContext : DbContext
{
    public SpvContext(DbContextOptions<SpvContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("name = ConnectionStrings:spv");

    public virtual DbSet<Auftragsstati> Auftragsstatis { get; set; }

    public virtual DbSet<Bench> Benches { get; set; }

    public virtual DbSet<Columnheader> Columnheaders { get; set; }

    public virtual DbSet<ColumnheaderField> ColumnheaderFields { get; set; }

    public virtual DbSet<Dbversion> Dbversions { get; set; }

    public virtual DbSet<DefaultSetting> DefaultSettings { get; set; }

    public virtual DbSet<Engineering> Engineerings { get; set; }

    public virtual DbSet<Engineeringhn248> Engineeringhn248s { get; set; }

    public virtual DbSet<Engineeringhn248konz> Engineeringhn248konzs { get; set; }

    public virtual DbSet<File> Files { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<GroupsModule> GroupsModules { get; set; }

    public virtual DbSet<Hn248> Hn248s { get; set; }

    public virtual DbSet<Hn248konz> Hn248konzs { get; set; }

    public virtual DbSet<Meassure> Meassures { get; set; }

    public virtual DbSet<MeassuredVal> MeassuredVals { get; set; }

    public virtual DbSet<Module> Modules { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrdersDetail> OrdersDetails { get; set; }

    public virtual DbSet<PruefLock> PruefLocks { get; set; }

    public virtual DbSet<Pruefauftraege> Pruefauftraeges { get; set; }

    public virtual DbSet<PruefauftraegeStati> PruefauftraegeStatis { get; set; }

    public virtual DbSet<Pruefstati> Pruefstatis { get; set; }

    public virtual DbSet<Selftest> Selftests { get; set; }

    public virtual DbSet<SelftestDetail> SelftestDetails { get; set; }

    public virtual DbSet<Setting> Settings { get; set; }

    public virtual DbSet<SystemSetting> SystemSettings { get; set; }

    public virtual DbSet<Testtypen> Testtypens { get; set; }

    public virtual DbSet<Unit> Units { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserGroup> UserGroups { get; set; }

    public virtual DbSet<UserSetting> UserSettings { get; set; }

    public virtual DbSet<VColumnheader> VColumnheaders { get; set; }

    public virtual DbSet<VGroupmember> VGroupmembers { get; set; }

    public virtual DbSet<VLimit> VLimits { get; set; }

    public virtual DbSet<VMeassure> VMeassures { get; set; }

    public virtual DbSet<VMeassureHn248> VMeassureHn248s { get; set; }

    public virtual DbSet<VMeassureHn248konz> VMeassureHn248konzs { get; set; }

    public virtual DbSet<VMeassuredVal> VMeassuredVals { get; set; }

    public virtual DbSet<VMemberof> VMemberofs { get; set; }

    public virtual DbSet<VMemberright> VMemberrights { get; set; }

    public virtual DbSet<VOrder> VOrders { get; set; }

    public virtual DbSet<VSelftest> VSelftests { get; set; }

    public virtual DbSet<VTestsPerTestid> VTestsPerTestids { get; set; }

    public virtual DbSet<VUnitcalc> VUnitcalcs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new Configurations.AuftragsstatiConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.BenchConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ColumnheaderConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ColumnheaderFieldConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.DbversionConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.DefaultSettingConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.EngineeringConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.Engineeringhn248Configuration());
        modelBuilder.ApplyConfiguration(new Configurations.Engineeringhn248konzConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.FileConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.GroupConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.GroupsModuleConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.Hn248Configuration());
        modelBuilder.ApplyConfiguration(new Configurations.Hn248konzConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.MeassureConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.MeassuredValConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ModuleConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.OrderConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.OrdersDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.PruefLockConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.PruefauftraegeConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.PruefauftraegeStatiConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.PruefstatiConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SelftestConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SelftestDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SettingConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SystemSettingConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.TesttypenConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.UnitConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.UserConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.UserGroupConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.UserSettingConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VColumnheaderConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VGroupmemberConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VLimitConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VMeassureConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VMeassureHn248Configuration());
        modelBuilder.ApplyConfiguration(new Configurations.VMeassureHn248konzConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VMeassuredValConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VMemberofConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VMemberrightConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VOrderConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VSelftestConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VTestsPerTestidConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VUnitcalcConfiguration());

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

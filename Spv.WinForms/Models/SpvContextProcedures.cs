using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Spv.WinForms.Models;

public partial class SpvContext
{
    private ISpvContextProcedures _procedures;

    public virtual ISpvContextProcedures Procedures
    {
        get
        {
            if (_procedures is null) _procedures = new SpvContextProcedures(this);
            return _procedures;
        }
        set
        {
            _procedures = value;
        }
    }

    public ISpvContextProcedures GetProcedures()
    {
        return Procedures;
    }
}

public partial class SpvContextProcedures : ISpvContextProcedures
{
    private readonly SpvContext _context;

    public SpvContextProcedures(SpvContext context)
    {
        _context = context;
    }

    public virtual async Task<int> BenchAddAsync(string pruefstand, string standort, int? zugeordnet, string pcname, int? baud, int? datenbits, int? stopbit, string parity, int? comnb, int? test, int? roundcnt, double? lowerp0, double? lowerp1, double? lowerp2, double? upperp0, double? upperp1, double? upperp2, double? nominalflow0, double? nominalflow1, double? nominalflow2, double? selftesttolerance, double? uptprelativ, double? lotprelativ, double? vesselfactor, double? ctrfactor, double? initdeltat, double? delayclosing, OutputParameter<int?> prid, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
    {
        var parameterprid = new SqlParameter
        {
            ParameterName = "prid",
            Direction = System.Data.ParameterDirection.InputOutput,
            Value = prid?._value ?? Convert.DBNull,
            SqlDbType = System.Data.SqlDbType.Int,
        };
        var parameterreturnValue = new SqlParameter
        {
            ParameterName = "returnValue",
            Direction = System.Data.ParameterDirection.Output,
            SqlDbType = System.Data.SqlDbType.Int,
        };

        var sqlParameters = new[]
        {
            parameterprid,
            new SqlParameter
            {
                ParameterName = "pruefstand",
                Size = 100,
                Value = pruefstand ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "standort",
                Size = 100,
                Value = standort ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "zugeordnet",
                Value = zugeordnet ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "pcname",
                Size = 510,
                Value = pcname ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "baud",
                Value = baud ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "datenbits",
                Value = datenbits ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "stopbit",
                Value = stopbit ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "parity",
                Size = 20,
                Value = parity ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "comnb",
                Value = comnb ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "test",
                Value = test ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "roundcnt",
                Value = roundcnt ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "lowerp0",
                Value = lowerp0 ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "lowerp1",
                Value = lowerp1 ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "lowerp2",
                Value = lowerp2 ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "upperp0",
                Value = upperp0 ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "upperp1",
                Value = upperp1 ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "upperp2",
                Value = upperp2 ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "nominalflow0",
                Value = nominalflow0 ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "nominalflow1",
                Value = nominalflow1 ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "nominalflow2",
                Value = nominalflow2 ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "selftesttolerance",
                Value = selftesttolerance ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "uptprelativ",
                Value = uptprelativ ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "lotprelativ",
                Value = lotprelativ ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "vesselfactor",
                Value = vesselfactor ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "ctrfactor",
                Value = ctrfactor ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "initdeltat",
                Value = initdeltat ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "delayclosing",
                Value = delayclosing ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            parameterreturnValue,
        };
        var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[BenchAdd] @prid OUTPUT, @pruefstand, @standort, @zugeordnet, @pcname, @baud, @datenbits, @stopbit, @parity, @comnb, @test, @roundcnt, @lowerp0, @lowerp1, @lowerp2, @upperp0, @upperp1, @upperp2, @nominalflow0, @nominalflow1, @nominalflow2, @selftesttolerance, @uptprelativ, @lotprelativ, @vesselfactor, @ctrfactor, @initdeltat, @delayclosing", sqlParameters, cancellationToken);

        prid.SetValue(parameterprid.Value);
        returnValue?.SetValue(parameterreturnValue.Value);

        return _;
    }

    public virtual async Task<int> BenchUpdAsync(int? prid, string pruefstand, string standort, int? zugeordnet, string pcname, int? baud, int? datenbits, int? stopbit, string parity, int? comnb, int? test, int? roundcnt, double? lowerp0, double? lowerp1, double? lowerp2, double? upperp0, double? upperp1, double? upperp2, double? nominalflow0, double? nominalflow1, double? nominalflow2, double? selftesttolerance, double? uptprelativ, double? lotprelativ, double? vesselfactor, double? ctrfactor, double? initdeltat, double? delayclosing, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
    {
        var parameterreturnValue = new SqlParameter
        {
            ParameterName = "returnValue",
            Direction = System.Data.ParameterDirection.Output,
            SqlDbType = System.Data.SqlDbType.Int,
        };

        var sqlParameters = new[]
        {
            new SqlParameter
            {
                ParameterName = "prid",
                Value = prid ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "pruefstand",
                Size = 100,
                Value = pruefstand ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "standort",
                Size = 100,
                Value = standort ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "zugeordnet",
                Value = zugeordnet ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "pcname",
                Size = 510,
                Value = pcname ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "baud",
                Value = baud ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "datenbits",
                Value = datenbits ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "stopbit",
                Value = stopbit ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "parity",
                Size = 20,
                Value = parity ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "comnb",
                Value = comnb ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "test",
                Value = test ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "roundcnt",
                Value = roundcnt ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "lowerp0",
                Value = lowerp0 ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "lowerp1",
                Value = lowerp1 ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "lowerp2",
                Value = lowerp2 ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "upperp0",
                Value = upperp0 ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "upperp1",
                Value = upperp1 ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "upperp2",
                Value = upperp2 ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "nominalflow0",
                Value = nominalflow0 ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "nominalflow1",
                Value = nominalflow1 ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "nominalflow2",
                Value = nominalflow2 ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "selftesttolerance",
                Value = selftesttolerance ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "uptprelativ",
                Value = uptprelativ ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "lotprelativ",
                Value = lotprelativ ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "vesselfactor",
                Value = vesselfactor ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "ctrfactor",
                Value = ctrfactor ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "initdeltat",
                Value = initdeltat ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "delayclosing",
                Value = delayclosing ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            parameterreturnValue,
        };
        var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[BenchUpd] @prid, @pruefstand, @standort, @zugeordnet, @pcname, @baud, @datenbits, @stopbit, @parity, @comnb, @test, @roundcnt, @lowerp0, @lowerp1, @lowerp2, @upperp0, @upperp1, @upperp2, @nominalflow0, @nominalflow1, @nominalflow2, @selftesttolerance, @uptprelativ, @lotprelativ, @vesselfactor, @ctrfactor, @initdeltat, @delayclosing", sqlParameters, cancellationToken);

        returnValue?.SetValue(parameterreturnValue.Value);

        return _;
    }

    public virtual async Task<int> ChangePressureAsync(string fertnr, double? popen, double? pmax, double? pmin, int? userid, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
    {
        var parameterreturnValue = new SqlParameter
        {
            ParameterName = "returnValue",
            Direction = System.Data.ParameterDirection.Output,
            SqlDbType = System.Data.SqlDbType.Int,
        };

        var sqlParameters = new[]
        {
            new SqlParameter
            {
                ParameterName = "fertnr",
                Size = 24,
                Value = fertnr ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "popen",
                Value = popen ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "pmax",
                Value = pmax ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "pmin",
                Value = pmin ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "userid",
                Value = userid ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            parameterreturnValue,
        };
        var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[ChangePressure] @fertnr, @popen, @pmax, @pmin, @userid", sqlParameters, cancellationToken);

        returnValue?.SetValue(parameterreturnValue.Value);

        return _;
    }

    public virtual async Task<int> ClosePruefungAsync(string fertnr, string srnr, int? auftragstypeid, int? prid, double? pdruck, int? userid, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
    {
        var parameterreturnValue = new SqlParameter
        {
            ParameterName = "returnValue",
            Direction = System.Data.ParameterDirection.Output,
            SqlDbType = System.Data.SqlDbType.Int,
        };

        var sqlParameters = new[]
        {
            new SqlParameter
            {
                ParameterName = "fertnr",
                Size = 24,
                Value = fertnr ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "srnr",
                Size = 40,
                Value = srnr ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "auftragstypeid",
                Value = auftragstypeid ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "prid",
                Value = prid ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "pdruck",
                Value = pdruck ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "userid",
                Value = userid ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            parameterreturnValue,
        };
        var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[ClosePruefung] @fertnr, @srnr, @auftragstypeid, @prid, @pdruck, @userid", sqlParameters, cancellationToken);

        returnValue?.SetValue(parameterreturnValue.Value);

        return _;
    }

    public virtual async Task<int> DefaultSettingsUPDAsync(string Q5, string Q5inner, string Q5outer, string Pressure, string PressureP1, string PressureP2, string Volume, string Time, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
    {
        var parameterreturnValue = new SqlParameter
        {
            ParameterName = "returnValue",
            Direction = System.Data.ParameterDirection.Output,
            SqlDbType = System.Data.SqlDbType.Int,
        };

        var sqlParameters = new[]
        {
            new SqlParameter
            {
                ParameterName = "Q5",
                Size = 40,
                Value = Q5 ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "Q5inner",
                Size = 40,
                Value = Q5inner ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "Q5outer",
                Size = 40,
                Value = Q5outer ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "Pressure",
                Size = 40,
                Value = Pressure ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "PressureP1",
                Size = 40,
                Value = PressureP1 ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "PressureP2",
                Size = 40,
                Value = PressureP2 ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "Volume",
                Size = 40,
                Value = Volume ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "Time",
                Size = 40,
                Value = Time ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            parameterreturnValue,
        };
        var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[DefaultSettingsUPD] @Q5, @Q5inner, @Q5outer, @Pressure, @PressureP1, @PressureP2, @Volume, @Time", sqlParameters, cancellationToken);

        returnValue?.SetValue(parameterreturnValue.Value);

        return _;
    }

    public virtual async Task<int> GroupAddAsync(string ngroup, string description, OutputParameter<int?> groupid, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
    {
        var parametergroupid = new SqlParameter
        {
            ParameterName = "groupid",
            Direction = System.Data.ParameterDirection.InputOutput,
            Value = groupid?._value ?? Convert.DBNull,
            SqlDbType = System.Data.SqlDbType.Int,
        };
        var parameterreturnValue = new SqlParameter
        {
            ParameterName = "returnValue",
            Direction = System.Data.ParameterDirection.Output,
            SqlDbType = System.Data.SqlDbType.Int,
        };

        var sqlParameters = new[]
        {
            parametergroupid,
            new SqlParameter
            {
                ParameterName = "ngroup",
                Size = 100,
                Value = ngroup ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "description",
                Size = 8000,
                Value = description ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            parameterreturnValue,
        };
        var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[GroupAdd] @groupid OUTPUT, @ngroup, @description", sqlParameters, cancellationToken);

        groupid.SetValue(parametergroupid.Value);
        returnValue?.SetValue(parameterreturnValue.Value);

        return _;
    }

    public virtual async Task<int> GroupAddRefAsync(int? userid, int? groupid, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
    {
        var parameterreturnValue = new SqlParameter
        {
            ParameterName = "returnValue",
            Direction = System.Data.ParameterDirection.Output,
            SqlDbType = System.Data.SqlDbType.Int,
        };

        var sqlParameters = new[]
        {
            new SqlParameter
            {
                ParameterName = "userid",
                Value = userid ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "groupid",
                Value = groupid ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            parameterreturnValue,
        };
        var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[GroupAddRef] @userid, @groupid", sqlParameters, cancellationToken);

        returnValue?.SetValue(parameterreturnValue.Value);

        return _;
    }

    public virtual async Task<int> GroupDelRefAsync(int? userid, int? groupid, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
    {
        var parameterreturnValue = new SqlParameter
        {
            ParameterName = "returnValue",
            Direction = System.Data.ParameterDirection.Output,
            SqlDbType = System.Data.SqlDbType.Int,
        };

        var sqlParameters = new[]
        {
            new SqlParameter
            {
                ParameterName = "userid",
                Value = userid ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "groupid",
                Value = groupid ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            parameterreturnValue,
        };
        var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[GroupDelRef] @userid, @groupid", sqlParameters, cancellationToken);

        returnValue?.SetValue(parameterreturnValue.Value);

        return _;
    }

    public virtual async Task<List<GrouprightGetResult>> GrouprightGetAsync(int? groupid, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
    {
        var parameterreturnValue = new SqlParameter
        {
            ParameterName = "returnValue",
            Direction = System.Data.ParameterDirection.Output,
            SqlDbType = System.Data.SqlDbType.Int,
        };

        var sqlParameters = new[]
        {
            new SqlParameter
            {
                ParameterName = "groupid",
                Value = groupid ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            parameterreturnValue,
        };
        var _ = await _context.SqlQueryAsync<GrouprightGetResult>("EXEC @returnValue = [dbo].[GrouprightGet] @groupid", sqlParameters, cancellationToken);

        returnValue?.SetValue(parameterreturnValue.Value);

        return _;
    }

    public virtual async Task<int> GroupRightUpdAsync(int? groupid, int? modulid, int? access, int? @readonly, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
    {
        var parameterreturnValue = new SqlParameter
        {
            ParameterName = "returnValue",
            Direction = System.Data.ParameterDirection.Output,
            SqlDbType = System.Data.SqlDbType.Int,
        };

        var sqlParameters = new[]
        {
            new SqlParameter
            {
                ParameterName = "groupid",
                Value = groupid ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "modulid",
                Value = modulid ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "access",
                Value = access ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "readonly",
                Value = @readonly ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            parameterreturnValue,
        };
        var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[GroupRightUpd] @groupid, @modulid, @access, @readonly", sqlParameters, cancellationToken);

        returnValue?.SetValue(parameterreturnValue.Value);

        return _;
    }

    public virtual async Task<int> GroupUpdAsync(int? groupid, string ngroup, string description, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
    {
        var parameterreturnValue = new SqlParameter
        {
            ParameterName = "returnValue",
            Direction = System.Data.ParameterDirection.Output,
            SqlDbType = System.Data.SqlDbType.Int,
        };

        var sqlParameters = new[]
        {
            new SqlParameter
            {
                ParameterName = "groupid",
                Value = groupid ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "ngroup",
                Size = 100,
                Value = ngroup ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "description",
                Size = 8000,
                Value = description ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            parameterreturnValue,
        };
        var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[GroupUpd] @groupid, @ngroup, @description", sqlParameters, cancellationToken);

        returnValue?.SetValue(parameterreturnValue.Value);

        return _;
    }

    public virtual async Task<int> LockSerialNbAsync(string fertnr, string srnr, int? auftragstypeid, int? prid, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
    {
        var parameterreturnValue = new SqlParameter
        {
            ParameterName = "returnValue",
            Direction = System.Data.ParameterDirection.Output,
            SqlDbType = System.Data.SqlDbType.Int,
        };

        var sqlParameters = new[]
        {
            new SqlParameter
            {
                ParameterName = "fertnr",
                Size = 24,
                Value = fertnr ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "srnr",
                Size = 40,
                Value = srnr ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "auftragstypeid",
                Value = auftragstypeid ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "prid",
                Value = prid ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            parameterreturnValue,
        };
        var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[LockSerialNb] @fertnr, @srnr, @auftragstypeid, @prid", sqlParameters, cancellationToken);

        returnValue?.SetValue(parameterreturnValue.Value);

        return _;
    }

    public virtual async Task<int> MeassureUpdAsync(Guid? TestID, double? Value, int? IsInner, int? State, int? typ, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
    {
        var parameterreturnValue = new SqlParameter
        {
            ParameterName = "returnValue",
            Direction = System.Data.ParameterDirection.Output,
            SqlDbType = System.Data.SqlDbType.Int,
        };

        var sqlParameters = new[]
        {
            new SqlParameter
            {
                ParameterName = "TestID",
                Value = TestID ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.UniqueIdentifier,
            },
            new SqlParameter
            {
                ParameterName = "Value",
                Value = Value ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "IsInner",
                Value = IsInner ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "State",
                Value = State ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "typ",
                Value = typ ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            parameterreturnValue,
        };
        var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[MeassureUpd] @TestID, @Value, @IsInner, @State, @typ", sqlParameters, cancellationToken);

        returnValue?.SetValue(parameterreturnValue.Value);

        return _;
    }

    public virtual async Task<int> MeassureValInsAsync(Guid? TestID, double? MeassuredVal, double? MeassureTime, int? IsInner, Guid? ID, DateTime? MDate, int? ValveOk, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
    {
        var parameterreturnValue = new SqlParameter
        {
            ParameterName = "returnValue",
            Direction = System.Data.ParameterDirection.Output,
            SqlDbType = System.Data.SqlDbType.Int,
        };

        var sqlParameters = new[]
        {
            new SqlParameter
            {
                ParameterName = "TestID",
                Value = TestID ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.UniqueIdentifier,
            },
            new SqlParameter
            {
                ParameterName = "MeassuredVal",
                Value = MeassuredVal ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "MeassureTime",
                Value = MeassureTime ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "IsInner",
                Value = IsInner ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "ID",
                Value = ID ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.UniqueIdentifier,
            },
            new SqlParameter
            {
                ParameterName = "MDate",
                Value = MDate ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.DateTime,
            },
            new SqlParameter
            {
                ParameterName = "ValveOk",
                Value = ValveOk ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            parameterreturnValue,
        };
        var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[MeassureValIns] @TestID, @MeassuredVal, @MeassureTime, @IsInner, @ID, @MDate, @ValveOk", sqlParameters, cancellationToken);

        returnValue?.SetValue(parameterreturnValue.Value);

        return _;
    }

    public virtual async Task<int> OrderAddAsync(string ordernb, int? ordertype, int? orderstateid, int? userid, OutputParameter<Guid?> orderid, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
    {
        var parameterorderid = new SqlParameter
        {
            ParameterName = "orderid",
            Direction = System.Data.ParameterDirection.InputOutput,
            Value = orderid?._value ?? Convert.DBNull,
            SqlDbType = System.Data.SqlDbType.UniqueIdentifier,
        };
        var parameterreturnValue = new SqlParameter
        {
            ParameterName = "returnValue",
            Direction = System.Data.ParameterDirection.Output,
            SqlDbType = System.Data.SqlDbType.Int,
        };

        var sqlParameters = new[]
        {
            parameterorderid,
            new SqlParameter
            {
                ParameterName = "ordernb",
                Size = 40,
                Value = ordernb ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "ordertype",
                Value = ordertype ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "orderstateid",
                Value = orderstateid ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "userid",
                Value = userid ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            parameterreturnValue,
        };
        var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[OrderAdd] @orderid OUTPUT, @ordernb, @ordertype, @orderstateid, @userid", sqlParameters, cancellationToken);

        orderid.SetValue(parameterorderid.Value);
        returnValue?.SetValue(parameterreturnValue.Value);

        return _;
    }

    public virtual async Task<int> OrderDetailAddAsync(Guid? orderid, string matnb, string MatDesc, string valvetype, string drawing, double? p1, double? p2, double? innerrate, double? innertime, double? outerrate, double? outertime, int? userid, string serialnb, int? type, double? pressure, double? vessel, long? ID, double? ValueInner, double? ValueOuter, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
    {
        var parameterreturnValue = new SqlParameter
        {
            ParameterName = "returnValue",
            Direction = System.Data.ParameterDirection.Output,
            SqlDbType = System.Data.SqlDbType.Int,
        };

        var sqlParameters = new[]
        {
            new SqlParameter
            {
                ParameterName = "orderid",
                Value = orderid ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.UniqueIdentifier,
            },
            new SqlParameter
            {
                ParameterName = "matnb",
                Size = 40,
                Value = matnb ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "MatDesc",
                Size = 510,
                Value = MatDesc ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "valvetype",
                Size = 40,
                Value = valvetype ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "drawing",
                Size = 40,
                Value = drawing ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "p1",
                Value = p1 ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "p2",
                Value = p2 ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "innerrate",
                Value = innerrate ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "innertime",
                Value = innertime ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "outerrate",
                Value = outerrate ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "outertime",
                Value = outertime ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "userid",
                Value = userid ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "serialnb",
                Size = 40,
                Value = serialnb ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "type",
                Value = type ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "pressure",
                Value = pressure ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "vessel",
                Value = vessel ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "ID",
                Value = ID ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.BigInt,
            },
            new SqlParameter
            {
                ParameterName = "ValueInner",
                Value = ValueInner ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "ValueOuter",
                Value = ValueOuter ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            parameterreturnValue,
        };
        var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[OrderDetailAdd] @orderid, @matnb, @MatDesc, @valvetype, @drawing, @p1, @p2, @innerrate, @innertime, @outerrate, @outertime, @userid, @serialnb, @type, @pressure, @vessel, @ID, @ValueInner, @ValueOuter", sqlParameters, cancellationToken);

        returnValue?.SetValue(parameterreturnValue.Value);

        return _;
    }

    public virtual async Task<int> PressureUpdAsync(string fertnr, int? auftragstypeid, int? deleted_von, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
    {
        var parameterreturnValue = new SqlParameter
        {
            ParameterName = "returnValue",
            Direction = System.Data.ParameterDirection.Output,
            SqlDbType = System.Data.SqlDbType.Int,
        };

        var sqlParameters = new[]
        {
            new SqlParameter
            {
                ParameterName = "fertnr",
                Size = 24,
                Value = fertnr ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "auftragstypeid",
                Value = auftragstypeid ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "deleted_von",
                Value = deleted_von ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            parameterreturnValue,
        };
        var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[PressureUpd] @fertnr, @auftragstypeid, @deleted_von", sqlParameters, cancellationToken);

        returnValue?.SetValue(parameterreturnValue.Value);

        return _;
    }

    public virtual async Task<int> ReleaseAllLocksAsync(int? prid, int? auftragstypeid, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
    {
        var parameterreturnValue = new SqlParameter
        {
            ParameterName = "returnValue",
            Direction = System.Data.ParameterDirection.Output,
            SqlDbType = System.Data.SqlDbType.Int,
        };

        var sqlParameters = new[]
        {
            new SqlParameter
            {
                ParameterName = "prid",
                Value = prid ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "auftragstypeid",
                Value = auftragstypeid ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            parameterreturnValue,
        };
        var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[ReleaseAllLocks] @prid, @auftragstypeid", sqlParameters, cancellationToken);

        returnValue?.SetValue(parameterreturnValue.Value);

        return _;
    }

    public virtual async Task<int> SelfTestAddAsync(DateTime? selftestdate, int? userid, OutputParameter<Guid?> id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
    {
        var parameterid = new SqlParameter
        {
            ParameterName = "id",
            Direction = System.Data.ParameterDirection.InputOutput,
            Value = id?._value ?? Convert.DBNull,
            SqlDbType = System.Data.SqlDbType.UniqueIdentifier,
        };
        var parameterreturnValue = new SqlParameter
        {
            ParameterName = "returnValue",
            Direction = System.Data.ParameterDirection.Output,
            SqlDbType = System.Data.SqlDbType.Int,
        };

        var sqlParameters = new[]
        {
            parameterid,
            new SqlParameter
            {
                ParameterName = "selftestdate",
                Value = selftestdate ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.DateTime,
            },
            new SqlParameter
            {
                ParameterName = "userid",
                Value = userid ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            parameterreturnValue,
        };
        var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[SelfTestAdd] @id OUTPUT, @selftestdate, @userid", sqlParameters, cancellationToken);

        id.SetValue(parameterid.Value);
        returnValue?.SetValue(parameterreturnValue.Value);

        return _;
    }

    public virtual async Task<int> SelfTestAddDetailAsync(DateTime? selftestdate, int? userid, int? nozzlenb, double? debitvalue, double? flowvalue, int? valveok, OutputParameter<Guid?> id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
    {
        var parameterid = new SqlParameter
        {
            ParameterName = "id",
            Direction = System.Data.ParameterDirection.InputOutput,
            Value = id?._value ?? Convert.DBNull,
            SqlDbType = System.Data.SqlDbType.UniqueIdentifier,
        };
        var parameterreturnValue = new SqlParameter
        {
            ParameterName = "returnValue",
            Direction = System.Data.ParameterDirection.Output,
            SqlDbType = System.Data.SqlDbType.Int,
        };

        var sqlParameters = new[]
        {
            parameterid,
            new SqlParameter
            {
                ParameterName = "selftestdate",
                Value = selftestdate ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.DateTime,
            },
            new SqlParameter
            {
                ParameterName = "userid",
                Value = userid ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "nozzlenb",
                Value = nozzlenb ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "debitvalue",
                Value = debitvalue ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "flowvalue",
                Value = flowvalue ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "valveok",
                Value = valveok ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            parameterreturnValue,
        };
        var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[SelfTestAddDetail] @id OUTPUT, @selftestdate, @userid, @nozzlenb, @debitvalue, @flowvalue, @valveok", sqlParameters, cancellationToken);

        id.SetValue(parameterid.Value);
        returnValue?.SetValue(parameterreturnValue.Value);

        return _;
    }

    public virtual async Task<int> SendEMSUpdAsync(Guid? TestID, int? UserID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
    {
        var parameterreturnValue = new SqlParameter
        {
            ParameterName = "returnValue",
            Direction = System.Data.ParameterDirection.Output,
            SqlDbType = System.Data.SqlDbType.Int,
        };

        var sqlParameters = new[]
        {
            new SqlParameter
            {
                ParameterName = "TestID",
                Value = TestID ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.UniqueIdentifier,
            },
            new SqlParameter
            {
                ParameterName = "UserID",
                Value = UserID ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            parameterreturnValue,
        };
        var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[SendEMSUpd] @TestID, @UserID", sqlParameters, cancellationToken);

        returnValue?.SetValue(parameterreturnValue.Value);

        return _;
    }

    public virtual async Task<int> SettingsUpdAsync(int? id, string sapimportpath, string sapexportpath, string importmaster, string importdetail, string exportmaster, string exportdetail, string importoldpath, string charstandard, string charsonder, string charstorno, string sapprotokollpath, string sapclosedpath, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
    {
        var parameterreturnValue = new SqlParameter
        {
            ParameterName = "returnValue",
            Direction = System.Data.ParameterDirection.Output,
            SqlDbType = System.Data.SqlDbType.Int,
        };

        var sqlParameters = new[]
        {
            new SqlParameter
            {
                ParameterName = "id",
                Value = id ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "sapimportpath",
                Size = 510,
                Value = sapimportpath ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "sapexportpath",
                Size = 510,
                Value = sapexportpath ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "importmaster",
                Size = 510,
                Value = importmaster ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "importdetail",
                Size = 510,
                Value = importdetail ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "exportmaster",
                Size = 510,
                Value = exportmaster ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "exportdetail",
                Size = 510,
                Value = exportdetail ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "importoldpath",
                Size = 510,
                Value = importoldpath ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "charstandard",
                Size = 10,
                Value = charstandard ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "charsonder",
                Size = 10,
                Value = charsonder ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "charstorno",
                Size = 10,
                Value = charstorno ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "sapprotokollpath",
                Size = 510,
                Value = sapprotokollpath ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "sapclosedpath",
                Size = 510,
                Value = sapclosedpath ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            parameterreturnValue,
        };
        var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[SettingsUpd] @id, @sapimportpath, @sapexportpath, @importmaster, @importdetail, @exportmaster, @exportdetail, @importoldpath, @charstandard, @charsonder, @charstorno, @sapprotokollpath, @sapclosedpath", sqlParameters, cancellationToken);

        returnValue?.SetValue(parameterreturnValue.Value);

        return _;
    }

    public virtual async Task<int> SystemsSettingsUPDAsync(string WebServiceLink, int? HasWebService, int? IsStandalone, int? HasSAPInterface, string SWUpdateLink, string EngImportPath, int? AutomaticMeassure, int? WaitForUserResponse, int? SelfTest, int? RelPressureTimeout, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
    {
        var parameterreturnValue = new SqlParameter
        {
            ParameterName = "returnValue",
            Direction = System.Data.ParameterDirection.Output,
            SqlDbType = System.Data.SqlDbType.Int,
        };

        var sqlParameters = new[]
        {
            new SqlParameter
            {
                ParameterName = "WebServiceLink",
                Size = 510,
                Value = WebServiceLink ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "HasWebService",
                Value = HasWebService ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "IsStandalone",
                Value = IsStandalone ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "HasSAPInterface",
                Value = HasSAPInterface ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "SWUpdateLink",
                Size = 510,
                Value = SWUpdateLink ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "EngImportPath",
                Size = 510,
                Value = EngImportPath ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "AutomaticMeassure",
                Value = AutomaticMeassure ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "WaitForUserResponse",
                Value = WaitForUserResponse ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "SelfTest",
                Value = SelfTest ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "RelPressureTimeout",
                Value = RelPressureTimeout ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            parameterreturnValue,
        };
        var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[SystemsSettingsUPD] @WebServiceLink, @HasWebService, @IsStandalone, @HasSAPInterface, @SWUpdateLink, @EngImportPath, @AutomaticMeassure, @WaitForUserResponse, @SelfTest, @RelPressureTimeout", sqlParameters, cancellationToken);

        returnValue?.SetValue(parameterreturnValue.Value);

        return _;
    }

    public virtual async Task<int> UnLockSerialNbAsync(string fertnr, string srnr, int? auftragstypeid, int? prid, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
    {
        var parameterreturnValue = new SqlParameter
        {
            ParameterName = "returnValue",
            Direction = System.Data.ParameterDirection.Output,
            SqlDbType = System.Data.SqlDbType.Int,
        };

        var sqlParameters = new[]
        {
            new SqlParameter
            {
                ParameterName = "fertnr",
                Size = 24,
                Value = fertnr ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "srnr",
                Size = 40,
                Value = srnr ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "auftragstypeid",
                Value = auftragstypeid ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "prid",
                Value = prid ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            parameterreturnValue,
        };
        var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[UnLockSerialNb] @fertnr, @srnr, @auftragstypeid, @prid", sqlParameters, cancellationToken);

        returnValue?.SetValue(parameterreturnValue.Value);

        return _;
    }

    public virtual async Task<int> UpdateHN248Async(string valvetype, double? p1, double? p2, double? vessel, double? time, double? rate, string remarks, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
    {
        var parameterreturnValue = new SqlParameter
        {
            ParameterName = "returnValue",
            Direction = System.Data.ParameterDirection.Output,
            SqlDbType = System.Data.SqlDbType.Int,
        };

        var sqlParameters = new[]
        {
            new SqlParameter
            {
                ParameterName = "valvetype",
                Size = 40,
                Value = valvetype ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "p1",
                Value = p1 ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "p2",
                Value = p2 ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "vessel",
                Value = vessel ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "time",
                Value = time ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "rate",
                Value = rate ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "remarks",
                Size = 2048,
                Value = remarks ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            parameterreturnValue,
        };
        var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[UpdateHN248] @valvetype, @p1, @p2, @vessel, @time, @rate, @remarks", sqlParameters, cancellationToken);

        returnValue?.SetValue(parameterreturnValue.Value);

        return _;
    }

    public virtual async Task<int> UpdateHN248KonzAsync(string drawingnb, string valvetype, double? p1, double? p2, double? innerrate, double? outerrate, double? pressure, double? innertime, double? outertime, string remarks, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
    {
        var parameterreturnValue = new SqlParameter
        {
            ParameterName = "returnValue",
            Direction = System.Data.ParameterDirection.Output,
            SqlDbType = System.Data.SqlDbType.Int,
        };

        var sqlParameters = new[]
        {
            new SqlParameter
            {
                ParameterName = "drawingnb",
                Size = 40,
                Value = drawingnb ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "valvetype",
                Size = 40,
                Value = valvetype ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "p1",
                Value = p1 ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "p2",
                Value = p2 ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "innerrate",
                Value = innerrate ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "outerrate",
                Value = outerrate ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "pressure",
                Value = pressure ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "innertime",
                Value = innertime ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "outertime",
                Value = outertime ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Float,
            },
            new SqlParameter
            {
                ParameterName = "remarks",
                Size = 2048,
                Value = remarks ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            parameterreturnValue,
        };
        var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[UpdateHN248Konz] @drawingnb, @valvetype, @p1, @p2, @innerrate, @outerrate, @pressure, @innertime, @outertime, @remarks", sqlParameters, cancellationToken);

        returnValue?.SetValue(parameterreturnValue.Value);

        return _;
    }

    public virtual async Task<int> UserAddAsync(string vorname, string nachname, string login, string passwort, string personalnr, int? gesperrt, int? groupid, OutputParameter<int?> userid, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
    {
        var parameteruserid = new SqlParameter
        {
            ParameterName = "userid",
            Direction = System.Data.ParameterDirection.InputOutput,
            Value = userid?._value ?? Convert.DBNull,
            SqlDbType = System.Data.SqlDbType.Int,
        };
        var parameterreturnValue = new SqlParameter
        {
            ParameterName = "returnValue",
            Direction = System.Data.ParameterDirection.Output,
            SqlDbType = System.Data.SqlDbType.Int,
        };

        var sqlParameters = new[]
        {
            parameteruserid,
            new SqlParameter
            {
                ParameterName = "vorname",
                Size = 100,
                Value = vorname ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "nachname",
                Size = 100,
                Value = nachname ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "login",
                Size = 50,
                Value = login ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "passwort",
                Size = 50,
                Value = passwort ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "personalnr",
                Size = 100,
                Value = personalnr ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "gesperrt",
                Value = gesperrt ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "groupid",
                Value = groupid ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            parameterreturnValue,
        };
        var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[UserAdd] @userid OUTPUT, @vorname, @nachname, @login, @passwort, @personalnr, @gesperrt, @groupid", sqlParameters, cancellationToken);

        userid.SetValue(parameteruserid.Value);
        returnValue?.SetValue(parameterreturnValue.Value);

        return _;
    }

    public virtual async Task<int> UserSettingsUpdAsync(string keystr, string keyvalue, int? mitarbeiter, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
    {
        var parameterreturnValue = new SqlParameter
        {
            ParameterName = "returnValue",
            Direction = System.Data.ParameterDirection.Output,
            SqlDbType = System.Data.SqlDbType.Int,
        };

        var sqlParameters = new[]
        {
            new SqlParameter
            {
                ParameterName = "keystr",
                Size = 510,
                Value = keystr ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "keyvalue",
                Size = 8000,
                Value = keyvalue ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "mitarbeiter",
                Value = mitarbeiter ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            parameterreturnValue,
        };
        var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[UserSettingsUpd] @keystr, @keyvalue, @mitarbeiter", sqlParameters, cancellationToken);

        returnValue?.SetValue(parameterreturnValue.Value);

        return _;
    }

    public virtual async Task<int> UserUpdAsync(int? userid, string vorname, string nachname, string login, string passwort, string personalnr, int? gesperrt, int? groupid, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
    {
        var parameterreturnValue = new SqlParameter
        {
            ParameterName = "returnValue",
            Direction = System.Data.ParameterDirection.Output,
            SqlDbType = System.Data.SqlDbType.Int,
        };

        var sqlParameters = new[]
        {
            new SqlParameter
            {
                ParameterName = "userid",
                Value = userid ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "vorname",
                Size = 100,
                Value = vorname ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "nachname",
                Size = 100,
                Value = nachname ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "login",
                Size = 50,
                Value = login ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "passwort",
                Size = 50,
                Value = passwort ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "personalnr",
                Size = 100,
                Value = personalnr ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            },
            new SqlParameter
            {
                ParameterName = "gesperrt",
                Value = gesperrt ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            new SqlParameter
            {
                ParameterName = "groupid",
                Value = groupid ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
            },
            parameterreturnValue,
        };
        var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[UserUpd] @userid, @vorname, @nachname, @login, @passwort, @personalnr, @gesperrt, @groupid", sqlParameters, cancellationToken);

        returnValue?.SetValue(parameterreturnValue.Value);

        return _;
    }
}

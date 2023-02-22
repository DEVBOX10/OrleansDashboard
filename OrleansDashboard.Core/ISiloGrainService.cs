﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Orleans.Concurrency;
using Orleans.Runtime;
using Orleans.Services;
using OrleansDashboard.Model;

namespace OrleansDashboard
{
    public interface ISiloGrainService : IGrainService
    {
        Task SetVersion(string orleans, string host);

        [OneWay]
        Task ReportCounters(Immutable<StatCounter[]> stats);

        Task Enable(bool enabled);

        Task<Immutable<Dictionary<string,string>>> GetExtendedProperties();

        Task<Immutable<SiloRuntimeStatistics[]>> GetRuntimeStatistics();

        Task<Immutable<StatCounter[]>> GetCounters();
    }
}
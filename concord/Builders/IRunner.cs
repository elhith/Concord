﻿using System.Collections.Generic;
using concord.Configuration;

namespace concord.Builders
{
    public interface IRunner
    {
        void ConfigureRun(string assemblyLocation,
                          IEnumerable<string> categories,
                          IEnumerable<string> otherTestFixtures,
                          IEnumerable<string> categoriesToRun,
                          RunnerSettings runnerSettings);

        string GetRunResultsAsXml();
        string GetRunResultsAsXml(int concurrentRunners);
    }
}
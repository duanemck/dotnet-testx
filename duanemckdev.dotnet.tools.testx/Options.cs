﻿using System.Collections.Generic;
using CommandLine;

namespace duanemckdev.dotnet.tools.testx
{
    public class Options
    {

        [Option("discover-projects", Required = false, Default=null, HelpText = "Discover all files in the working directory matching the pattern and run tests on them. Alias for '--project all'")]
        public string RunForAllProjects { get; set; }

        [Option("project", Required = false, HelpText = "Project to test. * => find all projects in the folder and subfolders")]
        public string Project { get; set; }

        [Option("opencover-version", Required = false, HelpText = "Optional OpenCover version.")]
        public string OpenCoverVersion { get; set; }


        [Option("html", Required = false, Default = false, HelpText = "Generate an HTML report")]
        public bool GenerateReport { get; set; }

        [Option("browser", Required = false, Default = false, HelpText = "If generating an HTML report, open in the default browser")]
        public bool LaunchBrowser { get; set; }


        [Option("cobertura", Required = false, Default = false, HelpText = "Generate a cobertura report")]
        public bool Cobertura { get; set; }

        [Option("test-results-format", Required = false, Default = "trx", HelpText = "The format to use for the VSTest test results")]
        public string TestResultsFormat { get; set; }

        [Option("opencover-filters", Required = false, Default = "+[*]*", HelpText = "Filters for opencover, i.e. files to include/exclude from report")]
        public string OpenCoverFilters { get; set; }

        [Option("opencover-mergeresults", Required = false, Default = true, HelpText = "Merge multiple runs into the same results file")]
        public bool OpenCoverMerge { get; set; }
    }
}
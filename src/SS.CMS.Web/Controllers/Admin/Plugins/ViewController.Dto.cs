﻿using SS.CMS.Abstractions;
using SS.CMS.Packaging;

namespace SS.CMS.Web.Controllers.Admin.Plugins
{
    public partial class ViewController
    {
        public class GetResult
        {
            public bool IsNightly { get; set; }
            public string PluginVersion { get; set; }
            public bool Installed { get; set; }
            public string InstalledVersion { get; set; }
            public PackageMetadata Package { get; set; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace KsrExplorerLib.config
{
    public class KsrExplorerConfigUtil
    {
        public static string DSN_KsrExplorer()
        {
            return ConfigurationManager.ConnectionStrings["DSN_KsrExplorer"].ConnectionString;
        }
    }
}

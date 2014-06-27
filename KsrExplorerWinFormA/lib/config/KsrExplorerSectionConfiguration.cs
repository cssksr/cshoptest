using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration; //System.Configuration.dll
//using System.Web.Configuration; //System.Web.dll

namespace KsrExplorerWinFormA
{
    public class KsrExplorerSectionConfiguration : ConfigurationSection
    {

        #region OptA
        [ConfigurationProperty("OptA", IsRequired = true)]
        [IntegerValidator(MinValue = 0, MaxValue = 1000000)]
        public int OptA
        {
            get { return (int)base["OptA"]; }
            set { base["OptA"] = value; }
        } 
        #endregion

        #region ExternalUrlElement
        [ConfigurationProperty("externalUrl", IsRequired = true)]
        public ExternalUrlElement ExternalUrl
        {
            get { return (ExternalUrlElement)base["externalUrl"]; }
            set { base["externalUrl"] = value; }
        }
        public class ExternalUrlElement : ConfigurationElement
        {
            [ConfigurationProperty("UrlA", IsRequired = true)]
            public string UrlA
            {
                get { return (string)base["UrlA"]; }
                set { base["UrlA"] = value; }
            }
            [ConfigurationProperty("UrlB", IsRequired = true)]
            public string UrlB
            {
                get { return (string)base["UrlB"]; }
                set { base["UrlB"] = value; }
            }
        }
        #endregion ExternalUrlElement



        private static KsrExplorerSectionConfiguration instance = null;
        public static KsrExplorerSectionConfiguration Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = (KsrExplorerSectionConfiguration)ConfigurationManager
                         .GetSection("ksrexplorer.configuration");
                }
                return instance;
            }
        }
    }
}

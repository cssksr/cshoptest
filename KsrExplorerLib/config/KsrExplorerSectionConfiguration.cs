using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration; //System.Configuration.dll
//using System.Web.Configuration; //System.Web.dll

namespace KsrExplorerLib.config
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

        #region MainPageSize
        [ConfigurationProperty("MainPageSize", IsRequired = true)]
        [IntegerValidator(MinValue = 0, MaxValue = 1000000)]
        public int MainPageSize
        {
            get { return (int)base["MainPageSize"]; }
            set { base["MainPageSize"] = value; }
        }
        #endregion

        #region SqliteDbFilePath
        [ConfigurationProperty("SqliteDbFilePath", IsRequired = true)]
        //[IntegerValidator(MinValue = 0, MaxValue = 1000000)]
        public string SqliteDbFilePath
        {
            get { return (string)base["SqliteDbFilePath"]; }
            set { base["SqliteDbFilePath"] = value; }
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

        [ConfigurationProperty("folderItems")]
        public FolderItemsCollection FolderItems
        {
            get { return ((FolderItemsCollection)(base["folderItems"])); }
        }


        [ConfigurationCollection(typeof(FolderItemElement))]
        public class FolderItemsCollection : ConfigurationElementCollection
        {
            protected override ConfigurationElement CreateNewElement()
            {
                return new FolderItemElement();
            }

            protected override object GetElementKey(ConfigurationElement element)
            {
                return ((FolderItemElement)(element)).FolPath;
            }
            
            public FolderItemElement this[int idx]
            {
                get
                {
                    return (FolderItemElement)BaseGet(idx);
                }
            }
            /*
            public new FolderItemElement this[string CorpCode]
            {
                get
                {
                    return (FolderItemElement)BaseGet(CorpCode);
                }
            }*/
        }

        public class FolderItemElement : ConfigurationElement
        {
            [ConfigurationProperty("FolPath", IsRequired = true)]
            public string FolPath
            {
                get { return (string)base["FolPath"]; }
                set { base["FolPath"] = value; }
            }
        }


        #region searchWordItems
        [ConfigurationProperty("searchWordItems")]
        public SearchWordItemsCollection SearchWordItems
        {
            get { return ((SearchWordItemsCollection)(base["searchWordItems"])); }
        }

        [ConfigurationCollection(typeof(SearchWordItemElement))]
        public class SearchWordItemsCollection : ConfigurationElementCollection
        {
            protected override ConfigurationElement CreateNewElement()
            {
                return new SearchWordItemElement();
            }

            protected override object GetElementKey(ConfigurationElement element)
            {
                return ((SearchWordItemElement)(element)).DefaultSearchWord;
            }

            public SearchWordItemElement this[int idx]
            {
                get
                {
                    return (SearchWordItemElement)BaseGet(idx);
                }
            }
            /*
            public new SearchWordItemElement this[string CorpCode]
            {
                get
                {
                    return (SearchWordItemElement)BaseGet(CorpCode);
                }
            }*/
        }

        public class SearchWordItemElement : ConfigurationElement
        {
            [ConfigurationProperty("DefaultSearchWord", IsRequired = true)]
            public string DefaultSearchWord
            {
                get { return (string)base["DefaultSearchWord"]; }
                set { base["DefaultSearchWord"] = value; }
            }
        } 
        #endregion

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

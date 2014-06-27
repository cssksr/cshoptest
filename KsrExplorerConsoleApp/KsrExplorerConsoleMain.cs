using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using KsrExplorerLib.config;
using KsrExplorerLib.biz;
namespace KsrExplorerConsoleApp
{
    public class KsrExplorerConsoleMain
    {

        public void ExecSqliteFileCreate()
        {
            //SQLiteConnection.CreateFile(KsrExplorerSectionConfiguration.Instance.SqliteDbFilePath);
            KsrExplorerBiz biz = new KsrExplorerBiz();
            biz.SqliteDbFileCreate();
        }
        public void CreateTableT_FILE_LIST()
        {
            KsrExplorerBiz biz = new KsrExplorerBiz();
            biz.CreateTableT_FILE_LIST();


        }
    }
}

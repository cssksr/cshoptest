using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using KsrExplorerLib.config;
using KsrExplorerLib.biz;
using KsrExplorerLib.db;
namespace KsrExplorerConsoleApp
{
    public class KsrExplorerConsoleMain
    {

        public void ExecSqliteFileCreate()
        {
            Console.WriteLine("==ExecSqliteFileCreate==");
            //SQLiteConnection.CreateFile(KsrExplorerSectionConfiguration.Instance.SqliteDbFilePath);
            KsrExplorerBiz biz = new KsrExplorerBiz();
            biz.SqliteDbFileCreate();
        }
        public void CreateTableT_FILE_LIST()
        {
            Console.WriteLine("==CreateTableT_FILE_LIST==");
            KsrExplorerBiz biz = new KsrExplorerBiz();
            biz.CreateTableT_FILE_LIST();


        }
        public void TestSelect() {
            Console.WriteLine("==TestSelect==");
            KsrExplorerDefaultPagingEntity listInfo =KsrExplorerDac.SelectT_FILE_LIST(1,10,"","",-1,-1);
            if (listInfo == null)
            {
                Console.WriteLine("listInfo is null");
            }
            else
            {
                Console.WriteLine("SelectT_FILE_LIST.Rows.count=" + listInfo.dt_list.Rows.Count);
                Console.WriteLine("SelectT_FILE_LIST.Columns.count=" + listInfo.dt_list.Columns.Count);
                if (listInfo.dt_list.Rows.Count > 0)
                {
                    Console.WriteLine("  row value =" + listInfo.dt_list.Rows[0][0].ToString());
                }
                for (int i = 0; i < listInfo.dt_list.Columns.Count; i++)
                {
                    Console.WriteLine("  ColumnName "+i+"=" + listInfo.dt_list.Columns[i].ColumnName);
                }
                int iRows = KsrExplorerDac.CountT_FILE_LIST("", -1, -1);
                Console.WriteLine("SelectT_FILE_LIST totalRows=" + iRows);
            }
        }
        public void InsertQueryMakeFile()
        {
            Console.WriteLine("==InsertQueryMakeFile==");
            KsrExplorerBiz biz = new KsrExplorerBiz();
            biz.InsertQueryMakeFile();

        }

        public void InsertQueryMakeTest()
        {
            Console.WriteLine("==InsertQueryMakeTest==");
            KsrExplorerBiz biz = new KsrExplorerBiz();
            biz.InsertQueryMakeTest();

        }
        public void InsertQueryMakeReal()
        {
            Console.WriteLine("==InsertQueryMakeReal==");
            KsrExplorerBiz biz = new KsrExplorerBiz();
            biz.InsertQueryMakeReal();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KsrExplorerConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("KsrExplorerConsoleApp");
            KsrExplorerConsoleMain main = new KsrExplorerConsoleMain();

            string gubun = "";
            gubun = "FILE_CREATE";
            gubun = "TABLE_CREATE";
            gubun = "SELECT_TEST";
            //gubun = "INSERT_QUERY_MAKE_TEST"; //테스트로 쿼리임의로 실행해본것
            gubun = "INSERT_QUERY_MAKE_FILE";
            gubun = "INSERT_QUERY_MAKE_REAL"; // INSERT_QUERY_MAKE_FILE로 만든 sql파일 읽어서 디비에 삽입
            

            if (gubun.Equals("FILE_CREATE"))
            {
                main.ExecSqliteFileCreate();
            }
            else if (gubun.Equals("TABLE_CREATE"))
            {
                main.CreateTableT_FILE_LIST();
            }
            else if (gubun.Equals("SELECT_TEST"))
            {
                main.TestSelect();
            }
            else if (gubun.Equals("INSERT_QUERY_MAKE_FILE"))
            {
                main.InsertQueryMakeFile();
            }
            else if (gubun.Equals("INSERT_QUERY_MAKE_TEST"))
            {
                main.InsertQueryMakeTest();
            }
            else if (gubun.Equals("INSERT_QUERY_MAKE_REAL"))
            {
                main.InsertQueryMakeReal();
            }

        }
    }
}

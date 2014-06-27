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
            if (gubun.Equals("FILE_CREATE"))
            {
                main.ExecSqliteFileCreate();
            }
            else if (gubun.Equals("FILE_CREATE")) {
                main.CreateTableT_FILE_LIST();
            }

        }
    }
}

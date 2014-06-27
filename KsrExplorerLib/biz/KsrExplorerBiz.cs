using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SQLite;

using KsrExplorerLib.config;
using KsrExplorerLib.db;
using KsrExplorerLib.util;

namespace KsrExplorerLib.biz
{
    public class KsrExplorerBiz
    {
        public void SqliteDbFileCreate()
        {
            SQLiteConnection.CreateFile(KsrExplorerSectionConfiguration.Instance.SqliteDbFilePath);
        }

        public void CreateTableT_FILE_LIST()
        {
            KsrExplorerDac.CreateTableT_FILE_LIST();
        }
        public void InsertQueryMakeTest()
        {
            //KsrExplorerSectionConfiguration.Instance.FolderItems.Count
            /*
             * 파일읽어서 쿼리 실행 (insert쿼리)
             */
            string strFullFileName = @"C:\ksr_cshop\test_query.sql";
            Console.WriteLine(strFullFileName);
            string s = string.Empty;

            using (StreamReader sr = new StreamReader(strFullFileName, System.Text.Encoding.UTF8, true))
            {
                s = sr.ReadToEnd();
            }

            Console.WriteLine(s);
            
            long start = DateTime.Now.Ticks;
            //1000
            for (int i = 0; i < 10; i++)
            {
                long start2 = DateTime.Now.Ticks;
                KsrExplorerDac.SqlStringExecuteNonQuery(s);
                long end2 = DateTime.Now.Ticks;
                Console.WriteLine(" {0} sec, i={1}", (double)(end2 - start2) / 10000000.0F,i);
            }
            

            long end = DateTime.Now.Ticks;

            double term = (double)(end - start) / 10000000.0F;
            //Console.WriteLine("{0} sec", (double)(end - start) / 10000000.0F);
            
            int iCount =KsrExplorerDac.CountT_FILE_LIST("", -1, -1);
            Console.WriteLine("term= {1}   ,rowCount={0}",iCount,term);

        }
        public void InsertQueryMakeReal()
        {
            int rowIdx = 0;
            long startTotal = DateTime.Now.Ticks;
            using (StreamReader reader = new StreamReader(KsrExplorerSectionConfiguration.Instance.SqlInsertQueryFilePath, System.Text.Encoding.UTF8))
            {
                string line;

                StringBuilder sbSql = new StringBuilder();
                while ((line = reader.ReadLine()) != null)
                {
                    rowIdx++;
                    if (line.Length == 1 && line.Equals("/"))
                    {
                        if (sbSql.ToString().Length > 5)
                        {
                            //Console.WriteLine("@S"+sbSql.ToString().Trim()+"@E ");
                            long start2 = DateTime.Now.Ticks;
                            KsrExplorerDac.SqlStringExecuteNonQuery(sbSql.ToString().Trim());
                            long end2 = DateTime.Now.Ticks;
                            Console.WriteLine(" {0} sec, line {1}", (double)(end2 - start2) / 10000000.0F, rowIdx);
                        }
                        sbSql.Clear();
                    }
                    else
                    {
                        sbSql.Append(line).Append("\r\n");
                    }
                }

            }
            long endTotal = DateTime.Now.Ticks;
            Console.WriteLine(" {0} sec", (double)(endTotal - startTotal) / 10000000.0F);
        }

        public void InsertQueryMakeFile()
        {
            //시작하기전에 해당파일제거
            FileInfo f = new FileInfo(KsrExplorerSectionConfiguration.Instance.SqlInsertQueryFilePath);
            if (f.Exists)
            {
                f.Delete();
            }

            string[] dirs = new string[KsrExplorerSectionConfiguration.Instance.FolderItems.Count];
            for (int i = 0; i < KsrExplorerSectionConfiguration.Instance.FolderItems.Count; i++)
            {
                dirs[i] = KsrExplorerSectionConfiguration.Instance.FolderItems[i].FolPath;
                Console.WriteLine(KsrExplorerSectionConfiguration.Instance.FolderItems[i].FolPath);
            }
            InsertQueryMakeFileMain(dirs);

        }
        public void InsertQueryMakeFileMain(string[] dirs)
        {
            //폴더목록 loop
            for (int i = 0; i < dirs.Length; i++)
            {
                //DirectoryInfo di = new DirectoryInfo(@"D:\ebay_ksr\서버정보");
                DirectoryInfo di = new DirectoryInfo(dirs[i]);
                InsertQueryMakeFileSubDir(di);
            }

        }
        private void InsertQueryMakeFileSubDir(DirectoryInfo root)
        {
            System.IO.DirectoryInfo[] subDirs = null;

            string sql_insert_define = "INSERT INTO T_FILE_LIST ( FILE_PATH,FILE_NAME,FILE_SIZE,FILE_CREATE_DATE,FILE_MODIFY_DATE,REG_DATE ) VALUES \r\n";
            System.IO.FileInfo[] files = root.GetFiles();

            int loopIdx = 0;

            StringBuilder sbSqlValue = new StringBuilder();
            foreach (System.IO.FileInfo fileInfo in files)
            {
                loopIdx++;
                if (loopIdx > 1)
                {
                    sbSqlValue.Append(",");
                }
                sbSqlValue.Append("('");
                sbSqlValue.Append(fileInfo.FullName.Replace("'","''"));
                sbSqlValue.Append("','");
                sbSqlValue.Append(fileInfo.Name.Replace("'", "''"));
                sbSqlValue.Append("'");
                sbSqlValue.Append("\r\n");
                sbSqlValue.Append(",");
                sbSqlValue.Append(Convert.ToInt64(fileInfo.Length)+"");
                
                sbSqlValue.Append(",'");
                sbSqlValue.Append(String.Format("{0:yyyy-M-d HH:mm:ss}", fileInfo.CreationTime));
                sbSqlValue.Append("','");
                sbSqlValue.Append(String.Format("{0:yyyy-M-d HH:mm:ss}", fileInfo.LastWriteTime));
                sbSqlValue.Append("','");
                sbSqlValue.Append(String.Format("{0:yyyy-M-d HH:mm:ss}", DateTime.Now));
                sbSqlValue.Append("'");
                sbSqlValue.Append("\r\n");
                sbSqlValue.Append(")");
                /*KsrExplorerLib.db.KsrExplorerDac.InsertT_FILE_LIST(fileInfo.FullName
                    , fileInfo.Name, Convert.ToInt64(fileInfo.Length)
                    , String.Format("{0:yyyy-M-d HH:mm:ss}", fileInfo.CreationTime)
                    , String.Format("{0:yyyy-M-d HH:mm:ss}", fileInfo.LastWriteTime)
                    );
                 */
                if (loopIdx > KsrExplorerSectionConfiguration.Instance.SqlInsertQueryOneRowCount)
                {
                    KsrLogFileUtil.SqlWriteLog(sql_insert_define, sbSqlValue.ToString());
                    sbSqlValue.Clear();
                    loopIdx = 0;
                }
                
                //Console.WriteLine(fileInfo.FullName);
            }

            if (sbSqlValue.ToString().Length > 2)
            {
                KsrLogFileUtil.SqlWriteLog(sql_insert_define, sbSqlValue.ToString());
                sbSqlValue.Clear();
            }

            // 현재 디랙토리의 하위 디랙토리 목록을 가져옵니다.
            subDirs = root.GetDirectories();
            foreach (System.IO.DirectoryInfo dirInfo in subDirs)
            {
                // 재귀 호출을 통해 하위 디랙토리의 하위디랙토리를 탐색합니다.
                InsertQueryMakeFileSubDir(dirInfo);
            }

        }



        public void FileInfoToDbInsertMain(string[] dirs)
        {
            //폴더목록 loop
            for (int i = 0; i < dirs.Length; i++)
            {
                //DirectoryInfo di = new DirectoryInfo(@"D:\ebay_ksr\서버정보");
                DirectoryInfo di = new DirectoryInfo(dirs[i]);
                FileInfoToDbInsertSubDir(di);
            }
            
        }

        private void FileInfoToDbInsertSubDir(DirectoryInfo root)
        {
            System.IO.DirectoryInfo[] subDirs = null;


            System.IO.FileInfo[] files = root.GetFiles();
            foreach (System.IO.FileInfo fileInfo in files)
            {
                KsrExplorerLib.db.KsrExplorerDac.InsertT_FILE_LIST(fileInfo.FullName
                    , fileInfo.Name, Convert.ToInt64(fileInfo.Length)
                    , String.Format("{0:yyyy-M-d HH:mm:ss}", fileInfo.CreationTime)
                    , String.Format("{0:yyyy-M-d HH:mm:ss}", fileInfo.LastWriteTime)
                    );
            }

            // 현재 디랙토리의 하위 디랙토리 목록을 가져옵니다.
            subDirs = root.GetDirectories();
            foreach (System.IO.DirectoryInfo dirInfo in subDirs)
            {
                // 재귀 호출을 통해 하위 디랙토리의 하위디랙토리를 탐색합니다.
                FileInfoToDbInsertSubDir(dirInfo);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SQLite;

using KsrExplorerLib.config;
using KsrExplorerLib.db;
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

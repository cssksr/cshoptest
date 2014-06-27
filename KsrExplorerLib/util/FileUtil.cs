using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KsrExplorerLib.util
{
    public class FileUtil
    {
        public static Int64 getFileSize(Int64 fileSize, string fileUnit)
        {
            if (fileUnit.Equals("KB"))
            {
                fileSize = fileSize * 1024;
            }
            else if (fileUnit.Equals("MB"))
            {
                fileSize = fileSize * 1048576;//1024 * 1024;
            }
            else if (fileUnit.Equals("GB"))
            {
                fileSize = fileSize * 1073741824;// 1024 * 1024 * 1024;
            }
            return fileSize;
        }
    }
}

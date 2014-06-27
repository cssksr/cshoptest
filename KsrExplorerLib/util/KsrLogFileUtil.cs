using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using KsrExplorerLib.config;
namespace KsrExplorerLib.util
{
    public class KsrLogFileUtil
    {
        public static void SqlWriteLog(string strTitle, string strLogData)
        {
            try
            {
                /*
                if (!GHotelSectionConfiguration.Instance.Log.Path.EndsWith(Path.DirectorySeparatorChar.ToString()))
                {
                    GHotelSectionConfiguration.Instance.Log.Path = GHotelSectionConfiguration.Instance.Log.Path + Path.DirectorySeparatorChar.ToString();
                }
                 */

                // 로그파일 경로 + 파일명
                //strFullFileName = @"D:\Log\GHotel/TourLog_" + DateTime.Now.ToString("yyyyMMdd") + ".log";

                string strLogText = String.Format("{0} {1}",
                                                    //DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                                                    strTitle,
                                                    strLogData);

                using (StreamWriter sw = new StreamWriter(KsrExplorerSectionConfiguration.Instance.SqlInsertQueryFilePath, true, System.Text.Encoding.UTF8, 4096))
                {
                    sw.WriteLine(strLogText);

                    sw.WriteLine("");
                    sw.WriteLine("/");
                    sw.WriteLine("");

                    //sw.Close();
                }


            }
            catch (Exception ex)
            {
                string strException = ex.StackTrace.ToString();
            }

        }

        /// <summary>
        /// 로그를 남긴다.
        /// </summary>
        /// <param name="strTitle">로그타이틀</param>
        /// <param name="strLogData">로그 내용</param>
        public static void WriteLog(string strTitle, string strLogData)
        {
            try
            {
                string strFullFileName = ""; ;

                /*
                if (!GHotelSectionConfiguration.Instance.Log.Path.EndsWith(Path.DirectorySeparatorChar.ToString()))
                {
                    GHotelSectionConfiguration.Instance.Log.Path = GHotelSectionConfiguration.Instance.Log.Path + Path.DirectorySeparatorChar.ToString();
                }
                 */

                // 로그파일 경로 + 파일명
                strFullFileName = @"D:\Log\GHotel/TourLog_" + DateTime.Now.ToString("yyyyMMdd") + ".log";

                string strLogText = String.Format("[{0}][{1}] {2} ",
                                                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                                                    strTitle,
                                                    strLogData);

                using (StreamWriter sw = new StreamWriter(strFullFileName, true, System.Text.Encoding.UTF8, 4096))
                {
                    sw.WriteLine(strLogText);

                    //sw.Close();
                }

            }
            catch (Exception ex)
            {
                string strException = ex.StackTrace.ToString();
            }

        }
    }
}

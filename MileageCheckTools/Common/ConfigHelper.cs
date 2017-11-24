using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MileageCheckTools.Common
{
    public class ConfigHelper
    {
        /// <summary>
        /// 根据根目录下的文件夹名称路径和数据库名称获取 连接access数据字符串
        /// </summary>
        /// <param name="folder"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public static string GetAccessDbConn(string folder, string dbName)
        {
            string str = "Provider=Microsoft.Jet.OLEDB.4.0 ;Data Source=";

            string folderPath = System.Windows.Forms.Application.StartupPath;

            string connStr = str + folderPath + "\\" + dbName;

            if (!String.IsNullOrWhiteSpace(folder))
            {
                connStr = str + folderPath + "\\" + folder + "\\" + dbName;
            }

            return connStr;
        }

        public static string GetAccessDbConn(int type, string fileFullPath)
        {
            string str = "Provider=Microsoft.Jet.OLEDB.4.0 ;Data Source=";

            string connStr = "";

            if (type == 1)
            {
                connStr = str + fileFullPath;
            }

            return connStr;
        }
    }
}

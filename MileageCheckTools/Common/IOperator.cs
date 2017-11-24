using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MileageCheckTools.Common
{
    public interface IOperator
    {
        string DbFilePath { get; set; }
        void CreateDB(string filePath);
        DataTable Query(string queryString);
        object ExecuteScalar(string cmdText);
        bool ExcuteSql(string cmdText);
        void CheckAndCreateTable(string tableName, string cmdText);
    }
}

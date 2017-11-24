using MileageCheckTools.Common;
using MileageCheckTools.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MileageCheckTools.DAL
{
    public class TotalFileDAL
    {
        public static string connStr = ConfigHelper.GetAccessDbConn("", "data.db");
        IOperator _dbOperator = null;

        public TotalFileDAL(string fileFullPath)
        {
            connStr = ConfigHelper.GetAccessDbConn(1, fileFullPath);
            _dbOperator = new DbOperator();
            _dbOperator.DbFilePath = fileFullPath;
        }

        public bool Add(TotalFile data)
        {
            bool isok = false;

            StringBuilder sbSql = new StringBuilder();
            sbSql.Append("insert into TotalResult (");
            sbSql.Append("LineName,TrainCode,");
            sbSql.Append("GeoFileName,ResultTableName,TotalLength");
            sbSql.Append(") values('");

            sbSql.Append(data.LineName).Append("','").Append(data.TrainCode).Append("',");
            sbSql.Append("'").Append(data.GeoFileName).Append("','");
            sbSql.Append(data.ResultTableName).Append("'");
            sbSql.Append(",'").Append(data.TotalLength).Append("'");
            sbSql.Append(")");
            bool i= _dbOperator.ExcuteSql(sbSql.ToString());
            //int i = DataAccess.AccessHelper.Run_SQL(sbSql.ToString(), connStr);
            if (i)
            {
                isok = true;
            }

            return isok;
        }


        public List<TotalFile> GetList()
        {
            List<TotalFile> list = new List<TotalFile>();
            DataTable dt = DataAccess.AccessHelper.Get_DataTable("select * from TotalResult order by ID ", connStr, "OverValueDataResult");
            list = DataTableToList_TotalFile(dt);

            return list;
        }

        public List<TotalFile> GetList(string lineName,string trainCode)
        {
            List<TotalFile> list = new List<TotalFile>();
            string filter = string.Empty;
            if (!string.IsNullOrEmpty(lineName))
            {
                filter = "LineName = '" + lineName + "'";
            }
            if(!string.IsNullOrEmpty(trainCode))
            {
                if(!string.IsNullOrEmpty(filter))
                {
                    filter += " and TrainCode = '" + trainCode + "'";
                }
                else
                {
                    filter += "TrainCode = '" + trainCode + "'";
                }
            }
            string sql = "";
            if(!string.IsNullOrEmpty(filter))
            {
                sql = "select* from TotalResult where " + filter + " order by ID ";
            }
            else
            {
                sql = "select * from TotalResult  order by ID ";
            }
            DataTable dt = DataAccess.AccessHelper.Get_DataTable(sql, connStr, "OverValueDataResult");
            list = DataTableToList_TotalFile(dt);

            return list;
        }

        public bool Delete(string tableName)
        {
            int i = DataAccess.AccessHelper.Run_SQL("delete from TotalResult where ResultTableName ='" + tableName + "'", connStr);
            if (i > 0)
            {
                DataAccess.AccessHelper.Run_SQL("drop table " + tableName, connStr);
                
                return true;
            }
            return false;
        }

        private List<TotalFile> DataTableToList_TotalFile(DataTable dt)
        {
            List<TotalFile> list = new List<TotalFile>();
            if (dt != null)
            {

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    TotalFile paramter = new TotalFile();

                    if (dt.Rows[i]["ID"] != null)
                    {
                        paramter.ID = Convert.ToInt32(dt.Rows[i]["ID"]);
                    }

                    if (dt.Rows[i]["LineName"] != null)
                    {
                        paramter.LineName = dt.Rows[i]["LineName"].ToString();
                    }

                    if (dt.Rows[i]["TrainCode"] != null)
                    {
                        paramter.TrainCode = dt.Rows[i]["TrainCode"].ToString();
                    }

                    if (dt.Rows[i]["GeoFileName"] != null)
                    {
                        paramter.GeoFileName = dt.Rows[i]["GeoFileName"].ToString();
                    }

                    if (dt.Rows[i]["ResultTableName"] != null)
                    {
                        paramter.ResultTableName = dt.Rows[i]["ResultTableName"].ToString();
                    }

                    if (dt.Rows[i]["TotalLength"] != null && dt.Rows[i]["TotalLength"].ToString() != "")
                    {
                        paramter.TotalLength = double.Parse(dt.Rows[i]["TotalLength"].ToString());
                    }

                    list.Add(paramter);
                }
            }

            return list;
        }

        /// <summary>
        /// 根据ID删除数据
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public bool DeleteResultRow(string tableName)
        {
            int i = DataAccess.AccessHelper.Run_SQL("delete from TotalResult where ResultTableName ='" + tableName + "'", connStr);
            if (i > 0)
            {
                DataAccess.AccessHelper.Run_SQL("drop table " + tableName, connStr);

                return true;
            }
            return false;
        }

    }
}

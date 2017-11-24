using DataAccess;
using MileageCheckTools.Common;
using MileageCheckTools.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MileageCheckTools.DAL
{
    public class JumpPointsDAL
    {
        public static string connStr = ConfigHelper.GetAccessDbConn("", "data.mdb");

        public JumpPointsDAL(string fileFullPath)
        {
            connStr = ConfigHelper.GetAccessDbConn(1, fileFullPath);
        }



        public bool Add(JumpPoints data,string tableName)
        {
            bool isok = false;

            StringBuilder sbSql = new StringBuilder();
            sbSql.Append("insert into " + tableName + " (");
            sbSql.Append("ID,CurrentMileage,");
            sbSql.Append("CurrentSample,LastMileage,LastSample,DiffSample,DiffMileage");
            sbSql.Append(") values(");

            sbSql.Append(data.ID).Append(",");
            sbSql.Append(data.CurrentMileage).Append(",");
            sbSql.Append(data.CurrentSample).Append(",");
            sbSql.Append(data.LastMileage).Append(",");
            sbSql.Append(data.LastSample).Append(",");
            sbSql.Append(data.DiffSample).Append(",");
            sbSql.Append(data.DiffMileage).Append("");

            sbSql.Append(")");

            int i = DataAccess.AccessHelper.Run_SQL(sbSql.ToString(), connStr);
            if (i > 0)
            {
                isok = true;
            }

            return isok;
        }

        public void DeleteAll(string tableName)
        {
            DataAccess.AccessHelper.Run_SQL("delete from " + tableName, connStr);
        }

        public List<JumpPoints> Load(string tableName)
        {
            List<JumpPoints> data = new List<JumpPoints>();
            DataTable dt= DataAccess.AccessHelper.Get_DataTable("select * from " + tableName, connStr, tableName);
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    JumpPoints jumpPoint = new JumpPoints();
                    jumpPoint.ID = int.Parse(dt.Rows[i]["ID"].ToString());
                    jumpPoint.CurrentMileage = double.Parse(dt.Rows[i]["CurrentMileage"].ToString());
                    jumpPoint.CurrentSample= double.Parse(dt.Rows[i]["CurrentSample"].ToString());
                    jumpPoint.LastMileage= double.Parse(dt.Rows[i]["LastMileage"].ToString());
                    jumpPoint.LastSample= double.Parse(dt.Rows[i]["LastSample"].ToString());
                    jumpPoint.DiffSample = double.Parse(dt.Rows[i]["DiffSample"].ToString());
                    jumpPoint.DiffMileage = double.Parse(dt.Rows[i]["DiffMileage"].ToString());
                    data.Add(jumpPoint);
                }

            }
            return data;
        }

        public void CreateTable(string dataDbPath, string tableName)
        {
            //ADOX.Column[] columns = {
            //                                new ADOX.Column(){Name="ID",Type=ADOX.DataTypeEnum.adInteger,DefinedSize=0},
            //                                     new ADOX.Column(){Name="CurrentMileage",Type=ADOX.DataTypeEnum.adDouble,DefinedSize=0},
            //                                     new ADOX.Column(){Name="CurrentSample",Type=ADOX.DataTypeEnum.adDouble,DefinedSize=0},
            //                                     new ADOX.Column(){Name="LastMileage",Type=ADOX.DataTypeEnum.adDouble,DefinedSize=0},
            //                                     new ADOX.Column(){Name="LastSample",Type=ADOX.DataTypeEnum.adDouble,DefinedSize=0},
            //                                     new ADOX.Column(){Name="DiffSample",Type=ADOX.DataTypeEnum.adDouble,DefinedSize=0},
            //                                     new ADOX.Column(){Name="DiffMileage",Type=ADOX.DataTypeEnum.adDouble,DefinedSize=0}
            //                                 };


            //DataAccess.AccessHelper.CreateAccessTable(dataDbPath, tableName, columns);
            //DbOperator d = new DbOperator();
            IOperator dbopertor = new DbOperator();
            dbopertor.DbFilePath = dataDbPath;
            string cmd = "create table " + tableName + "(ID long,CurrentMileage float,CurrentSample float,LastMileage float,LastSample float,DiffSample float,DiffMileage float)";
            dbopertor.CheckAndCreateTable(tableName, cmd);
        }

        public void DeleteOne(string tableName,string whereStr)
        {
            DataAccess.AccessHelper.Run_SQL("delete from " + tableName+" "+whereStr, connStr);
        }

    }
}

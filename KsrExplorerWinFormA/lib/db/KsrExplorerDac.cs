using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlServerCe;

namespace KsrExplorerWinFormA
{
    public class KsrExplorerDac
    {


        private DataTable ConvertDataReaderToTableManually()
        {
            SqlCeConnection conn = null;
            try
            {
                //string connString = ConfigurationManager.ConnectionStrings["NorthwindConn"].ConnectionString;
                string connString = "";
                conn = new SqlCeConnection(connString);
                string query = "SELECT * FROM Customers";
                SqlCeCommand cmd = new SqlCeCommand(query, conn);
                conn.Open();
                SqlCeDataReader MyReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable MyDataTable = new DataTable();

                MyDataTable.Load(MyReader);
                return MyDataTable;

                /*DataTable dtSchema = dr.GetSchemaTable();
                DataTable dt = new DataTable();
                // You can also use an ArrayList instead of List<>
                List<DataColumn> listCols = new List<DataColumn>();

                if (dtSchema != null)
                {
                    foreach (DataRow drow in dtSchema.Rows)
                    {
                        string columnName = System.Convert.ToString(drow["ColumnName"]);
                        DataColumn column = new DataColumn(columnName, (Type)(drow["DataType"]));
                        column.Unique = (bool)drow["IsUnique"];
                        column.AllowDBNull = (bool)drow["AllowDBNull"];
                        column.AutoIncrement = (bool)drow["IsAutoIncrement"];
                        listCols.Add(column);
                        dt.Columns.Add(column);
                    }
                }

                // Read rows from DataReader and populate the DataTable
                while (dr.Read())
                {
                    DataRow dataRow = dt.NewRow();
                    for (int i = 0; i < listCols.Count; i++)
                    {
                        dataRow[((DataColumn)listCols[i])] = dr[i];
                    }
                    dt.Rows.Add(dataRow);
                }
                //GridView2.DataSource = dt;
                //GridView2.DataBind();
                 */
            }
            catch (SqlCeException ex)
            {
                // handle error
                throw;
            }
            catch (Exception ex)
            {
                // handle error
                throw;
            }
            finally
            {
                conn.Close();
            }

        }

    }
}

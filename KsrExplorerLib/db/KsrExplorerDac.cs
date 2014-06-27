#define DEBUG_x
#define DB_SQLITE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using KsrExplorerLib.config;
#if (DB_SQLCE)
using System.Data.SqlServerCe;
#elif (DB_SQLITE)
using System.Data.SQLite;
#elif (DB_DEFAULT)

#endif

namespace KsrExplorerLib.db
{
    public class KsrExplorerDac
    {
        #region CREATE TABLE T_FILE_LIST 테이블생성
        public static int CreateTableT_FILE_LIST()
        {
            #if (DB_SQLCE)
            // 데이터베이스 연결
            //string connectionString = @"Data Source=C:\ksr_cshop\KsrExplorer\KsrExplorerDB\KsrExplorerDB.sdf;Password=12341234;Persist Security Info=False;";
            SqlCeConnection con = new SqlCeConnection(KsrExplorerLib.config.KsrExplorerConfigUtil.DSN_KsrExplorer());
            con.Open();

            // 데이터베이스 커맨드 생성
            SqlCeCommand cmd = new SqlCeCommand();

            // 커맨드에 커넥션을 연결
            cmd.Connection = con;
            try
            {
                // 트랜잭션 생성
                SqlCeTransaction tran = con.BeginTransaction();
                cmd.Transaction = tran;

                StringBuilder sbSql = new StringBuilder();
                sbSql.Append("CREATE TABLE T_FILE_LIST ( ")
                    .Append("FILE_NO BIGINT IDENTITY(1,1) NOT NULL, ")
                    .Append("FILE_PATH NVARCHAR(500) NOT NULL, ")
                    .Append("FILE_NAME NVARCHAR(200) NOT NULL, ")
                    .Append("FILE_SIZE BIGINT NOT NULL, ")
                    .Append("FILE_CREATE_DATE DATETIME, ")
                    .Append("FILE_MODIFY_DATE DATETIME, ")
                    .Append("REG_DATE DATETIME,")
                    .Append("PRIMARY KEY (FILE_NO) ")
                    .Append(")");
                // 쿼리 생성 : Insert 쿼리
                cmd.CommandText = sbSql.ToString();

                // 쿼리 실행
                cmd.ExecuteNonQuery();

                // 커밋
                tran.Commit();
            }
            catch (Exception)
            {
            }

            // SELECT 쿼리로 변경
            cmd.CommandText = "SELECT count(*) TCNT FROM T_FILE_LIST";

            // DataReader에 쿼리 결과값 저장
            SqlCeDataReader reader = cmd.ExecuteReader();

            int iResult = -1;
            // 결과값 출력
            while (reader.Read())
            {
                //Console.WriteLine(reader["TCNT"]);
                iResult = Convert.ToInt32(reader["TCNT"]);
            }

            con.Close();
            return iResult;
#elif (DB_SQLITE)

            SQLiteConnection m_dbConnection = new SQLiteConnection(KsrExplorerConfigUtil.DSN_KsrExplorer());
            m_dbConnection.Open();
            //string sql = "create table highscores (name varchar(50), score int)";

            StringBuilder sbSql = new StringBuilder();
            sbSql.Append("CREATE TABLE T_FILE_LIST ( ")
                .Append("FILE_NO INTEGER PRIMARY KEY AUTOINCREMENT, ")
                .Append("FILE_PATH TEXT NOT NULL, ")
                .Append("FILE_NAME TEXT NOT NULL, ")
                .Append("FILE_SIZE INTEGER NOT NULL, ")
                .Append("FILE_CREATE_DATE TEXT, ")
                .Append("FILE_MODIFY_DATE TEXT, ")
                .Append("REG_DATE TEXT")
                .Append(")");

            SQLiteCommand command = new SQLiteCommand(sbSql.ToString(), m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Close();

            return 1;

#elif (DB_DEFAULT)
            return 1;
#endif



        } 
        #endregion

        public static int InsertT_FILE_LIST(
            string FILE_PATH, string FILE_NAME
            , Int64 FILE_SIZE
            , string FILE_CREATE_DATE
            , string FILE_MODIFY_DATE
            )
        {
#if (DB_SQLCE)
            int iResult = -1;
            SqlCeConnection con = new SqlCeConnection(KsrExplorerLib.config.KsrExplorerConfigUtil.DSN_KsrExplorer());
            con.Open();

            // 데이터베이스 커맨드 생성
            SqlCeCommand cmd = new SqlCeCommand();

            // 커맨드에 커넥션을 연결
            cmd.Connection = con;
            try
            {
                StringBuilder sbSql = new StringBuilder();
                sbSql.Append("INSERT INTO T_FILE_LIST ")
                    .Append("( FILE_PATH,FILE_NAME,FILE_SIZE,FILE_CREATE_DATE,FILE_MODIFY_DATE,REG_DATE ) VALUES ")
                    .Append("( @FILE_PATH,@FILE_NAME,@FILE_SIZE,@FILE_CREATE_DATE,@FILE_MODIFY_DATE ,GETDATE()) ");
                // 쿼리 생성 : Insert 쿼리
                cmd.CommandText = sbSql.ToString();
                cmd.Parameters.Add(new SqlCeParameter("@FILE_PATH", SqlDbType.NVarChar, 500)).Value = FILE_PATH;
                cmd.Parameters.Add(new SqlCeParameter("@FILE_NAME", SqlDbType.NVarChar, 200)).Value = FILE_NAME;
                cmd.Parameters.Add(new SqlCeParameter("@FILE_SIZE", SqlDbType.BigInt)).Value = FILE_SIZE;
                cmd.Parameters.Add(new SqlCeParameter("@FILE_CREATE_DATE", SqlDbType.DateTime)).Value = FILE_CREATE_DATE;
                cmd.Parameters.Add(new SqlCeParameter("@FILE_MODIFY_DATE", SqlDbType.DateTime)).Value = FILE_MODIFY_DATE;

                // 쿼리 실행
                iResult = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally {
                con.Close();
            }

            
            
            return iResult;
#elif (DB_SQLITE)

            string REG_DATE = String.Format("{0:yyyy-M-d HH:mm:ss}", DateTime.Now);
            SQLiteConnection m_dbConnection = new SQLiteConnection(KsrExplorerConfigUtil.DSN_KsrExplorer());
            m_dbConnection.Open();
            //string sql = "create table highscores (name varchar(50), score int)";

            StringBuilder sbSql = new StringBuilder();
            sbSql.Append("INSERT INTO T_FILE_LIST ")
                .Append("( FILE_PATH,FILE_NAME,FILE_SIZE,FILE_CREATE_DATE,FILE_MODIFY_DATE,REG_DATE ) VALUES ")
                .Append("( @FILE_PATH,@FILE_NAME,@FILE_SIZE,@FILE_CREATE_DATE,@FILE_MODIFY_DATE ,@REG_DATE) ");
            // 쿼리 생성 : Insert 쿼리
            SQLiteCommand cmd = new SQLiteCommand(sbSql.ToString(), m_dbConnection);
            cmd.CommandText = sbSql.ToString();

            cmd.Parameters.AddWithValue("@FILE_PATH", FILE_PATH);
            cmd.Parameters.AddWithValue("@FILE_NAME", FILE_NAME);
            cmd.Parameters.AddWithValue("@FILE_SIZE", FILE_SIZE);
            cmd.Parameters.AddWithValue("@FILE_CREATE_DATE", FILE_CREATE_DATE);
            cmd.Parameters.AddWithValue("@FILE_MODIFY_DATE", FILE_MODIFY_DATE);
            cmd.Parameters.AddWithValue("@REG_DATE", REG_DATE);
            

            // 쿼리 실행
            int iResult = cmd.ExecuteNonQuery();


            m_dbConnection.Close();

            return iResult;
#elif (DB_DEFAULT)
            return 1;
#endif

        }

        //delete
        public static int DeleteT_All_FILE_LIST()
        {
#if (DB_SQLCE)
            int iResult = -1;
            SqlCeConnection con = new SqlCeConnection(KsrExplorerLib.config.KsrExplorerConfigUtil.DSN_KsrExplorer());
            con.Open();

            // 데이터베이스 커맨드 생성
            SqlCeCommand cmd = new SqlCeCommand();

            // 커맨드에 커넥션을 연결
            cmd.Connection = con;
            try
            {
                StringBuilder sbSql = new StringBuilder();
                sbSql.Append("DELETE FROM T_FILE_LIST ");
                // 쿼리 생성 : Insert 쿼리
                cmd.CommandText = sbSql.ToString();

                // 쿼리 실행
                iResult = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }



            return iResult;
#elif (DB_SQLITE)
            return 1;
#elif (DB_DEFAULT)
            return 1;
#endif


        }

        public static void InsertSampleT_FILE_LIST()
        {
#if (DB_SQLCE)
            // 데이터베이스 연결
            //string connectionString = @"Data Source=C:\ksr_cshop\KsrExplorer\KsrExplorerDB\KsrExplorerDB.sdf;Password=12341234;Persist Security Info=False;";
            SqlCeConnection con = new SqlCeConnection(KsrExplorerLib.config.KsrExplorerConfigUtil.DSN_KsrExplorer());
            con.Open();

            // 데이터베이스 커맨드 생성
            SqlCeCommand cmd = new SqlCeCommand();

            // 커맨드에 커넥션을 연결
            cmd.Connection = con;
            try
            {
                // 트랜잭션 생성
                SqlCeTransaction tran = con.BeginTransaction();
                cmd.Transaction = tran;

                StringBuilder sbSql = new StringBuilder();
                sbSql.Append("INSERT INTO T_FILE_LIST ")
                    .Append("( FILE_PATH,FILE_NAME,FILE_SIZE,FILE_CREATE_DATE,FILE_MODIFY_DATE,REG_DATE ) VALUES ")
                    //.Append("( @FILE_PATH,@FILE_NAME,@FILE_SIZE,@FILE_CREATE_DATE,@FILE_MODIFY_DATE,GETDATE()) ");
                    .Append("( 'aa','bb',@FILE_SIZE,getdate(),getdate(),GETDATE()) ");
                // 쿼리 생성 : Insert 쿼리
                cmd.CommandText = sbSql.ToString();
                //cmd.Parameters.Add((new SqlCeParameter("FILE_PATH", SqlDbType.NVarChar, 500)).Value = "aa");
                //cmd.Parameters.Add((new SqlCeParameter("FILE_NAME", SqlDbType.NVarChar, 200)).Value = "aa");
                //cmd.Parameters.Add((new SqlCeParameter("FILE_SIZE", SqlDbType.BigInt)).Value = 1123);

                cmd.Parameters.Add(new SqlCeParameter("@FILE_SIZE", SqlDbType.BigInt) ).Value=1234;
                //cmd.Parameters.Add(new SqlCeParameter("FILE_SIZE", 1233));
                //cmd.Parameters.Add((new SqlCeParameter("FILE_CREATE_DATE", SqlDbType.DateTime)).Value = "2014-04-01");
                //cmd.Parameters.Add((new SqlCeParameter("FILE_MODIFY_DATE", SqlDbType.DateTime)).Value = "2014-05-02 03:04:22");

                // 쿼리 실행
                cmd.ExecuteNonQuery();

                // 커밋
                tran.Commit();
            }
            catch (Exception e)
            {
                throw;
            }

            // SELECT 쿼리로 변경
            cmd.CommandText = "SELECT count(*) TCNT FROM T_FILE_LIST";

            // DataReader에 쿼리 결과값 저장
            SqlCeDataReader reader = cmd.ExecuteReader();

            int iResult = -1;
            // 결과값 출력
            while (reader.Read())
            {
                //Console.WriteLine(reader["TCNT"]);
                iResult = Convert.ToInt32(reader["TCNT"]);
            }

            con.Close();
#elif (DB_SQLITE)

#elif (DB_DEFAULT)

#endif

        }

        public static int CountT_FILE_LIST(string searchWord, Int64 searchFileSizeS, Int64 searchFileSizeE)
        {
            searchWord = searchWord.Trim();
            SQLiteConnection m_dbConnection = new SQLiteConnection(KsrExplorerConfigUtil.DSN_KsrExplorer());
            m_dbConnection.Open();

            StringBuilder sbSql = new StringBuilder("SELECT COUNT(*) TCNT ");
            sbSql.Append("FROM T_FILE_LIST ");
            sbSql.Append(WhereT_FILE_LIST(searchWord, searchFileSizeS, searchFileSizeE));
            //sbSql.Append("OFFSET 20 ROWS ");
            //sbSql.Append("FETCH NEXT 10 ROWS ONLY");
            

            SQLiteCommand cmd = new SQLiteCommand(sbSql.ToString(), m_dbConnection);
            cmd.CommandText = sbSql.ToString();

            //cmd.Parameters.AddWithValue("@FILE_PATH", FILE_PATH);


            int count = Convert.ToInt32(cmd.ExecuteScalar());

            m_dbConnection.Close();
            return count;
        }

        private static string WhereT_FILE_LIST(string searchWord, Int64 searchFileSizeS, Int64 searchFileSizeE)
        {
            StringBuilder sbWhere = new StringBuilder();
            sbWhere.Append("WHERE 1=1 ");
            if (searchWord.Length > 0)
            {
                if (searchWord.IndexOf(" ") > -1)
                {
                    sbWhere.Append(" AND ( ");
                    string[] arrSearchWord = searchWord.Split(' ');
                    for (int i = 0; i < arrSearchWord.Length; i++)
                    {
                        if (i > 0)
                        {
                            sbWhere.Append(" AND ");
                        }
                        sbWhere.Append("FILE_PATH LIKE '%");
                        sbWhere.Append(arrSearchWord[i]);
                        sbWhere.Append("%' ");
                    }
                    sbWhere.Append(") ");
                }
                else
                {
                    sbWhere.Append("AND FILE_PATH LIKE '%");
                    sbWhere.Append(searchWord);
                    sbWhere.Append("%' ");
                }
            }
            if (searchFileSizeS > 0)
            {
                sbWhere.Append("AND FILE_SIZE > ");
                sbWhere.Append(searchFileSizeS+"");
                sbWhere.Append(" ");
            }
            if (searchFileSizeE > 0)
            {
                sbWhere.Append("AND FILE_SIZE < ");
                sbWhere.Append(searchFileSizeE + "");
                sbWhere.Append(" ");
            }

            return sbWhere.ToString();
        }
        public static KsrExplorerDefaultPagingEntity SelectT_FILE_LIST(int PageSize, int CurrPage,string searchWord,string orderBy
            , Int64 searchFileSizeS, Int64 searchFileSizeE
            )
        {

            KsrExplorerDefaultPagingEntity result = new KsrExplorerDefaultPagingEntity();
#if (DB_SQLCE)
            SqlCeConnection conn = null;
            try
            {
                //string connString = ConfigurationManager.ConnectionStrings["NorthwindConn"].ConnectionString;
                conn = new SqlCeConnection(KsrExplorerLib.config.KsrExplorerConfigUtil.DSN_KsrExplorer());
                //string query = " ";
                StringBuilder sbSql = new StringBuilder("SELECT FILE_NO,FILE_PATH,FILE_NAME,FILE_SIZE,FILE_CREATE_DATE,FILE_MODIFY_DATE,REG_DATE ");
                sbSql.Append("FROM T_FILE_LIST ");
                sbSql.Append("ORDER BY FILE_NO DESC ");
                sbSql.Append("OFFSET 20 ROWS ");
                sbSql.Append("FETCH NEXT 10 ROWS ONLY");
                sbSql.Append("");
                sbSql.Append("");
                SqlCeCommand cmd = new SqlCeCommand(sbSql.ToString(), conn);
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
#elif (DB_SQLITE)
            CurrPage = (CurrPage - 1) * PageSize;
            SQLiteConnection m_dbConnection = new SQLiteConnection(KsrExplorerConfigUtil.DSN_KsrExplorer());
            m_dbConnection.Open();
            //string sql = "create table highscores (name varchar(50), score int)";

            StringBuilder sbSql = new StringBuilder("SELECT FILE_NO,FILE_PATH,FILE_NAME,FILE_SIZE,FILE_CREATE_DATE,FILE_MODIFY_DATE,REG_DATE ");
            sbSql.Append("FROM T_FILE_LIST ");
            sbSql.Append(WhereT_FILE_LIST(searchWord, searchFileSizeS, searchFileSizeE));

            string sqlOrderby = "";
            if (orderBy.Length > 0) {
                if (orderBy.Equals("파일명asc"))
                {
                    sqlOrderby = "FILE_NAME ";
                }
                else if (orderBy.Equals("파일명desc")) {
                    sqlOrderby = "FILE_NAME DESC ";
                }

                else if (orderBy.Equals("파일크기asc"))
                {
                    sqlOrderby = "FILE_SIZE ";
                }
                else if (orderBy.Equals("파일크기desc"))
                {
                    sqlOrderby = "FILE_SIZE DESC ";
                }

                else if (orderBy.Equals("파일경로asc"))
                {
                    sqlOrderby = "FILE_PATH ";
                }
                else if (orderBy.Equals("파일경로desc"))
                {
                    sqlOrderby = "FILE_PATH DESC ";
                }
                
            }
            if (sqlOrderby.Length > 0) {
                sbSql.Append("ORDER BY " + sqlOrderby+" ");
            }
            
            //sbSql.Append("OFFSET 20 ROWS ");
            //sbSql.Append("FETCH NEXT 10 ROWS ONLY");
            sbSql.Append("LIMIT ");
            sbSql.Append(CurrPage + "");
            sbSql.Append(" , ");
            sbSql.Append(PageSize+"");

            SQLiteCommand cmd = new SQLiteCommand(sbSql.ToString(), m_dbConnection);
            cmd.CommandText = sbSql.ToString();

            //cmd.Parameters.AddWithValue("@FILE_PATH", FILE_PATH);


            SQLiteDataReader MyReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            DataTable MyDataTable = new DataTable();

            MyDataTable.Load(MyReader);

            result.dt_list = MyDataTable;

            m_dbConnection.Close();

            return result;
#elif (DB_DEFAULT)
            return null;
#endif
        }

    }
}

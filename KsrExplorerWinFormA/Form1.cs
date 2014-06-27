using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Configuration;
using System.Data.SQLite;

namespace KsrExplorerWinFormA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 데이터베이스 연결
            string connectionString = @"Data Source=C:\ksr_cshop\KsrExplorer\KsrExplorerDB\KsrExplorerDB.sdf;Password=12341234;Persist Security Info=False;";
            SqlCeConnection con = new SqlCeConnection(connectionString);
            con.Open();

            // 데이터베이스 커맨드 생성
            SqlCeCommand cmd = new SqlCeCommand();

            // 커맨드에 커넥션을 연결
            cmd.Connection = con;

            // 트랜잭션 생성
            SqlCeTransaction tran = con.BeginTransaction();
            cmd.Transaction = tran;


            // 쿼리 생성 : Insert 쿼리
            cmd.CommandText = "INSERT INTO Test VALUES('소녀시대')";

            // 쿼리 실행
            cmd.ExecuteNonQuery();

            // 반복으로 몇개 더 넣어보겠습니다.
            cmd.CommandText = "INSERT INTO Test VALUES('원더걸스')";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO Test VALUES('카라')";
            cmd.ExecuteNonQuery();

            // 커밋
            tran.Commit();

            // SELECT 쿼리로 변경
            cmd.CommandText = "SELECT * FROM Test";

            // DataReader에 쿼리 결과값 저장
            SqlCeDataReader reader = cmd.ExecuteReader();

            // 결과값 출력
            while (reader.Read())
            {
                Console.WriteLine(reader["Name"]);
            }

            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 데이터베이스 연결
            string connectionString = @"Data Source=C:\ksr_cshop\KsrExplorer\KsrExplorerDB\KsrExplorerDB.sdf;Password=12341234;Persist Security Info=False;";
            SqlCeConnection con = new SqlCeConnection(connectionString);
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

            // 결과값 출력
            while (reader.Read())
            {
                //Console.WriteLine(reader["TCNT"]);
                lblTCNT.Text = reader["TCNT"] + "";
            }

            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = KsrExplorerSectionConfiguration.Instance.OptA + "";
            textBox1.Text += "\r\n" + KsrExplorerSectionConfiguration.Instance.ExternalUrl.UrlA + "";
            textBox1.Text += "\r\n" + ConfigurationManager.ConnectionStrings["DSN_KsrExplorer"].ConnectionString + "";
            textBox1.Text += "\r\n" + KsrExplorerLib.config.KsrExplorerConfigUtil.DSN_KsrExplorer() + "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KsrExplorerLib.db.KsrExplorerDac.InsertSampleT_FILE_LIST();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = KsrExplorerLib.db.KsrExplorerDac.SelectT_FILE_LIST(10);
        }

        private void button6_Click(object sender, EventArgs e)
        {

            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(textBox4.Text);
            foreach (System.IO.FileInfo f in di.GetFiles()) {

                KsrExplorerLib.db.KsrExplorerDac.InsertT_FILE_LIST(f.FullName, f.Name, Convert.ToInt32(f.Length)
                    , String.Format("{0:yyyy-M-d HH:mm:ss}", f.CreationTime)
                    , String.Format("{0:yyyy-M-d HH:mm:ss}", f.LastWriteTime)
                    );
                textBox1.Text += f.Name;
                textBox1.Text += " $ ";
                textBox1.Text += f.FullName;

                string dt = String.Format("{0:yyyy-M-d HH:mm:ss}", f.CreationTime);
                textBox1.Text += " $ ";
                textBox1.Text += dt;
                textBox1.Text += " $ ";
                textBox1.Text += f.LastWriteTime;
                
                textBox1.Text += "\r\n";
            }
            //textBox4.Text

        }
    }
}

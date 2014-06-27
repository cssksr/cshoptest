using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KsrExplorerLib.config;

namespace KsrExplorerWinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private Int64 getSearchFileSize(string searchFileSize)
        {
            Int64 iSearchFileSize = -1;
            if (searchFileSize.Length > 0)
            {
                iSearchFileSize = Convert.ToInt64(searchFileSize);
                string fileUnit = comboBoxFileUnit.Items[comboBoxFileUnit.SelectedIndex].ToString();
                iSearchFileSize = KsrExplorerLib.util.FileUtil.getFileSize(iSearchFileSize, fileUnit);
            }
            return iSearchFileSize;
        }
        private void MainSelectT_FILE_LIST()
        {
            string OrderBy = "";
            if (comboBoxOrderBy.SelectedIndex > 0) {
                OrderBy = comboBoxOrderBy.Items[comboBoxOrderBy.SelectedIndex].ToString();
            }
            Int64 searchFileSizeS = getSearchFileSize(tbSearchFileSizeS.Text);
            Int64 searchFileSizeE = getSearchFileSize(tbSearchFileSizeE.Text);

            MainSelectT_FILE_LIST(Convert.ToInt32(tbPageSize.Text), Convert.ToInt32(tbCurrPage.Text)
                , tbMainSearchWord.Text
                , OrderBy, searchFileSizeS, searchFileSizeE
                );
        }
        private void MainSelectT_FILE_LIST(int PageSize, int CurrPage, string SearchWord, string OrderBy, Int64 SearchFileSizeS, Int64 SearchFileSizeE)
        {
            dataGridViewMain.DataSource = KsrExplorerLib.db.KsrExplorerDac.SelectT_FILE_LIST(PageSize, CurrPage, SearchWord, OrderBy, SearchFileSizeS, SearchFileSizeE).dt_list;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            tbCurrPage.Text = "1";
            Int64 searchFileSizeS = getSearchFileSize(tbSearchFileSizeS.Text);
            Int64 searchFileSizeE = getSearchFileSize(tbSearchFileSizeE.Text);
            lblTotalCount.Text = KsrExplorerLib.db.KsrExplorerDac.CountT_FILE_LIST(tbMainSearchWord.Text, searchFileSizeS, searchFileSizeE) + "/" + gMainTotalCount;
            //CountT_FILE_LIST
            MainSelectT_FILE_LIST();
        }

        private void btnReIndex_Click(object sender, EventArgs e)
        {
            //일단 전체 파일삭제
            KsrExplorerLib.db.KsrExplorerDac.DeleteT_All_FILE_LIST();

            //다시 파일 삽입
            KsrExplorerLib.biz.KsrExplorerBiz ksrExplorerBiz = new KsrExplorerLib.biz.KsrExplorerBiz();
            string[] dirs = new string[listBox1.Items.Count];
            //dirs[0] = @"D:\ebay_ksr\서버정보";
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                dirs[i] = listBox1.Items[i].ToString();
            }
            ksrExplorerBiz.FileInfoToDbInsertMain(dirs);

            MainSelectT_FILE_LIST();
        }

        private void dataGridViewMain_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("a");
            if (e.RowIndex > -1) {
                tbDetailFilePath.Text = dataGridViewMain.Rows[e.RowIndex].Cells["FILE_PATH"].Value.ToString();
            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ConfigDataLoad();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBoxOrderBy.SelectedIndex = 0;//정렬
            comboBoxFileUnit.SelectedIndex = 2;//MB

            ConfigDataLoad();
        }
        int gMainTotalCount = 0;
        private void ConfigDataLoad()
        {
            listBox1.Items.Clear();
            
            for (int i = 0; i < KsrExplorerSectionConfiguration.Instance.FolderItems.Count; i++)
            {
                listBox1.Items.Add(KsrExplorerSectionConfiguration.Instance.FolderItems[i].FolPath + "");
            }
            listBox2.Items.Clear();
            for (int i = 0; i < KsrExplorerSectionConfiguration.Instance.SearchWordItems.Count; i++)
            {
                listBox2.Items.Add(KsrExplorerSectionConfiguration.Instance.SearchWordItems[i].DefaultSearchWord + "");
            }

            tbPageSize.Text = KsrExplorerSectionConfiguration.Instance.MainPageSize + "";

            try
            {
                gMainTotalCount = KsrExplorerLib.db.KsrExplorerDac.CountT_FILE_LIST("", -1, -1);//총건수 셋팅
            }
            catch (Exception)
            {
                gMainTotalCount = -9;
            }

        }

        private void btnDBFileCreate_Click(object sender, EventArgs e)
        {
            KsrExplorerLib.biz.KsrExplorerBiz biz = new KsrExplorerLib.biz.KsrExplorerBiz();
            biz.SqliteDbFileCreate();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnMainNextPage_Click(object sender, EventArgs e)
        {
            if (dataGridViewMain.Rows.Count < 1)
            {
                MessageBox.Show("마지막입니다." + dataGridViewMain.Rows.Count);
            }
            else
            {
                int iCurrpage = Convert.ToInt32(tbCurrPage.Text) + 1;

                tbCurrPage.Text = iCurrpage + "";
                MainSelectT_FILE_LIST();
            }
        }

        private void btnMainPrevPage_Click(object sender, EventArgs e)
        {

            int iCurrpage = Convert.ToInt32(tbCurrPage.Text) - 1;
            if (iCurrpage < 1)
            {
                iCurrpage = 1;
                MessageBox.Show("처음입니다.");
            }
            else
            {
                tbCurrPage.Text = iCurrpage + "";
                MainSelectT_FILE_LIST();
            }

            
            
            //MainSelectT_FILE_LIST(int PageSize, int CurrPage,string SearchWord)
        }

        private void listBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox2.SelectedIndex > -1)
            {
                tbMainSearchWord.Text = listBox2.Items[listBox2.SelectedIndex].ToString();
            }
            
        }

        

    }
}

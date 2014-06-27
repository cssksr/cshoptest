namespace KsrExplorerWinForm
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.FILE_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FILE_PATH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FILE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FILE_SIZE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FILE_CREATE_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FILE_MODIFY_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REG_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxOrderBy = new System.Windows.Forms.ComboBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnMainNextPage = new System.Windows.Forms.Button();
            this.btnMainPrevPage = new System.Windows.Forms.Button();
            this.tbCurrPage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalPage = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbDetailFilePath = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPageSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxFileUnit = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSearchFileSizeE = new System.Windows.Forms.TextBox();
            this.tbSearchFileSizeS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnReIndex = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbMainSearchWord = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDBFileCreate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(993, 694);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(985, 668);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewMain);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(979, 662);
            this.splitContainer1.SplitterDistance = 242;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listBox1);
            this.splitContainer2.Panel1.Controls.Add(this.panel7);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listBox2);
            this.splitContainer2.Size = new System.Drawing.Size(242, 662);
            this.splitContainer2.SplitterDistance = 280;
            this.splitContainer2.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(0, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(242, 254);
            this.listBox1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnRefresh);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(242, 26);
            this.panel7.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 1);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "새로고침";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(0, 0);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(242, 378);
            this.listBox2.TabIndex = 0;
            this.listBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseClick);
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AllowUserToDeleteRows = false;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FILE_NO,
            this.FILE_PATH,
            this.FILE_NAME,
            this.FILE_SIZE,
            this.FILE_CREATE_DATE,
            this.FILE_MODIFY_DATE,
            this.REG_DATE});
            this.dataGridViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMain.Location = new System.Drawing.Point(0, 31);
            this.dataGridViewMain.MultiSelect = false;
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.ReadOnly = true;
            this.dataGridViewMain.RowTemplate.Height = 23;
            this.dataGridViewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMain.Size = new System.Drawing.Size(733, 481);
            this.dataGridViewMain.TabIndex = 3;
            this.dataGridViewMain.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMain_RowEnter);
            // 
            // FILE_NO
            // 
            this.FILE_NO.DataPropertyName = "FILE_NO";
            this.FILE_NO.FillWeight = 50F;
            this.FILE_NO.HeaderText = "FILE_NO";
            this.FILE_NO.Name = "FILE_NO";
            this.FILE_NO.ReadOnly = true;
            this.FILE_NO.Width = 50;
            // 
            // FILE_PATH
            // 
            this.FILE_PATH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FILE_PATH.DataPropertyName = "FILE_PATH";
            this.FILE_PATH.HeaderText = "FILE_PATH";
            this.FILE_PATH.Name = "FILE_PATH";
            this.FILE_PATH.ReadOnly = true;
            // 
            // FILE_NAME
            // 
            this.FILE_NAME.DataPropertyName = "FILE_NAME";
            this.FILE_NAME.HeaderText = "FILE_NAME";
            this.FILE_NAME.Name = "FILE_NAME";
            this.FILE_NAME.ReadOnly = true;
            this.FILE_NAME.Visible = false;
            // 
            // FILE_SIZE
            // 
            this.FILE_SIZE.DataPropertyName = "FILE_SIZE";
            this.FILE_SIZE.HeaderText = "FILE_SIZE";
            this.FILE_SIZE.Name = "FILE_SIZE";
            this.FILE_SIZE.ReadOnly = true;
            // 
            // FILE_CREATE_DATE
            // 
            this.FILE_CREATE_DATE.DataPropertyName = "FILE_CREATE_DATE";
            this.FILE_CREATE_DATE.HeaderText = "FILE_CREATE_DATE";
            this.FILE_CREATE_DATE.Name = "FILE_CREATE_DATE";
            this.FILE_CREATE_DATE.ReadOnly = true;
            this.FILE_CREATE_DATE.Visible = false;
            // 
            // FILE_MODIFY_DATE
            // 
            this.FILE_MODIFY_DATE.DataPropertyName = "FILE_MODIFY_DATE";
            this.FILE_MODIFY_DATE.HeaderText = "FILE_MODIFY_DATE";
            this.FILE_MODIFY_DATE.Name = "FILE_MODIFY_DATE";
            this.FILE_MODIFY_DATE.ReadOnly = true;
            this.FILE_MODIFY_DATE.Visible = false;
            // 
            // REG_DATE
            // 
            this.REG_DATE.DataPropertyName = "REG_DATE";
            this.REG_DATE.HeaderText = "REG_DATE";
            this.REG_DATE.Name = "REG_DATE";
            this.REG_DATE.ReadOnly = true;
            this.REG_DATE.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(733, 481);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.comboBoxOrderBy);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.lblTotalCount);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbPageSize);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 512);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(733, 150);
            this.panel2.TabIndex = 1;
            // 
            // comboBoxOrderBy
            // 
            this.comboBoxOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrderBy.FormattingEnabled = true;
            this.comboBoxOrderBy.Items.AddRange(new object[] {
            "정렬",
            "파일명asc",
            "파일명desc",
            "파일경로asc",
            "파일경로desc",
            "파일크기asc",
            "파일크기desc"});
            this.comboBoxOrderBy.Location = new System.Drawing.Point(110, 6);
            this.comboBoxOrderBy.Name = "comboBoxOrderBy";
            this.comboBoxOrderBy.Size = new System.Drawing.Size(97, 20);
            this.comboBoxOrderBy.TabIndex = 11;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnMainNextPage);
            this.panel8.Controls.Add(this.btnMainPrevPage);
            this.panel8.Controls.Add(this.tbCurrPage);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.lblTotalPage);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(518, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(215, 33);
            this.panel8.TabIndex = 10;
            // 
            // btnMainNextPage
            // 
            this.btnMainNextPage.Location = new System.Drawing.Point(140, 5);
            this.btnMainNextPage.Name = "btnMainNextPage";
            this.btnMainNextPage.Size = new System.Drawing.Size(55, 23);
            this.btnMainNextPage.TabIndex = 6;
            this.btnMainNextPage.Text = "다음 ▶";
            this.btnMainNextPage.UseVisualStyleBackColor = true;
            this.btnMainNextPage.Click += new System.EventHandler(this.btnMainNextPage_Click);
            // 
            // btnMainPrevPage
            // 
            this.btnMainPrevPage.Location = new System.Drawing.Point(4, 5);
            this.btnMainPrevPage.Name = "btnMainPrevPage";
            this.btnMainPrevPage.Size = new System.Drawing.Size(55, 23);
            this.btnMainPrevPage.TabIndex = 5;
            this.btnMainPrevPage.Text = "◀ 이전";
            this.btnMainPrevPage.UseVisualStyleBackColor = true;
            this.btnMainPrevPage.Click += new System.EventHandler(this.btnMainPrevPage_Click);
            // 
            // tbCurrPage
            // 
            this.tbCurrPage.Location = new System.Drawing.Point(67, 6);
            this.tbCurrPage.Name = "tbCurrPage";
            this.tbCurrPage.Size = new System.Drawing.Size(24, 21);
            this.tbCurrPage.TabIndex = 7;
            this.tbCurrPage.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "/";
            // 
            // lblTotalPage
            // 
            this.lblTotalPage.AutoSize = true;
            this.lblTotalPage.Location = new System.Drawing.Point(109, 11);
            this.lblTotalPage.Name = "lblTotalPage";
            this.lblTotalPage.Size = new System.Drawing.Size(11, 12);
            this.lblTotalPage.TabIndex = 9;
            this.lblTotalPage.Text = "1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tbDetailFilePath, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(733, 117);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tbDetailFilePath
            // 
            this.tbDetailFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDetailFilePath.Location = new System.Drawing.Point(123, 3);
            this.tbDetailFilePath.Name = "tbDetailFilePath";
            this.tbDetailFilePath.Size = new System.Drawing.Size(607, 21);
            this.tbDetailFilePath.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(114, 24);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "파일경로 :";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 33);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(114, 24);
            this.panel4.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "일자(등록/수정) :";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBox4);
            this.panel5.Controls.Add(this.textBox3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(123, 33);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(607, 24);
            this.panel5.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(149, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(133, 21);
            this.textBox4.TabIndex = 1;
            this.textBox4.Text = "2014-03-03 12:34:56";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(0, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(133, 21);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "2014-03-03 12:34:56";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button3);
            this.panel6.Controls.Add(this.button2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(123, 63);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(607, 51);
            this.panel6.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(98, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "파일삭제";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "탐색기";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Location = new System.Drawing.Point(316, 11);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(17, 12);
            this.lblTotalCount.TabIndex = 3;
            this.lblTotalCount.Text = "-1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "TotalCount :";
            // 
            // tbPageSize
            // 
            this.tbPageSize.Location = new System.Drawing.Point(73, 6);
            this.tbPageSize.Name = "tbPageSize";
            this.tbPageSize.Size = new System.Drawing.Size(31, 21);
            this.tbPageSize.TabIndex = 1;
            this.tbPageSize.Text = "50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "PageSize :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.comboBoxFileUnit);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbSearchFileSizeE);
            this.panel1.Controls.Add(this.tbSearchFileSizeS);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.tbMainSearchWord);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 31);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxFileUnit
            // 
            this.comboBoxFileUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFileUnit.FormattingEnabled = true;
            this.comboBoxFileUnit.Items.AddRange(new object[] {
            "B",
            "KB",
            "MB",
            "GB"});
            this.comboBoxFileUnit.Location = new System.Drawing.Point(448, 4);
            this.comboBoxFileUnit.Name = "comboBoxFileUnit";
            this.comboBoxFileUnit.Size = new System.Drawing.Size(55, 20);
            this.comboBoxFileUnit.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(364, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "~";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "파일크기 :";
            // 
            // tbSearchFileSizeE
            // 
            this.tbSearchFileSizeE.Location = new System.Drawing.Point(380, 4);
            this.tbSearchFileSizeE.Name = "tbSearchFileSizeE";
            this.tbSearchFileSizeE.Size = new System.Drawing.Size(61, 21);
            this.tbSearchFileSizeE.TabIndex = 6;
            // 
            // tbSearchFileSizeS
            // 
            this.tbSearchFileSizeS.Location = new System.Drawing.Point(300, 4);
            this.tbSearchFileSizeS.Name = "tbSearchFileSizeS";
            this.tbSearchFileSizeS.Size = new System.Drawing.Size(61, 21);
            this.tbSearchFileSizeS.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "파일정보 :";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnReIndex);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(658, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(75, 31);
            this.panel9.TabIndex = 3;
            // 
            // btnReIndex
            // 
            this.btnReIndex.Location = new System.Drawing.Point(3, 3);
            this.btnReIndex.Name = "btnReIndex";
            this.btnReIndex.Size = new System.Drawing.Size(55, 23);
            this.btnReIndex.TabIndex = 2;
            this.btnReIndex.Text = "재색인";
            this.btnReIndex.UseVisualStyleBackColor = true;
            this.btnReIndex.Click += new System.EventHandler(this.btnReIndex_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(517, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(68, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbMainSearchWord
            // 
            this.tbMainSearchWord.Location = new System.Drawing.Point(74, 3);
            this.tbMainSearchWord.Name = "tbMainSearchWord";
            this.tbMainSearchWord.Size = new System.Drawing.Size(144, 21);
            this.tbMainSearchWord.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDBFileCreate);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(985, 668);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDBFileCreate
            // 
            this.btnDBFileCreate.Location = new System.Drawing.Point(21, 77);
            this.btnDBFileCreate.Name = "btnDBFileCreate";
            this.btnDBFileCreate.Size = new System.Drawing.Size(161, 23);
            this.btnDBFileCreate.TabIndex = 1;
            this.btnDBFileCreate.Text = "SQLITE DB 파일만들기";
            this.btnDBFileCreate.UseVisualStyleBackColor = true;
            this.btnDBFileCreate.Click += new System.EventHandler(this.btnDBFileCreate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "테이블생성";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 694);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbMainSearchWord;
        private System.Windows.Forms.Button btnReIndex;
        private System.Windows.Forms.TextBox tbPageSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn FILE_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FILE_PATH;
        private System.Windows.Forms.DataGridViewTextBoxColumn FILE_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn FILE_SIZE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FILE_CREATE_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FILE_MODIFY_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn REG_DATE;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbDetailFilePath;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnMainPrevPage;
        private System.Windows.Forms.Button btnMainNextPage;
        private System.Windows.Forms.TextBox tbCurrPage;
        private System.Windows.Forms.Label lblTotalPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDBFileCreate;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox comboBoxOrderBy;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSearchFileSizeE;
        private System.Windows.Forms.TextBox tbSearchFileSizeS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxFileUnit;
    }
}


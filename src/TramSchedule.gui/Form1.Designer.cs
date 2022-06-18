namespace TramSchedule
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControlTrams = new System.Windows.Forms.TabControl();
            this.tabPageRoutes = new System.Windows.Forms.TabPage();
            this.dataGridViewTrams = new System.Windows.Forms.DataGridView();
            this.tramIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tramBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageTramLines = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBoxAllLines = new System.Windows.Forms.ListBox();
            this.tramBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxLinesStops = new System.Windows.Forms.ListBox();
            this.tramStopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageTramStops = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listBoxTramStops = new System.Windows.Forms.ListBox();
            this.listBoxTramStopComments = new System.Windows.Forms.ListBox();
            this.tramStopCommentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.listBoxStops = new System.Windows.Forms.ListBox();
            this.listBoxDepartureTimes = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxTrams = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddNewTram = new System.Windows.Forms.Button();
            this.groupBoxStops = new System.Windows.Forms.GroupBox();
            this.labelStops = new System.Windows.Forms.Label();
            this.buttonAddComment = new System.Windows.Forms.Button();
            this.groupBoxLines = new System.Windows.Forms.GroupBox();
            this.buttonEditLine = new System.Windows.Forms.Button();
            this.buttonDeleteStopFromLine = new System.Windows.Forms.Button();
            this.buttonDeleteLine = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddNewLine = new System.Windows.Forms.Button();
            this.buttonAddStopToLine = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControlTrams.SuspendLayout();
            this.tabPageRoutes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tramBindingSource)).BeginInit();
            this.tabPageTramLines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tramBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tramStopBindingSource)).BeginInit();
            this.tabPageTramStops.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tramStopCommentBindingSource)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxTrams.SuspendLayout();
            this.groupBoxStops.SuspendLayout();
            this.groupBoxLines.SuspendLayout();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(667, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "d";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(761, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tram schedule";
            // 
            // tabControlTrams
            // 
            this.tabControlTrams.Controls.Add(this.tabPageRoutes);
            this.tabControlTrams.Controls.Add(this.tabPageTramLines);
            this.tabControlTrams.Controls.Add(this.tabPageTramStops);
            this.tabControlTrams.Controls.Add(this.tabPage1);
            this.tabControlTrams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTrams.Location = new System.Drawing.Point(0, 0);
            this.tabControlTrams.Multiline = true;
            this.tabControlTrams.Name = "tabControlTrams";
            this.tabControlTrams.SelectedIndex = 0;
            this.tabControlTrams.Size = new System.Drawing.Size(1482, 864);
            this.tabControlTrams.TabIndex = 5;
            this.tabControlTrams.SelectedIndexChanged += new System.EventHandler(this.tabControlTrams_SelectedIndexChanged);
            // 
            // tabPageRoutes
            // 
            this.tabPageRoutes.Controls.Add(this.dataGridViewTrams);
            this.tabPageRoutes.Location = new System.Drawing.Point(4, 24);
            this.tabPageRoutes.Name = "tabPageRoutes";
            this.tabPageRoutes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRoutes.Size = new System.Drawing.Size(1474, 836);
            this.tabPageRoutes.TabIndex = 0;
            this.tabPageRoutes.Text = "Trams";
            this.tabPageRoutes.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTrams
            // 
            this.dataGridViewTrams.AccessibleName = "";
            this.dataGridViewTrams.AllowDrop = true;
            this.dataGridViewTrams.AllowUserToAddRows = false;
            this.dataGridViewTrams.AllowUserToDeleteRows = false;
            this.dataGridViewTrams.AllowUserToOrderColumns = true;
            this.dataGridViewTrams.AutoGenerateColumns = false;
            this.dataGridViewTrams.BackgroundColor = System.Drawing.Color.Ivory;
            this.dataGridViewTrams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tramIdDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridViewTrams.DataSource = this.tramBindingSource;
            this.dataGridViewTrams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTrams.GridColor = System.Drawing.Color.Bisque;
            this.dataGridViewTrams.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewTrams.Name = "dataGridViewTrams";
            this.dataGridViewTrams.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewTrams.RowTemplate.Height = 25;
            this.dataGridViewTrams.Size = new System.Drawing.Size(1468, 830);
            this.dataGridViewTrams.TabIndex = 2;
            this.dataGridViewTrams.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewTrams.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTrams_CellEnter);
            this.dataGridViewTrams.Click += new System.EventHandler(this.dataGridViewTrams_Click);
            // 
            // tramIdDataGridViewTextBoxColumn
            // 
            this.tramIdDataGridViewTextBoxColumn.DataPropertyName = "TramId";
            this.tramIdDataGridViewTextBoxColumn.HeaderText = "TramId";
            this.tramIdDataGridViewTextBoxColumn.Name = "tramIdDataGridViewTextBoxColumn";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // tramBindingSource
            // 
            this.tramBindingSource.DataSource = typeof(TramSchedule.Data.Entities.Tram);
            // 
            // tabPageTramLines
            // 
            this.tabPageTramLines.Controls.Add(this.splitContainer1);
            this.tabPageTramLines.Location = new System.Drawing.Point(4, 24);
            this.tabPageTramLines.Name = "tabPageTramLines";
            this.tabPageTramLines.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTramLines.Size = new System.Drawing.Size(1474, 836);
            this.tabPageTramLines.TabIndex = 1;
            this.tabPageTramLines.Text = "Tram lines";
            this.tabPageTramLines.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBoxAllLines);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listBoxLinesStops);
            this.splitContainer1.Size = new System.Drawing.Size(1468, 830);
            this.splitContainer1.SplitterDistance = 489;
            this.splitContainer1.TabIndex = 0;
            // 
            // listBoxAllLines
            // 
            this.listBoxAllLines.BackColor = System.Drawing.Color.Ivory;
            this.listBoxAllLines.DataSource = this.tramBindingSource1;
            this.listBoxAllLines.DisplayMember = "Name";
            this.listBoxAllLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxAllLines.FormattingEnabled = true;
            this.listBoxAllLines.ItemHeight = 15;
            this.listBoxAllLines.Location = new System.Drawing.Point(0, 0);
            this.listBoxAllLines.Name = "listBoxAllLines";
            this.listBoxAllLines.Size = new System.Drawing.Size(489, 830);
            this.listBoxAllLines.TabIndex = 0;
            this.listBoxAllLines.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            this.listBoxAllLines.Enter += new System.EventHandler(this.listBoxAllLines_Enter);
            this.listBoxAllLines.Leave += new System.EventHandler(this.listBoxAllLines_Leave);
            // 
            // tramBindingSource1
            // 
            this.tramBindingSource1.DataSource = typeof(TramSchedule.Data.Entities.TramLine);
            // 
            // listBoxLinesStops
            // 
            this.listBoxLinesStops.BackColor = System.Drawing.Color.Ivory;
            this.listBoxLinesStops.DataSource = this.tramStopBindingSource;
            this.listBoxLinesStops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxLinesStops.FormattingEnabled = true;
            this.listBoxLinesStops.ItemHeight = 15;
            this.listBoxLinesStops.Location = new System.Drawing.Point(0, 0);
            this.listBoxLinesStops.Name = "listBoxLinesStops";
            this.listBoxLinesStops.Size = new System.Drawing.Size(975, 830);
            this.listBoxLinesStops.TabIndex = 0;
            this.listBoxLinesStops.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // tramStopBindingSource
            // 
            this.tramStopBindingSource.DataSource = typeof(TramSchedule.Data.Entities.TramStopComment);
            // 
            // tabPageTramStops
            // 
            this.tabPageTramStops.Controls.Add(this.splitContainer2);
            this.tabPageTramStops.Location = new System.Drawing.Point(4, 24);
            this.tabPageTramStops.Name = "tabPageTramStops";
            this.tabPageTramStops.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTramStops.Size = new System.Drawing.Size(1474, 836);
            this.tabPageTramStops.TabIndex = 2;
            this.tabPageTramStops.Text = "Tram stops";
            this.tabPageTramStops.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listBoxTramStops);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listBoxTramStopComments);
            this.splitContainer2.Size = new System.Drawing.Size(1468, 830);
            this.splitContainer2.SplitterDistance = 580;
            this.splitContainer2.TabIndex = 0;
            // 
            // listBoxTramStops
            // 
            this.listBoxTramStops.BackColor = System.Drawing.Color.Ivory;
            this.listBoxTramStops.DataSource = this.tramStopBindingSource;
            this.listBoxTramStops.DisplayMember = "Description";
            this.listBoxTramStops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTramStops.FormattingEnabled = true;
            this.listBoxTramStops.ItemHeight = 15;
            this.listBoxTramStops.Location = new System.Drawing.Point(0, 0);
            this.listBoxTramStops.Name = "listBoxTramStops";
            this.listBoxTramStops.Size = new System.Drawing.Size(580, 830);
            this.listBoxTramStops.TabIndex = 0;
            this.listBoxTramStops.SelectedIndexChanged += new System.EventHandler(this.listBoxTramStops_SelectedIndexChanged);
            this.listBoxTramStops.Enter += new System.EventHandler(this.listBoxTramStops_Enter);
            // 
            // listBoxTramStopComments
            // 
            this.listBoxTramStopComments.BackColor = System.Drawing.Color.Ivory;
            this.listBoxTramStopComments.DataSource = this.tramStopCommentBindingSource;
            this.listBoxTramStopComments.DisplayMember = "Description";
            this.listBoxTramStopComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTramStopComments.FormattingEnabled = true;
            this.listBoxTramStopComments.ItemHeight = 15;
            this.listBoxTramStopComments.Location = new System.Drawing.Point(0, 0);
            this.listBoxTramStopComments.Name = "listBoxTramStopComments";
            this.listBoxTramStopComments.Size = new System.Drawing.Size(884, 830);
            this.listBoxTramStopComments.TabIndex = 0;
            // 
            // tramStopCommentBindingSource
            // 
            this.tramStopCommentBindingSource.DataSource = typeof(TramSchedule.Data.Entities.TramStopComment);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer3);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1474, 836);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Departures";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.listBoxStops);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.listBoxDepartureTimes);
            this.splitContainer3.Size = new System.Drawing.Size(1468, 830);
            this.splitContainer3.SplitterDistance = 489;
            this.splitContainer3.TabIndex = 1;
            // 
            // listBoxStops
            // 
            this.listBoxStops.DataSource = this.tramStopBindingSource;
            this.listBoxStops.DisplayMember = "Description";
            this.listBoxStops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxStops.FormattingEnabled = true;
            this.listBoxStops.ItemHeight = 15;
            this.listBoxStops.Location = new System.Drawing.Point(0, 0);
            this.listBoxStops.Name = "listBoxStops";
            this.listBoxStops.Size = new System.Drawing.Size(489, 830);
            this.listBoxStops.TabIndex = 0;
            this.listBoxStops.SelectedIndexChanged += new System.EventHandler(this.listBoxStops_SelectedIndexChanged);
            // 
            // listBoxDepartureTimes
            // 
            this.listBoxDepartureTimes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxDepartureTimes.FormattingEnabled = true;
            this.listBoxDepartureTimes.ItemHeight = 15;
            this.listBoxDepartureTimes.Location = new System.Drawing.Point(0, 0);
            this.listBoxDepartureTimes.Name = "listBoxDepartureTimes";
            this.listBoxDepartureTimes.Size = new System.Drawing.Size(975, 830);
            this.listBoxDepartureTimes.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(60, 176);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(121, 109);
            this.listBox1.TabIndex = 0;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.Connection = null;
            this.sqlCommand1.Notification = null;
            this.sqlCommand1.Transaction = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControlTrams);
            this.panel1.Location = new System.Drawing.Point(159, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1482, 864);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(this.groupBoxTrams);
            this.panel2.Controls.Add(this.groupBoxStops);
            this.panel2.Controls.Add(this.groupBoxLines);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 941);
            this.panel2.TabIndex = 7;
            // 
            // groupBoxTrams
            // 
            this.groupBoxTrams.Controls.Add(this.label4);
            this.groupBoxTrams.Controls.Add(this.buttonAddNewTram);
            this.groupBoxTrams.Location = new System.Drawing.Point(24, 661);
            this.groupBoxTrams.Name = "groupBoxTrams";
            this.groupBoxTrams.Size = new System.Drawing.Size(104, 101);
            this.groupBoxTrams.TabIndex = 5;
            this.groupBoxTrams.TabStop = false;
            this.groupBoxTrams.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(22, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Trams";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonAddNewTram
            // 
            this.buttonAddNewTram.BackColor = System.Drawing.Color.Ivory;
            this.buttonAddNewTram.Location = new System.Drawing.Point(6, 50);
            this.buttonAddNewTram.Name = "buttonAddNewTram";
            this.buttonAddNewTram.Size = new System.Drawing.Size(104, 36);
            this.buttonAddNewTram.TabIndex = 5;
            this.buttonAddNewTram.Text = "Add new Tram";
            this.buttonAddNewTram.UseVisualStyleBackColor = false;
            this.buttonAddNewTram.Click += new System.EventHandler(this.buttonAddNewTram_Click);
            // 
            // groupBoxStops
            // 
            this.groupBoxStops.Controls.Add(this.labelStops);
            this.groupBoxStops.Controls.Add(this.buttonAddComment);
            this.groupBoxStops.Location = new System.Drawing.Point(24, 432);
            this.groupBoxStops.Name = "groupBoxStops";
            this.groupBoxStops.Size = new System.Drawing.Size(104, 101);
            this.groupBoxStops.TabIndex = 4;
            this.groupBoxStops.TabStop = false;
            this.groupBoxStops.Visible = false;
            // 
            // labelStops
            // 
            this.labelStops.AutoSize = true;
            this.labelStops.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStops.Location = new System.Drawing.Point(25, 18);
            this.labelStops.Name = "labelStops";
            this.labelStops.Size = new System.Drawing.Size(54, 19);
            this.labelStops.TabIndex = 3;
            this.labelStops.Text = "Stops";
            this.labelStops.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonAddComment
            // 
            this.buttonAddComment.BackColor = System.Drawing.Color.Ivory;
            this.buttonAddComment.Location = new System.Drawing.Point(0, 50);
            this.buttonAddComment.Name = "buttonAddComment";
            this.buttonAddComment.Size = new System.Drawing.Size(104, 36);
            this.buttonAddComment.TabIndex = 3;
            this.buttonAddComment.Text = "Add comment";
            this.buttonAddComment.UseVisualStyleBackColor = false;
            this.buttonAddComment.Click += new System.EventHandler(this.buttonAddComment_Click);
            // 
            // groupBoxLines
            // 
            this.groupBoxLines.Controls.Add(this.buttonEditLine);
            this.groupBoxLines.Controls.Add(this.buttonDeleteStopFromLine);
            this.groupBoxLines.Controls.Add(this.buttonDeleteLine);
            this.groupBoxLines.Controls.Add(this.label3);
            this.groupBoxLines.Controls.Add(this.buttonAddNewLine);
            this.groupBoxLines.Controls.Add(this.buttonAddStopToLine);
            this.groupBoxLines.Location = new System.Drawing.Point(24, 104);
            this.groupBoxLines.Name = "groupBoxLines";
            this.groupBoxLines.Size = new System.Drawing.Size(104, 282);
            this.groupBoxLines.TabIndex = 3;
            this.groupBoxLines.TabStop = false;
            this.groupBoxLines.Visible = false;
            // 
            // buttonEditLine
            // 
            this.buttonEditLine.BackColor = System.Drawing.Color.Ivory;
            this.buttonEditLine.Location = new System.Drawing.Point(0, 187);
            this.buttonEditLine.Name = "buttonEditLine";
            this.buttonEditLine.Size = new System.Drawing.Size(104, 38);
            this.buttonEditLine.TabIndex = 4;
            this.buttonEditLine.Text = "Edit line";
            this.buttonEditLine.UseVisualStyleBackColor = false;
            this.buttonEditLine.Click += new System.EventHandler(this.buttonEditLine_Click);
            // 
            // buttonDeleteStopFromLine
            // 
            this.buttonDeleteStopFromLine.BackColor = System.Drawing.Color.Ivory;
            this.buttonDeleteStopFromLine.Location = new System.Drawing.Point(0, 92);
            this.buttonDeleteStopFromLine.Name = "buttonDeleteStopFromLine";
            this.buttonDeleteStopFromLine.Size = new System.Drawing.Size(104, 45);
            this.buttonDeleteStopFromLine.TabIndex = 3;
            this.buttonDeleteStopFromLine.Text = "Delete stop from line";
            this.buttonDeleteStopFromLine.UseVisualStyleBackColor = false;
            this.buttonDeleteStopFromLine.Click += new System.EventHandler(this.buttonDeleteStopFromLine_Click);
            // 
            // buttonDeleteLine
            // 
            this.buttonDeleteLine.BackColor = System.Drawing.Color.Ivory;
            this.buttonDeleteLine.Location = new System.Drawing.Point(0, 231);
            this.buttonDeleteLine.Name = "buttonDeleteLine";
            this.buttonDeleteLine.Size = new System.Drawing.Size(104, 36);
            this.buttonDeleteLine.TabIndex = 2;
            this.buttonDeleteLine.Text = "Delete line";
            this.buttonDeleteLine.UseVisualStyleBackColor = false;
            this.buttonDeleteLine.Click += new System.EventHandler(this.buttonDeleteLine_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lines";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonAddNewLine
            // 
            this.buttonAddNewLine.BackColor = System.Drawing.Color.Ivory;
            this.buttonAddNewLine.Location = new System.Drawing.Point(0, 143);
            this.buttonAddNewLine.Name = "buttonAddNewLine";
            this.buttonAddNewLine.Size = new System.Drawing.Size(104, 38);
            this.buttonAddNewLine.TabIndex = 2;
            this.buttonAddNewLine.Text = "Add new Line";
            this.buttonAddNewLine.UseVisualStyleBackColor = false;
            this.buttonAddNewLine.Click += new System.EventHandler(this.buttonAddNewLine_Click);
            // 
            // buttonAddStopToLine
            // 
            this.buttonAddStopToLine.BackColor = System.Drawing.Color.Ivory;
            this.buttonAddStopToLine.Location = new System.Drawing.Point(0, 50);
            this.buttonAddStopToLine.Name = "buttonAddStopToLine";
            this.buttonAddStopToLine.Size = new System.Drawing.Size(104, 36);
            this.buttonAddStopToLine.TabIndex = 1;
            this.buttonAddStopToLine.Text = "Add stop to line";
            this.buttonAddStopToLine.UseVisualStyleBackColor = false;
            this.buttonAddStopToLine.Click += new System.EventHandler(this.buttonAddStopToLine_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1642, 941);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlTrams.ResumeLayout(false);
            this.tabPageRoutes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tramBindingSource)).EndInit();
            this.tabPageTramLines.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tramBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tramStopBindingSource)).EndInit();
            this.tabPageTramStops.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tramStopCommentBindingSource)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBoxTrams.ResumeLayout(false);
            this.groupBoxTrams.PerformLayout();
            this.groupBoxStops.ResumeLayout(false);
            this.groupBoxStops.PerformLayout();
            this.groupBoxLines.ResumeLayout(false);
            this.groupBoxLines.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PrintPreviewDialog printPreviewDialog1;
        private Label label1;
        private Label label2;
        private TabControl tabControlTrams;
        private TabPage tabPageRoutes;
        private TabPage tabPageTramLines;
        private TabPage tabPageTramStops;
        private BindingSource tramBindingSource;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridView dataGridViewTrams;
        private Panel panel1;
        private Panel panel2;
        private SplitContainer splitContainer1;
        private ContextMenuStrip contextMenuStrip1;
        private ListBox listBoxLinesStops;
        private ListBox listBoxAllLines;
        private BindingSource tramBindingSource1;
        private BindingSource tramStopBindingSource;
        private Button buttonAddStopToLine;
        private SplitContainer splitContainer2;
        private ListBox listBoxTramStops;
        private ListBox listBoxTramStopComments;
        private Button buttonAddNewLine;
        private Button buttonAddComment;
        private GroupBox groupBoxLines;
        private Button buttonDeleteLine;
        private Label label3;
        private GroupBox groupBoxStops;
        private Label labelStops;
        private Button buttonDeleteStopFromLine;
        private BindingSource tramStopCommentBindingSource;
        private Button buttonEditLine;
        private GroupBox groupBoxTrams;
        private Label label4;
        private Button buttonAddNewTram;
        private TabPage tabPage1;
        private SplitContainer splitContainer3;
        private ListBox listBox1;
        private DataGridViewTextBoxColumn tramIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private ListBox listBoxStops;
        private ListBox listBoxDepartureTimes;
    }
}
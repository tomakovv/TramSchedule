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
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tramStopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageTramStops = new System.Windows.Forms.TabPage();
            this.tramBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.tramStopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tramBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.tabControlTrams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTrams.Location = new System.Drawing.Point(0, 0);
            this.tabControlTrams.Multiline = true;
            this.tabControlTrams.Name = "tabControlTrams";
            this.tabControlTrams.SelectedIndex = 0;
            this.tabControlTrams.Size = new System.Drawing.Size(1482, 864);
            this.tabControlTrams.TabIndex = 5;
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
            this.splitContainer1.Panel1.Controls.Add(this.listBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1468, 830);
            this.splitContainer1.SplitterDistance = 489;
            this.splitContainer1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.DataSource = this.tramBindingSource;
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(0, 0);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(489, 830);
            this.listBox2.TabIndex = 0;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.tramStopBindingSource;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(975, 830);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // tramStopBindingSource
            // 
            this.tramStopBindingSource.DataSource = typeof(TramSchedule.Data.Entities.TramStop);
            // 
            // tabPageTramStops
            // 
            this.tabPageTramStops.Location = new System.Drawing.Point(4, 24);
            this.tabPageTramStops.Name = "tabPageTramStops";
            this.tabPageTramStops.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTramStops.Size = new System.Drawing.Size(1474, 836);
            this.tabPageTramStops.TabIndex = 2;
            this.tabPageTramStops.Text = "Tram stops";
            this.tabPageTramStops.UseVisualStyleBackColor = true;
            // 
            // tramBindingSource1
            // 
            this.tramBindingSource1.DataSource = typeof(TramSchedule.Data.Entities.Tram);
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
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 941);
            this.panel2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Ivory;
            this.button1.Location = new System.Drawing.Point(23, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add new tram";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            ((System.ComponentModel.ISupportInitialize)(this.tramStopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tramBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private DataGridViewTextBoxColumn tramIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private Panel panel1;
        private Panel panel2;
        private SplitContainer splitContainer1;
        private ContextMenuStrip contextMenuStrip1;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button button1;
        private BindingSource tramBindingSource1;
        private BindingSource tramStopBindingSource;
    }
}
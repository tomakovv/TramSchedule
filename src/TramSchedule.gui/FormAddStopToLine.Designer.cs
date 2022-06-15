namespace TramSchedule
{
    partial class FormAddStopToLine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAddStopToLineSave = new System.Windows.Forms.Button();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxnewStopName = new System.Windows.Forms.TextBox();
            this.textBoxNewStopNumber = new System.Windows.Forms.TextBox();
            this.labelAddStopToLine = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Ivory;
            this.groupBox1.Controls.Add(this.buttonAddStopToLineSave);
            this.groupBox1.Controls.Add(this.labelDescription);
            this.groupBox1.Controls.Add(this.textBoxnewStopName);
            this.groupBox1.Controls.Add(this.textBoxNewStopNumber);
            this.groupBox1.Controls.Add(this.labelAddStopToLine);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add stop to line";
            // 
            // buttonAddStopToLineSave
            // 
            this.buttonAddStopToLineSave.Location = new System.Drawing.Point(92, 111);
            this.buttonAddStopToLineSave.Name = "buttonAddStopToLineSave";
            this.buttonAddStopToLineSave.Size = new System.Drawing.Size(75, 23);
            this.buttonAddStopToLineSave.TabIndex = 5;
            this.buttonAddStopToLineSave.Text = "Save";
            this.buttonAddStopToLineSave.UseVisualStyleBackColor = true;
            this.buttonAddStopToLineSave.Click += new System.EventHandler(this.buttonAddStopToLineSave_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.Location = new System.Drawing.Point(12, 71);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(97, 18);
            this.labelDescription.TabIndex = 4;
            this.labelDescription.Text = "Stop name:";
            // 
            // textBoxnewStopName
            // 
            this.textBoxnewStopName.Location = new System.Drawing.Point(111, 71);
            this.textBoxnewStopName.Name = "textBoxnewStopName";
            this.textBoxnewStopName.Size = new System.Drawing.Size(135, 23);
            this.textBoxnewStopName.TabIndex = 2;
            // 
            // textBoxNewStopNumber
            // 
            this.textBoxNewStopNumber.Location = new System.Drawing.Point(124, 37);
            this.textBoxNewStopNumber.Name = "textBoxNewStopNumber";
            this.textBoxNewStopNumber.Size = new System.Drawing.Size(122, 23);
            this.textBoxNewStopNumber.TabIndex = 1;
            // 
            // labelAddStopToLine
            // 
            this.labelAddStopToLine.AutoSize = true;
            this.labelAddStopToLine.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAddStopToLine.Location = new System.Drawing.Point(12, 37);
            this.labelAddStopToLine.Name = "labelAddStopToLine";
            this.labelAddStopToLine.Size = new System.Drawing.Size(112, 18);
            this.labelAddStopToLine.TabIndex = 0;
            this.labelAddStopToLine.Text = "Stop number:";
            // 
            // FormAddStopToLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 146);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAddStopToLine";
            this.Text = "FormAddStopToLine";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label labelDescription;
        private TextBox textBoxnewStopName;
        private TextBox textBoxNewStopNumber;
        private Label labelAddStopToLine;
        private Button buttonAddStopToLineSave;
    }
}
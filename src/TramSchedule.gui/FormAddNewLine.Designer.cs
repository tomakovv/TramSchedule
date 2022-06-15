namespace TramSchedule
{
    partial class FormAddNewLine
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
            this.groupBoxAddNewLine = new System.Windows.Forms.GroupBox();
            this.buttonSaveNewLine = new System.Windows.Forms.Button();
            this.textBoxNewLineNumber = new System.Windows.Forms.TextBox();
            this.labelNewLineNumber = new System.Windows.Forms.Label();
            this.textBoxNewLineName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxAddNewLine.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAddNewLine
            // 
            this.groupBoxAddNewLine.Controls.Add(this.buttonSaveNewLine);
            this.groupBoxAddNewLine.Controls.Add(this.textBoxNewLineNumber);
            this.groupBoxAddNewLine.Controls.Add(this.labelNewLineNumber);
            this.groupBoxAddNewLine.Controls.Add(this.textBoxNewLineName);
            this.groupBoxAddNewLine.Controls.Add(this.label1);
            this.groupBoxAddNewLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAddNewLine.Location = new System.Drawing.Point(0, 0);
            this.groupBoxAddNewLine.Name = "groupBoxAddNewLine";
            this.groupBoxAddNewLine.Size = new System.Drawing.Size(340, 142);
            this.groupBoxAddNewLine.TabIndex = 0;
            this.groupBoxAddNewLine.TabStop = false;
            this.groupBoxAddNewLine.Text = "Add new line";
            // 
            // buttonSaveNewLine
            // 
            this.buttonSaveNewLine.Location = new System.Drawing.Point(123, 103);
            this.buttonSaveNewLine.Name = "buttonSaveNewLine";
            this.buttonSaveNewLine.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveNewLine.TabIndex = 4;
            this.buttonSaveNewLine.Text = "Save";
            this.buttonSaveNewLine.UseVisualStyleBackColor = true;
            this.buttonSaveNewLine.Click += new System.EventHandler(this.buttonSaveNewLine_Click);
            // 
            // textBoxNewLineNumber
            // 
            this.textBoxNewLineNumber.Location = new System.Drawing.Point(157, 60);
            this.textBoxNewLineNumber.Name = "textBoxNewLineNumber";
            this.textBoxNewLineNumber.Size = new System.Drawing.Size(168, 23);
            this.textBoxNewLineNumber.TabIndex = 3;
            // 
            // labelNewLineNumber
            // 
            this.labelNewLineNumber.AutoSize = true;
            this.labelNewLineNumber.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNewLineNumber.Location = new System.Drawing.Point(12, 60);
            this.labelNewLineNumber.Name = "labelNewLineNumber";
            this.labelNewLineNumber.Size = new System.Drawing.Size(139, 18);
            this.labelNewLineNumber.TabIndex = 2;
            this.labelNewLineNumber.Text = "New line number:";
            // 
            // textBoxNewLineName
            // 
            this.textBoxNewLineName.Location = new System.Drawing.Point(141, 31);
            this.textBoxNewLineName.Name = "textBoxNewLineName";
            this.textBoxNewLineName.Size = new System.Drawing.Size(168, 23);
            this.textBoxNewLineName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "New line name:";
            // 
            // FormAddNewLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(340, 142);
            this.Controls.Add(this.groupBoxAddNewLine);
            this.Name = "FormAddNewLine";
            this.Text = "FormAddNewLine";
            this.groupBoxAddNewLine.ResumeLayout(false);
            this.groupBoxAddNewLine.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxAddNewLine;
        private TextBox textBoxNewLineName;
        private Label label1;
        private Button buttonSaveNewLine;
        private TextBox textBoxNewLineNumber;
        private Label labelNewLineNumber;
    }
}
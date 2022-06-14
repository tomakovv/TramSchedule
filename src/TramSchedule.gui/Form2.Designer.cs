namespace TramSchedule
{
    partial class Form2
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
            this.labelNewTramName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBoxNewTramDescription = new System.Windows.Forms.RichTextBox();
            this.textBoxNewTramNumber = new System.Windows.Forms.TextBox();
            this.textBoxNewTramName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSaveNewTram = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNewTramName
            // 
            this.labelNewTramName.AutoSize = true;
            this.labelNewTramName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNewTramName.Location = new System.Drawing.Point(21, 32);
            this.labelNewTramName.Name = "labelNewTramName";
            this.labelNewTramName.Size = new System.Drawing.Size(59, 18);
            this.labelNewTramName.TabIndex = 0;
            this.labelNewTramName.Text = "Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSaveNewTram);
            this.groupBox1.Controls.Add(this.richTextBoxNewTramDescription);
            this.groupBox1.Controls.Add(this.textBoxNewTramNumber);
            this.groupBox1.Controls.Add(this.textBoxNewTramName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelNewTramName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 275);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new tram";
            // 
            // richTextBoxNewTramDescription
            // 
            this.richTextBoxNewTramDescription.Location = new System.Drawing.Point(124, 106);
            this.richTextBoxNewTramDescription.Name = "richTextBoxNewTramDescription";
            this.richTextBoxNewTramDescription.Size = new System.Drawing.Size(291, 96);
            this.richTextBoxNewTramDescription.TabIndex = 6;
            this.richTextBoxNewTramDescription.Text = "";
            // 
            // textBoxNewTramNumber
            // 
            this.textBoxNewTramNumber.Location = new System.Drawing.Point(101, 70);
            this.textBoxNewTramNumber.Name = "textBoxNewTramNumber";
            this.textBoxNewTramNumber.Size = new System.Drawing.Size(215, 23);
            this.textBoxNewTramNumber.TabIndex = 4;
            // 
            // textBoxNewTramName
            // 
            this.textBoxNewTramName.Location = new System.Drawing.Point(86, 32);
            this.textBoxNewTramName.Name = "textBoxNewTramName";
            this.textBoxNewTramName.Size = new System.Drawing.Size(215, 23);
            this.textBoxNewTramName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number:";
            // 
            // buttonSaveNewTram
            // 
            this.buttonSaveNewTram.Location = new System.Drawing.Point(196, 224);
            this.buttonSaveNewTram.Name = "buttonSaveNewTram";
            this.buttonSaveNewTram.Size = new System.Drawing.Size(84, 30);
            this.buttonSaveNewTram.TabIndex = 7;
            this.buttonSaveNewTram.Text = "Save";
            this.buttonSaveNewTram.UseVisualStyleBackColor = true;
            this.buttonSaveNewTram.Click += new System.EventHandler(this.buttonSaveNewTram_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(483, 275);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label labelNewTramName;
        private GroupBox groupBox1;
        private RichTextBox richTextBoxNewTramDescription;
        private TextBox textBoxNewTramNumber;
        private TextBox textBoxNewTramName;
        private Label label2;
        private Label label1;
        private Button buttonSaveNewTram;
    }
}
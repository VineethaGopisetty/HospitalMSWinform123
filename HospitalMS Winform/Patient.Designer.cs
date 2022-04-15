
namespace HospitalMS_Winform
{
    partial class Patient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PatientGenCb = new System.Windows.Forms.ComboBox();
            this.PatientBGPCb = new System.Windows.Forms.ComboBox();
            this.PatientPhoneTb = new System.Windows.Forms.TextBox();
            this.PatientAgeTb = new System.Windows.Forms.TextBox();
            this.PatientAddTb = new System.Windows.Forms.TextBox();
            this.PatientNameTb = new System.Windows.Forms.TextBox();
            this.PatientIdTb = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PatientDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.WordCb = new System.Windows.Forms.ComboBox();
            this.PatientDisTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PatientDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // PatientGenCb
            // 
            this.PatientGenCb.FormattingEnabled = true;
            this.PatientGenCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.PatientGenCb.Location = new System.Drawing.Point(461, 59);
            this.PatientGenCb.Name = "PatientGenCb";
            this.PatientGenCb.Size = new System.Drawing.Size(141, 28);
            this.PatientGenCb.TabIndex = 32;
            // 
            // PatientBGPCb
            // 
            this.PatientBGPCb.FormattingEnabled = true;
            this.PatientBGPCb.Items.AddRange(new object[] {
            "A+",
            "B+",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.PatientBGPCb.Location = new System.Drawing.Point(42, 143);
            this.PatientBGPCb.Name = "PatientBGPCb";
            this.PatientBGPCb.Size = new System.Drawing.Size(177, 28);
            this.PatientBGPCb.TabIndex = 31;
            // 
            // PatientPhoneTb
            // 
            this.PatientPhoneTb.Location = new System.Drawing.Point(511, 159);
            this.PatientPhoneTb.Name = "PatientPhoneTb";
            this.PatientPhoneTb.Size = new System.Drawing.Size(205, 26);
            this.PatientPhoneTb.TabIndex = 30;
            // 
            // PatientAgeTb
            // 
            this.PatientAgeTb.Location = new System.Drawing.Point(282, 143);
            this.PatientAgeTb.Name = "PatientAgeTb";
            this.PatientAgeTb.Size = new System.Drawing.Size(170, 26);
            this.PatientAgeTb.TabIndex = 29;
            // 
            // PatientAddTb
            // 
            this.PatientAddTb.Location = new System.Drawing.Point(692, 52);
            this.PatientAddTb.Name = "PatientAddTb";
            this.PatientAddTb.Size = new System.Drawing.Size(152, 26);
            this.PatientAddTb.TabIndex = 28;
            // 
            // PatientNameTb
            // 
            this.PatientNameTb.Location = new System.Drawing.Point(253, 52);
            this.PatientNameTb.Name = "PatientNameTb";
            this.PatientNameTb.Size = new System.Drawing.Size(153, 26);
            this.PatientNameTb.TabIndex = 27;
            // 
            // PatientIdTb
            // 
            this.PatientIdTb.Location = new System.Drawing.Point(43, 48);
            this.PatientIdTb.Name = "PatientIdTb";
            this.PatientIdTb.Size = new System.Drawing.Size(140, 26);
            this.PatientIdTb.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(849, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 50);
            this.button2.TabIndex = 25;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(850, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 56);
            this.button1.TabIndex = 24;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(231, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 29);
            this.label7.TabIndex = 23;
            this.label7.Text = "PatientName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(461, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 29);
            this.label6.TabIndex = 22;
            this.label6.Text = "PatientGen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(692, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "PatientAdd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(37, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "PatientBGP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(519, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "PatientPhone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(298, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "PatientAge";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "PatientId";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PatientDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.PatientDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PatientDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PatientDGV.BackgroundColor = System.Drawing.Color.White;
            this.PatientDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PatientDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PatientDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PatientDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PatientDGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PatientDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.PatientDGV.EnableHeadersVisualStyles = false;
            this.PatientDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PatientDGV.Location = new System.Drawing.Point(24, 274);
            this.PatientDGV.Name = "PatientDGV";
            this.PatientDGV.RowHeadersVisible = false;
            this.PatientDGV.RowHeadersWidth = 62;
            this.PatientDGV.RowTemplate.Height = 28;
            this.PatientDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PatientDGV.Size = new System.Drawing.Size(1164, 315);
            this.PatientDGV.TabIndex = 33;
            this.PatientDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PatientDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PatientDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PatientDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PatientDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PatientDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.PatientDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PatientDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Blue;
            this.PatientDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PatientDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PatientDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PatientDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.PatientDGV.ThemeStyle.ReadOnly = false;
            this.PatientDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PatientDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PatientDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.PatientDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Blue;
            this.PatientDGV.ThemeStyle.RowsStyle.Height = 28;
            this.PatientDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Blue;
            this.PatientDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(37, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 29);
            this.label8.TabIndex = 34;
            this.label8.Text = "TypeOfWord";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(456, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 29);
            this.label9.TabIndex = 35;
            this.label9.Text = "PatientDisease";
            // 
            // WordCb
            // 
            this.WordCb.FormattingEnabled = true;
            this.WordCb.Items.AddRange(new object[] {
            "ICU",
            "DoubleBed",
            "General"});
            this.WordCb.Location = new System.Drawing.Point(217, 203);
            this.WordCb.Name = "WordCb";
            this.WordCb.Size = new System.Drawing.Size(177, 28);
            this.WordCb.TabIndex = 36;
            // 
            // PatientDisTb
            // 
            this.PatientDisTb.Location = new System.Drawing.Point(651, 207);
            this.PatientDisTb.Name = "PatientDisTb";
            this.PatientDisTb.Size = new System.Drawing.Size(170, 26);
            this.PatientDisTb.TabIndex = 37;
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1187, 601);
            this.Controls.Add(this.PatientDisTb);
            this.Controls.Add(this.WordCb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PatientDGV);
            this.Controls.Add(this.PatientGenCb);
            this.Controls.Add(this.PatientBGPCb);
            this.Controls.Add(this.PatientPhoneTb);
            this.Controls.Add(this.PatientAgeTb);
            this.Controls.Add(this.PatientAddTb);
            this.Controls.Add(this.PatientNameTb);
            this.Controls.Add(this.PatientIdTb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PatientDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PatientGenCb;
        private System.Windows.Forms.ComboBox PatientBGPCb;
        private System.Windows.Forms.TextBox PatientPhoneTb;
        private System.Windows.Forms.TextBox PatientAgeTb;
        private System.Windows.Forms.TextBox PatientAddTb;
        private System.Windows.Forms.TextBox PatientNameTb;
        private System.Windows.Forms.TextBox PatientIdTb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView PatientDGV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox WordCb;
        private System.Windows.Forms.TextBox PatientDisTb;
    }
}
namespace VScanApp
{
    partial class FormScanM
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInitPort = new System.Windows.Forms.TextBox();
            this.textBoxFinalPort = new System.Windows.Forms.TextBox();
            this.textBoxSetComm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxInitIP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFinalIP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableData = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxScanID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxDescript = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxIDdel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableData)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Scan Types:";
            // 
            // textBoxInitPort
            // 
            this.textBoxInitPort.Location = new System.Drawing.Point(68, 28);
            this.textBoxInitPort.Name = "textBoxInitPort";
            this.textBoxInitPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxInitPort.TabIndex = 2;
            // 
            // textBoxFinalPort
            // 
            this.textBoxFinalPort.Location = new System.Drawing.Point(68, 57);
            this.textBoxFinalPort.Name = "textBoxFinalPort";
            this.textBoxFinalPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxFinalPort.TabIndex = 5;
            // 
            // textBoxSetComm
            // 
            this.textBoxSetComm.Location = new System.Drawing.Point(130, 175);
            this.textBoxSetComm.Name = "textBoxSetComm";
            this.textBoxSetComm.Size = new System.Drawing.Size(459, 20);
            this.textBoxSetComm.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Set Command:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Init:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Final:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxInitPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxFinalPort);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(54, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ports Values";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxInitIP);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxFinalIP);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(312, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IPV4 Values";
            // 
            // textBoxInitIP
            // 
            this.textBoxInitIP.Location = new System.Drawing.Point(68, 28);
            this.textBoxInitIP.Name = "textBoxInitIP";
            this.textBoxInitIP.Size = new System.Drawing.Size(100, 20);
            this.textBoxInitIP.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Init:";
            // 
            // textBoxFinalIP
            // 
            this.textBoxFinalIP.Location = new System.Drawing.Point(68, 57);
            this.textBoxFinalIP.Name = "textBoxFinalIP";
            this.textBoxFinalIP.Size = new System.Drawing.Size(100, 20);
            this.textBoxFinalIP.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Final:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 504);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(234, 13);
            this.label8.TabIndex = 151;
            this.label8.Text = "Double click to select an item from the database";
            // 
            // tableData
            // 
            this.tableData.AllowUserToAddRows = false;
            this.tableData.AllowUserToDeleteRows = false;
            this.tableData.AllowUserToResizeColumns = false;
            this.tableData.AllowUserToResizeRows = false;
            this.tableData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tableData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableData.ColumnHeadersHeight = 42;
            this.tableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableData.DefaultCellStyle = dataGridViewCellStyle2;
            this.tableData.GridColor = System.Drawing.SystemColors.ControlLight;
            this.tableData.Location = new System.Drawing.Point(24, 245);
            this.tableData.MultiSelect = false;
            this.tableData.Name = "tableData";
            this.tableData.ReadOnly = true;
            this.tableData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.tableData.RowHeadersVisible = false;
            this.tableData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.tableData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableData.ShowCellErrors = false;
            this.tableData.ShowCellToolTips = false;
            this.tableData.ShowEditingIcon = false;
            this.tableData.ShowRowErrors = false;
            this.tableData.Size = new System.Drawing.Size(808, 256);
            this.tableData.TabIndex = 150;
            this.tableData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableData_CellDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 153;
            this.label7.Text = "Scan ID:";
            // 
            // textBoxScanID
            // 
            this.textBoxScanID.Location = new System.Drawing.Point(103, 19);
            this.textBoxScanID.Name = "textBoxScanID";
            this.textBoxScanID.Size = new System.Drawing.Size(119, 20);
            this.textBoxScanID.TabIndex = 152;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(240, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 155;
            this.label9.Text = "Description:";
            // 
            // textBoxDescript
            // 
            this.textBoxDescript.Location = new System.Drawing.Point(309, 19);
            this.textBoxDescript.Name = "textBoxDescript";
            this.textBoxDescript.Size = new System.Drawing.Size(280, 20);
            this.textBoxDescript.TabIndex = 154;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.textBoxDescript);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.textBoxScanID);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.textBoxSetComm);
            this.groupBox4.Location = new System.Drawing.Point(25, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(605, 216);
            this.groupBox4.TabIndex = 156;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Scan info";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxIDdel);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.buttonDelete);
            this.groupBox3.Controls.Add(this.buttonUpdate);
            this.groupBox3.Controls.Add(this.buttonInsert);
            this.groupBox3.Location = new System.Drawing.Point(655, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(177, 186);
            this.groupBox3.TabIndex = 156;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actions";
            // 
            // textBoxIDdel
            // 
            this.textBoxIDdel.Location = new System.Drawing.Point(119, 158);
            this.textBoxIDdel.Name = "textBoxIDdel";
            this.textBoxIDdel.Size = new System.Drawing.Size(39, 20);
            this.textBoxIDdel.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Scan ID to Delete:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(24, 121);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(134, 33);
            this.buttonDelete.TabIndex = 148;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(24, 68);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(134, 33);
            this.buttonUpdate.TabIndex = 147;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(24, 17);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(134, 33);
            this.buttonInsert.TabIndex = 146;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // FormScanM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 536);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tableData);
            this.Controls.Add(this.label1);
            this.Name = "FormScanM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maintenance : Scan Types";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormScanM_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableData)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInitPort;
        private System.Windows.Forms.TextBox textBoxFinalPort;
        private System.Windows.Forms.TextBox textBoxSetComm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxInitIP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFinalIP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView tableData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxScanID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxDescript;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxIDdel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
    }
}
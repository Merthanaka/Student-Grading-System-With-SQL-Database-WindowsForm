namespace Student_Grading_System
{
    partial class FrmTeacherDetails
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.msknum = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtex3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtex2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtex1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblfailed = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblclassavg = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sTDIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDEX1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDEX2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDEX3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tBLSTDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbGradeDataSet = new Student_Grading_System.DbGradeDataSet();
            this.tBLSTDTableAdapter = new Student_Grading_System.DbGradeDataSetTableAdapters.TBLSTDTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSTDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGradeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.msknum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtsname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Student";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // msknum
            // 
            this.msknum.Location = new System.Drawing.Point(116, 102);
            this.msknum.Mask = "0000";
            this.msknum.Name = "msknum";
            this.msknum.Size = new System.Drawing.Size(100, 30);
            this.msknum.TabIndex = 5;
            this.msknum.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number:";
            // 
            // txtsname
            // 
            this.txtsname.Location = new System.Drawing.Point(116, 63);
            this.txtsname.Name = "txtsname";
            this.txtsname.Size = new System.Drawing.Size(100, 30);
            this.txtsname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname :";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(116, 30);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 30);
            this.txtname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtex3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtex2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtex1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(392, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 235);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grading";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 39);
            this.button2.TabIndex = 7;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtex3
            // 
            this.txtex3.Location = new System.Drawing.Point(97, 104);
            this.txtex3.Name = "txtex3";
            this.txtex3.Size = new System.Drawing.Size(100, 30);
            this.txtex3.TabIndex = 5;
            this.txtex3.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Exam 3:";
            // 
            // txtex2
            // 
            this.txtex2.Location = new System.Drawing.Point(97, 68);
            this.txtex2.Name = "txtex2";
            this.txtex2.Size = new System.Drawing.Size(100, 30);
            this.txtex2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Exam 2:";
            // 
            // txtex1
            // 
            this.txtex1.Location = new System.Drawing.Point(97, 25);
            this.txtex1.Name = "txtex1";
            this.txtex1.Size = new System.Drawing.Size(100, 30);
            this.txtex1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Exam 1:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblfailed);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.lblpass);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lblclassavg);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(779, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 235);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Class Info";
            // 
            // lblfailed
            // 
            this.lblfailed.AutoSize = true;
            this.lblfailed.Location = new System.Drawing.Point(211, 142);
            this.lblfailed.Name = "lblfailed";
            this.lblfailed.Size = new System.Drawing.Size(34, 25);
            this.lblfailed.TabIndex = 5;
            this.lblfailed.Text = "00";
            this.lblfailed.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(110, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 25);
            this.label11.TabIndex = 4;
            this.label11.Text = "Failed:";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Location = new System.Drawing.Point(211, 101);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(34, 25);
            this.lblpass.TabIndex = 3;
            this.lblpass.Text = "00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(110, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Passed:";
            // 
            // lblclassavg
            // 
            this.lblclassavg.AutoSize = true;
            this.lblclassavg.Location = new System.Drawing.Point(211, 68);
            this.lblclassavg.Name = "lblclassavg";
            this.lblclassavg.Size = new System.Drawing.Size(34, 25);
            this.lblclassavg.TabIndex = 1;
            this.lblclassavg.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Average:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(13, 255);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1166, 436);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Exam Results";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTDIDDataGridViewTextBoxColumn,
            this.sTDNUMDataGridViewTextBoxColumn,
            this.sTDNDataGridViewTextBoxColumn,
            this.sTDSNDataGridViewTextBoxColumn,
            this.sTDEX1DataGridViewTextBoxColumn,
            this.sTDEX2DataGridViewTextBoxColumn,
            this.sTDEX3DataGridViewTextBoxColumn,
            this.aVGDataGridViewTextBoxColumn,
            this.sTATUSDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tBLSTDBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 407);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // sTDIDDataGridViewTextBoxColumn
            // 
            this.sTDIDDataGridViewTextBoxColumn.DataPropertyName = "STDID";
            this.sTDIDDataGridViewTextBoxColumn.HeaderText = "STDID";
            this.sTDIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTDIDDataGridViewTextBoxColumn.Name = "sTDIDDataGridViewTextBoxColumn";
            this.sTDIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTDNUMDataGridViewTextBoxColumn
            // 
            this.sTDNUMDataGridViewTextBoxColumn.DataPropertyName = "STDNUM";
            this.sTDNUMDataGridViewTextBoxColumn.HeaderText = "STDNUM";
            this.sTDNUMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTDNUMDataGridViewTextBoxColumn.Name = "sTDNUMDataGridViewTextBoxColumn";
            // 
            // sTDNDataGridViewTextBoxColumn
            // 
            this.sTDNDataGridViewTextBoxColumn.DataPropertyName = "STDN";
            this.sTDNDataGridViewTextBoxColumn.HeaderText = "STDN";
            this.sTDNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTDNDataGridViewTextBoxColumn.Name = "sTDNDataGridViewTextBoxColumn";
            // 
            // sTDSNDataGridViewTextBoxColumn
            // 
            this.sTDSNDataGridViewTextBoxColumn.DataPropertyName = "STDSN";
            this.sTDSNDataGridViewTextBoxColumn.HeaderText = "STDSN";
            this.sTDSNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTDSNDataGridViewTextBoxColumn.Name = "sTDSNDataGridViewTextBoxColumn";
            // 
            // sTDEX1DataGridViewTextBoxColumn
            // 
            this.sTDEX1DataGridViewTextBoxColumn.DataPropertyName = "STDEX1";
            this.sTDEX1DataGridViewTextBoxColumn.HeaderText = "STDEX1";
            this.sTDEX1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTDEX1DataGridViewTextBoxColumn.Name = "sTDEX1DataGridViewTextBoxColumn";
            // 
            // sTDEX2DataGridViewTextBoxColumn
            // 
            this.sTDEX2DataGridViewTextBoxColumn.DataPropertyName = "STDEX2";
            this.sTDEX2DataGridViewTextBoxColumn.HeaderText = "STDEX2";
            this.sTDEX2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTDEX2DataGridViewTextBoxColumn.Name = "sTDEX2DataGridViewTextBoxColumn";
            // 
            // sTDEX3DataGridViewTextBoxColumn
            // 
            this.sTDEX3DataGridViewTextBoxColumn.DataPropertyName = "STDEX3";
            this.sTDEX3DataGridViewTextBoxColumn.HeaderText = "STDEX3";
            this.sTDEX3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTDEX3DataGridViewTextBoxColumn.Name = "sTDEX3DataGridViewTextBoxColumn";
            // 
            // aVGDataGridViewTextBoxColumn
            // 
            this.aVGDataGridViewTextBoxColumn.DataPropertyName = "AVG";
            this.aVGDataGridViewTextBoxColumn.HeaderText = "AVG";
            this.aVGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aVGDataGridViewTextBoxColumn.Name = "aVGDataGridViewTextBoxColumn";
            // 
            // sTATUSDataGridViewCheckBoxColumn
            // 
            this.sTATUSDataGridViewCheckBoxColumn.DataPropertyName = "STATUS";
            this.sTATUSDataGridViewCheckBoxColumn.HeaderText = "STATUS";
            this.sTATUSDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.sTATUSDataGridViewCheckBoxColumn.Name = "sTATUSDataGridViewCheckBoxColumn";
            // 
            // tBLSTDBindingSource
            // 
            this.tBLSTDBindingSource.DataMember = "TBLSTD";
            this.tBLSTDBindingSource.DataSource = this.dbGradeDataSet;
            // 
            // dbGradeDataSet
            // 
            this.dbGradeDataSet.DataSetName = "DbGradeDataSet";
            this.dbGradeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLSTDTableAdapter
            // 
            this.tBLSTDTableAdapter.ClearBeforeFill = true;
            // 
            // FrmTeacherDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmTeacherDetails";
            this.Text = "FrmTeacherDetails";
            this.Load += new System.EventHandler(this.FrmTeacherDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSTDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGradeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox msknum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtex3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtex2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtex1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblfailed;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblclassavg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DbGradeDataSet dbGradeDataSet;
        private System.Windows.Forms.BindingSource tBLSTDBindingSource;
        private DbGradeDataSetTableAdapters.TBLSTDTableAdapter tBLSTDTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDEX1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDEX2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDEX3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sTATUSDataGridViewCheckBoxColumn;
    }
}
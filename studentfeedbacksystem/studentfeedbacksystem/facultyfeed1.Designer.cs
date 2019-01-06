namespace studentfeedbacksystem
{
    partial class facultyfeed1
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
            this.table99BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database143DataSet1 = new studentfeedbacksystem.Database143DataSet1();
            this.table99TableAdapter = new studentfeedbacksystem.Database143DataSet1TableAdapters.table99TableAdapter();
            this.table145BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database143DataSet2 = new studentfeedbacksystem.Database143DataSet2();
            this.table145TableAdapter = new studentfeedbacksystem.Database143DataSet2TableAdapters.table145TableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.database143DataSet4 = new studentfeedbacksystem.Database143DataSet4();
            this.table99BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.table99TableAdapter1 = new studentfeedbacksystem.Database143DataSet4TableAdapters.table99TableAdapter();
            this.facultyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultydepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.database143DataSet5 = new studentfeedbacksystem.Database143DataSet5();
            this.table145BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.table145TableAdapter1 = new studentfeedbacksystem.Database143DataSet5TableAdapters.table145TableAdapter();
            this.studentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingsubmittedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table99BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database143DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table145BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database143DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database143DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table99BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database143DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table145BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // table99BindingSource
            // 
            this.table99BindingSource.DataMember = "table99";
            this.table99BindingSource.DataSource = this.database143DataSet1;
            // 
            // database143DataSet1
            // 
            this.database143DataSet1.DataSetName = "Database143DataSet1";
            this.database143DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table99TableAdapter
            // 
            this.table99TableAdapter.ClearBeforeFill = true;
            // 
            // table145BindingSource
            // 
            this.table145BindingSource.DataMember = "table145";
            this.table145BindingSource.DataSource = this.database143DataSet2;
            // 
            // database143DataSet2
            // 
            this.database143DataSet2.DataSetName = "Database143DataSet2";
            this.database143DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table145TableAdapter
            // 
            this.table145TableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(500, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "WELCOME TO FACULTY FEEDBACK INFORMATION PANEL";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(646, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(497, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "SHOW THE UPDATED NO OF STUDENTS GIVEN FEEDBACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(24, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(463, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "SHOW THE UPDATED FEEDBACK RESULT FOR FACULTY";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.facultyidDataGridViewTextBoxColumn,
            this.facultynameDataGridViewTextBoxColumn,
            this.facultydepartmentDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.table99BindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(42, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 255);
            this.dataGridView1.TabIndex = 6;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentidDataGridViewTextBoxColumn,
            this.studentnameDataGridViewTextBoxColumn,
            this.branchDataGridViewTextBoxColumn,
            this.facultyidDataGridViewTextBoxColumn1,
            this.ratingsubmittedDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.table145BindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(609, 84);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(543, 255);
            this.dataGridView2.TabIndex = 7;
            // 
            // database143DataSet4
            // 
            this.database143DataSet4.DataSetName = "Database143DataSet4";
            this.database143DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table99BindingSource1
            // 
            this.table99BindingSource1.DataMember = "table99";
            this.table99BindingSource1.DataSource = this.database143DataSet4;
            // 
            // table99TableAdapter1
            // 
            this.table99TableAdapter1.ClearBeforeFill = true;
            // 
            // facultyidDataGridViewTextBoxColumn
            // 
            this.facultyidDataGridViewTextBoxColumn.DataPropertyName = "facultyid";
            this.facultyidDataGridViewTextBoxColumn.HeaderText = "facultyid";
            this.facultyidDataGridViewTextBoxColumn.Name = "facultyidDataGridViewTextBoxColumn";
            // 
            // facultynameDataGridViewTextBoxColumn
            // 
            this.facultynameDataGridViewTextBoxColumn.DataPropertyName = "facultyname";
            this.facultynameDataGridViewTextBoxColumn.HeaderText = "facultyname";
            this.facultynameDataGridViewTextBoxColumn.Name = "facultynameDataGridViewTextBoxColumn";
            // 
            // facultydepartmentDataGridViewTextBoxColumn
            // 
            this.facultydepartmentDataGridViewTextBoxColumn.DataPropertyName = "facultydepartment";
            this.facultydepartmentDataGridViewTextBoxColumn.HeaderText = "facultydepartment";
            this.facultydepartmentDataGridViewTextBoxColumn.Name = "facultydepartmentDataGridViewTextBoxColumn";
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "rating";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            // 
            // database143DataSet5
            // 
            this.database143DataSet5.DataSetName = "Database143DataSet5";
            this.database143DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table145BindingSource1
            // 
            this.table145BindingSource1.DataMember = "table145";
            this.table145BindingSource1.DataSource = this.database143DataSet5;
            // 
            // table145TableAdapter1
            // 
            this.table145TableAdapter1.ClearBeforeFill = true;
            // 
            // studentidDataGridViewTextBoxColumn
            // 
            this.studentidDataGridViewTextBoxColumn.DataPropertyName = "studentid";
            this.studentidDataGridViewTextBoxColumn.HeaderText = "studentid";
            this.studentidDataGridViewTextBoxColumn.Name = "studentidDataGridViewTextBoxColumn";
            // 
            // studentnameDataGridViewTextBoxColumn
            // 
            this.studentnameDataGridViewTextBoxColumn.DataPropertyName = "studentname";
            this.studentnameDataGridViewTextBoxColumn.HeaderText = "studentname";
            this.studentnameDataGridViewTextBoxColumn.Name = "studentnameDataGridViewTextBoxColumn";
            // 
            // branchDataGridViewTextBoxColumn
            // 
            this.branchDataGridViewTextBoxColumn.DataPropertyName = "branch";
            this.branchDataGridViewTextBoxColumn.HeaderText = "branch";
            this.branchDataGridViewTextBoxColumn.Name = "branchDataGridViewTextBoxColumn";
            // 
            // facultyidDataGridViewTextBoxColumn1
            // 
            this.facultyidDataGridViewTextBoxColumn1.DataPropertyName = "facultyid";
            this.facultyidDataGridViewTextBoxColumn1.HeaderText = "facultyid";
            this.facultyidDataGridViewTextBoxColumn1.Name = "facultyidDataGridViewTextBoxColumn1";
            // 
            // ratingsubmittedDataGridViewTextBoxColumn
            // 
            this.ratingsubmittedDataGridViewTextBoxColumn.DataPropertyName = "ratingsubmitted";
            this.ratingsubmittedDataGridViewTextBoxColumn.HeaderText = "ratingsubmitted";
            this.ratingsubmittedDataGridViewTextBoxColumn.Name = "ratingsubmittedDataGridViewTextBoxColumn";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(982, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 34);
            this.button3.TabIndex = 8;
            this.button3.Text = "exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // facultyfeed1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1192, 461);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Name = "facultyfeed1";
            this.Text = "facultyfeed1";
            this.Load += new System.EventHandler(this.facultyfeed1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table99BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database143DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table145BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database143DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database143DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table99BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database143DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table145BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Database143DataSet1 database143DataSet1;
        private System.Windows.Forms.BindingSource table99BindingSource;
        private Database143DataSet1TableAdapters.table99TableAdapter table99TableAdapter;
        private Database143DataSet2 database143DataSet2;
        private System.Windows.Forms.BindingSource table145BindingSource;
        private Database143DataSet2TableAdapters.table145TableAdapter table145TableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Database143DataSet4 database143DataSet4;
        private System.Windows.Forms.BindingSource table99BindingSource1;
        private Database143DataSet4TableAdapters.table99TableAdapter table99TableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultydepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private Database143DataSet5 database143DataSet5;
        private System.Windows.Forms.BindingSource table145BindingSource1;
        private Database143DataSet5TableAdapters.table145TableAdapter table145TableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingsubmittedDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
    }
}
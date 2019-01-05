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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database143DataSet1 = new studentfeedbacksystem.Database143DataSet1();
            this.table99BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table99TableAdapter = new studentfeedbacksystem.Database143DataSet1TableAdapters.table99TableAdapter();
            this.facultyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultydepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.database143DataSet2 = new studentfeedbacksystem.Database143DataSet2();
            this.table145BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table145TableAdapter = new studentfeedbacksystem.Database143DataSet2TableAdapters.table145TableAdapter();
            this.studentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingsubmittedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database143DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table99BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database143DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table145BindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.DataSource = this.table99BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(49, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 269);
            this.dataGridView1.TabIndex = 0;
            // 
            // database143DataSet1
            // 
            this.database143DataSet1.DataSetName = "Database143DataSet1";
            this.database143DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table99BindingSource
            // 
            this.table99BindingSource.DataMember = "table99";
            this.table99BindingSource.DataSource = this.database143DataSet1;
            // 
            // table99TableAdapter
            // 
            this.table99TableAdapter.ClearBeforeFill = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "STUDENT FEEDBACK INFORMATION FOR FACULTY";
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
            this.dataGridView2.DataSource = this.table145BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(534, 107);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(545, 269);
            this.dataGridView2.TabIndex = 2;
            // 
            // database143DataSet2
            // 
            this.database143DataSet2.DataSetName = "Database143DataSet2";
            this.database143DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table145BindingSource
            // 
            this.table145BindingSource.DataMember = "table145";
            this.table145BindingSource.DataSource = this.database143DataSet2;
            // 
            // table145TableAdapter
            // 
            this.table145TableAdapter.ClearBeforeFill = true;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(530, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(551, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "NO OF STUDENTS GIVEN FEEDBACK AND THEIR INFORMATION";
            // 
            // facultyfeed1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1192, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "facultyfeed1";
            this.Text = "facultyfeed1";
            this.Load += new System.EventHandler(this.facultyfeed1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database143DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table99BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database143DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table145BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database143DataSet1 database143DataSet1;
        private System.Windows.Forms.BindingSource table99BindingSource;
        private Database143DataSet1TableAdapters.table99TableAdapter table99TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultydepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Database143DataSet2 database143DataSet2;
        private System.Windows.Forms.BindingSource table145BindingSource;
        private Database143DataSet2TableAdapters.table145TableAdapter table145TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingsubmittedDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}
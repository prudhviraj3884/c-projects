namespace studentfeedbacksystem
{
    partial class facultyfeed
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
            this.database143DataSet = new studentfeedbacksystem.Database143DataSet();
            this.table99BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table99TableAdapter = new studentfeedbacksystem.Database143DataSetTableAdapters.table99TableAdapter();
            this.facultyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultydepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database143DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table99BindingSource)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(112, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 313);
            this.dataGridView1.TabIndex = 0;
            // 
            // database143DataSet
            // 
            this.database143DataSet.DataSetName = "Database143DataSet";
            this.database143DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table99BindingSource
            // 
            this.table99BindingSource.DataMember = "table99";
            this.table99BindingSource.DataSource = this.database143DataSet;
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "FEEDBACK INFORMATION FOR FACULTIES";
            // 
            // facultyfeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(843, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "facultyfeed";
            this.Text = "facultyfeed";
            this.Load += new System.EventHandler(this.facultyfeed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database143DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table99BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database143DataSet database143DataSet;
        private System.Windows.Forms.BindingSource table99BindingSource;
        private Database143DataSetTableAdapters.table99TableAdapter table99TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultydepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}
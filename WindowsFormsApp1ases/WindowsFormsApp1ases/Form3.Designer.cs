namespace WindowsFormsApp1ases
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.DOB = new System.Windows.Forms.TextBox();
            this.branch = new System.Windows.Forms.TextBox();
            this.section = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Database1_0DataSet = new WindowsFormsApp1ases._Database1_0DataSet();
            this.table1TableAdapter = new WindowsFormsApp1ases._Database1_0DataSetTableAdapters.Table1TableAdapter();
            this.REGISTER = new System.Windows.Forms.Button();
            this.DISPLAY = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Database1_0DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "IDNO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAME";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "SECTION";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "BRANCH";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "DATE OF BIRTH";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(138, 67);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 20);
            this.ID.TabIndex = 5;
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            // 
            // DOB
            // 
            this.DOB.Location = new System.Drawing.Point(188, 301);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(100, 20);
            this.DOB.TabIndex = 6;
            this.DOB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // branch
            // 
            this.branch.Location = new System.Drawing.Point(138, 244);
            this.branch.Name = "branch";
            this.branch.Size = new System.Drawing.Size(100, 20);
            this.branch.TabIndex = 7;
            this.branch.TextChanged += new System.EventHandler(this.branch_TextChanged);
            // 
            // section
            // 
            this.section.Location = new System.Drawing.Point(138, 182);
            this.section.Name = "section";
            this.section.Size = new System.Drawing.Size(100, 20);
            this.section.TabIndex = 8;
            this.section.TextChanged += new System.EventHandler(this.section_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(138, 125);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 9;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.branchDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.table1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(292, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 202);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // sectionDataGridViewTextBoxColumn
            // 
            this.sectionDataGridViewTextBoxColumn.DataPropertyName = "section";
            this.sectionDataGridViewTextBoxColumn.HeaderText = "section";
            this.sectionDataGridViewTextBoxColumn.Name = "sectionDataGridViewTextBoxColumn";
            // 
            // branchDataGridViewTextBoxColumn
            // 
            this.branchDataGridViewTextBoxColumn.DataPropertyName = "branch";
            this.branchDataGridViewTextBoxColumn.HeaderText = "branch";
            this.branchDataGridViewTextBoxColumn.Name = "branchDataGridViewTextBoxColumn";
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "dob";
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table1";
            this.table1BindingSource.DataSource = this._Database1_0DataSet;
            // 
            // _Database1_0DataSet
            // 
            this._Database1_0DataSet.DataSetName = "_Database1_0DataSet";
            this._Database1_0DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table1TableAdapter
            // 
            this.table1TableAdapter.ClearBeforeFill = true;
            // 
            // REGISTER
            // 
            this.REGISTER.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REGISTER.Location = new System.Drawing.Point(68, 360);
            this.REGISTER.Name = "REGISTER";
            this.REGISTER.Size = new System.Drawing.Size(119, 31);
            this.REGISTER.TabIndex = 11;
            this.REGISTER.Text = "REGISTER";
            this.REGISTER.UseVisualStyleBackColor = true;
            this.REGISTER.Click += new System.EventHandler(this.REGISTER_Click);
            // 
            // DISPLAY
            // 
            this.DISPLAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DISPLAY.Location = new System.Drawing.Point(213, 360);
            this.DISPLAY.Name = "DISPLAY";
            this.DISPLAY.Size = new System.Drawing.Size(100, 31);
            this.DISPLAY.TabIndex = 12;
            this.DISPLAY.Text = "SEARCH";
            this.DISPLAY.UseVisualStyleBackColor = true;
            this.DISPLAY.Click += new System.EventHandler(this.DISPLAY_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(380, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 31);
            this.button1.TabIndex = 13;
            this.button1.Text = "DISPLAY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DISPLAY);
            this.Controls.Add(this.REGISTER);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.section);
            this.Controls.Add(this.branch);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Database1_0DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox DOB;
        private System.Windows.Forms.TextBox branch;
        private System.Windows.Forms.TextBox section;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _Database1_0DataSet _Database1_0DataSet;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private _Database1_0DataSetTableAdapters.Table1TableAdapter table1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button REGISTER;
        private System.Windows.Forms.Button DISPLAY;
        private System.Windows.Forms.Button button1;
    }
}
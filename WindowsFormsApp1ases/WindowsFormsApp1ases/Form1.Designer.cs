namespace WindowsFormsApp1ases
{
    partial class Form1
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
            this.LABEL1 = new System.Windows.Forms.Label();
            this.LABEL2 = new System.Windows.Forms.Label();
            this.LOGIN = new System.Windows.Forms.Button();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LABEL1
            // 
            this.LABEL1.AutoSize = true;
            this.LABEL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL1.Location = new System.Drawing.Point(271, 137);
            this.LABEL1.Name = "LABEL1";
            this.LABEL1.Size = new System.Drawing.Size(109, 20);
            this.LABEL1.TabIndex = 0;
            this.LABEL1.Text = "USERNAME";
            this.LABEL1.Click += new System.EventHandler(this.LABEL1_Click);
            // 
            // LABEL2
            // 
            this.LABEL2.AutoSize = true;
            this.LABEL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL2.Location = new System.Drawing.Point(271, 212);
            this.LABEL2.Name = "LABEL2";
            this.LABEL2.Size = new System.Drawing.Size(111, 20);
            this.LABEL2.TabIndex = 1;
            this.LABEL2.Text = "PASSWORD";
            this.LABEL2.Click += new System.EventHandler(this.LABEL2_Click);
            // 
            // LOGIN
            // 
            this.LOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN.Location = new System.Drawing.Point(367, 282);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(106, 33);
            this.LOGIN.TabIndex = 2;
            this.LOGIN.Text = "LOGIN";
            this.LOGIN.UseVisualStyleBackColor = true;
            this.LOGIN.Click += new System.EventHandler(this.button1_Click);
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(415, 137);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(157, 20);
            this.TB1.TabIndex = 3;
            this.TB1.TextChanged += new System.EventHandler(this.TB1_TextChanged);
            // 
            // TB2
            // 
            this.TB2.Location = new System.Drawing.Point(415, 212);
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(157, 20);
            this.TB2.TabIndex = 4;
            this.TB2.TextChanged += new System.EventHandler(this.TB2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(362, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "LOGIN FORM";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.LOGIN);
            this.Controls.Add(this.LABEL2);
            this.Controls.Add(this.LABEL1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LABEL1;
        private System.Windows.Forms.Label LABEL2;
        private System.Windows.Forms.Button LOGIN;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.Label label3;
    }
}


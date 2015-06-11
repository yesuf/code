namespace Hospital.UI
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
            this.PatientName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtGen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.Button();
            this.txtSave = new System.Windows.Forms.Button();
            this.gvam = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvam)).BeginInit();
            this.SuspendLayout();
            // 
            // PatientName
            // 
            this.PatientName.AutoSize = true;
            this.PatientName.Location = new System.Drawing.Point(101, 27);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(68, 13);
            this.PatientName.TabIndex = 0;
            this.PatientName.Text = "PatientName";
            this.PatientName.Click += new System.EventHandler(this.PatientName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gender";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(196, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(263, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(196, 114);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(263, 20);
            this.txtCity.TabIndex = 7;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(196, 79);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(263, 20);
            this.txtAge.TabIndex = 8;
            // 
            // txtGen
            // 
            this.txtGen.Location = new System.Drawing.Point(196, 53);
            this.txtGen.Name = "txtGen";
            this.txtGen.Size = new System.Drawing.Size(263, 20);
            this.txtGen.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Age";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(526, 20);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(131, 26);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(526, 84);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(131, 26);
            this.txtDelete.TabIndex = 13;
            this.txtDelete.Text = "Delete";
            this.txtDelete.UseVisualStyleBackColor = true;
            this.txtDelete.Click += new System.EventHandler(this.txtDelete_Click);
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(526, 52);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(131, 26);
            this.txtSave.TabIndex = 14;
            this.txtSave.Text = "Save";
            this.txtSave.UseVisualStyleBackColor = true;
            this.txtSave.Click += new System.EventHandler(this.txtSave_Click);
            // 
            // gvam
            // 
            this.gvam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvam.Location = new System.Drawing.Point(56, 140);
            this.gvam.Name = "gvam";
            this.gvam.Size = new System.Drawing.Size(583, 125);
            this.gvam.TabIndex = 15;
            this.gvam.Click += new System.EventHandler(this.gvam_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 266);
            this.Controls.Add(this.gvam);
            this.Controls.Add(this.txtSave);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGen);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PatientName);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PatientName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtGen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button txtDelete;
        private System.Windows.Forms.Button txtSave;
        private System.Windows.Forms.DataGridView gvam;
    }
}
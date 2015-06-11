namespace Hospital.UI
{
    partial class Form5
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
            this.txtAD = new System.Windows.Forms.TextBox();
            this.cmbdoctor = new System.Windows.Forms.ComboBox();
            this.cmbPID = new System.Windows.Forms.ComboBox();
            this.cmbDID = new System.Windows.Forms.ComboBox();
            this.txtRD = new System.Windows.Forms.TextBox();
            this.txtwa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gvam = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvam)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAD
            // 
            this.txtAD.Location = new System.Drawing.Point(106, 12);
            this.txtAD.Name = "txtAD";
            this.txtAD.Size = new System.Drawing.Size(267, 20);
            this.txtAD.TabIndex = 4;
            // 
            // cmbdoctor
            // 
            this.cmbdoctor.FormattingEnabled = true;
            this.cmbdoctor.Location = new System.Drawing.Point(106, 38);
            this.cmbdoctor.Name = "cmbdoctor";
            this.cmbdoctor.Size = new System.Drawing.Size(267, 21);
            this.cmbdoctor.TabIndex = 10;
            // 
            // cmbPID
            // 
            this.cmbPID.FormattingEnabled = true;
            this.cmbPID.Location = new System.Drawing.Point(106, 96);
            this.cmbPID.Name = "cmbPID";
            this.cmbPID.Size = new System.Drawing.Size(267, 21);
            this.cmbPID.TabIndex = 12;
            // 
            // cmbDID
            // 
            this.cmbDID.FormattingEnabled = true;
            this.cmbDID.Location = new System.Drawing.Point(106, 65);
            this.cmbDID.Name = "cmbDID";
            this.cmbDID.Size = new System.Drawing.Size(267, 21);
            this.cmbDID.TabIndex = 13;
            // 
            // txtRD
            // 
            this.txtRD.Location = new System.Drawing.Point(106, 123);
            this.txtRD.Name = "txtRD";
            this.txtRD.Size = new System.Drawing.Size(267, 20);
            this.txtRD.TabIndex = 14;
            // 
            // txtwa
            // 
            this.txtwa.Location = new System.Drawing.Point(106, 149);
            this.txtwa.Name = "txtwa";
            this.txtwa.Size = new System.Drawing.Size(267, 20);
            this.txtwa.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Admission Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Doctor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "DoctorID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "PatientId";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "RelaseDate";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 213);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(88, 32);
            this.btnNew.TabIndex = 21;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(213, 213);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 32);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(106, 213);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 32);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gvam
            // 
            this.gvam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvam.Location = new System.Drawing.Point(410, 2);
            this.gvam.Name = "gvam";
            this.gvam.Size = new System.Drawing.Size(302, 252);
            this.gvam.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Ward";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 266);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gvam);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtwa);
            this.Controls.Add(this.txtRD);
            this.Controls.Add(this.cmbDID);
            this.Controls.Add(this.cmbPID);
            this.Controls.Add(this.cmbdoctor);
            this.Controls.Add(this.txtAD);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAD;
        private System.Windows.Forms.ComboBox cmbdoctor;
        private System.Windows.Forms.ComboBox cmbPID;
        private System.Windows.Forms.ComboBox cmbDID;
        private System.Windows.Forms.TextBox txtRD;
        private System.Windows.Forms.TextBox txtwa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView gvam;
        private System.Windows.Forms.Label label6;
    }
}
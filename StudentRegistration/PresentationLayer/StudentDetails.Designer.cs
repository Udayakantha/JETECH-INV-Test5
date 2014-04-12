namespace StudentRegistration
{
    partial class StudentDetails
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
            this.dataGridViewStudentDetails = new System.Windows.Forms.DataGridView();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudentDetails
            // 
            this.dataGridViewStudentDetails.AllowUserToAddRows = false;
            this.dataGridViewStudentDetails.AllowUserToDeleteRows = false;
            this.dataGridViewStudentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentDetails.Location = new System.Drawing.Point(12, 54);
            this.dataGridViewStudentDetails.Name = "dataGridViewStudentDetails";
            this.dataGridViewStudentDetails.ReadOnly = true;
            this.dataGridViewStudentDetails.Size = new System.Drawing.Size(599, 283);
            this.dataGridViewStudentDetails.TabIndex = 0;
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Location = new System.Drawing.Point(12, 12);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(75, 23);
            this.buttonAddNew.TabIndex = 1;
            this.buttonAddNew.Text = "&AddNew";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 349);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAddNew);
            this.Controls.Add(this.dataGridViewStudentDetails);
            this.Name = "StudentDetails";
            this.Text = "StudentDetails";
            this.Load += new System.EventHandler(this.StudentDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudentDetails;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Button button1;
    }
}
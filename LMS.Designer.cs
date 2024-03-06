namespace Assignemt_4._3
{
    partial class LMS
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
            this.dataGridViewLMS = new System.Windows.Forms.DataGridView();
            this.lblStudID = new System.Windows.Forms.Label();
            this.txtStudID = new System.Windows.Forms.TextBox();
            this.txtStudName = new System.Windows.Forms.TextBox();
            this.lblStudName = new System.Windows.Forms.Label();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.lblGPA = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLMS)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLMS
            // 
            this.dataGridViewLMS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLMS.Location = new System.Drawing.Point(59, 59);
            this.dataGridViewLMS.Name = "dataGridViewLMS";
            this.dataGridViewLMS.Size = new System.Drawing.Size(597, 129);
            this.dataGridViewLMS.TabIndex = 0;
            this.dataGridViewLMS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLMS_CellContentClick);
            // 
            // lblStudID
            // 
            this.lblStudID.AutoSize = true;
            this.lblStudID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudID.Location = new System.Drawing.Point(38, 226);
            this.lblStudID.Name = "lblStudID";
            this.lblStudID.Size = new System.Drawing.Size(84, 17);
            this.lblStudID.TabIndex = 1;
            this.lblStudID.Text = "Student ID";
            // 
            // txtStudID
            // 
            this.txtStudID.Location = new System.Drawing.Point(161, 226);
            this.txtStudID.Name = "txtStudID";
            this.txtStudID.Size = new System.Drawing.Size(199, 20);
            this.txtStudID.TabIndex = 2;
            this.txtStudID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtStudName
            // 
            this.txtStudName.Location = new System.Drawing.Point(161, 271);
            this.txtStudName.Name = "txtStudName";
            this.txtStudName.Size = new System.Drawing.Size(199, 20);
            this.txtStudName.TabIndex = 4;
            // 
            // lblStudName
            // 
            this.lblStudName.AutoSize = true;
            this.lblStudName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudName.Location = new System.Drawing.Point(38, 271);
            this.lblStudName.Name = "lblStudName";
            this.lblStudName.Size = new System.Drawing.Size(110, 17);
            this.lblStudName.TabIndex = 3;
            this.lblStudName.Text = "Student Name";
            // 
            // txtGPA
            // 
            this.txtGPA.Location = new System.Drawing.Point(161, 314);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(199, 20);
            this.txtGPA.TabIndex = 6;
            // 
            // lblGPA
            // 
            this.lblGPA.AutoSize = true;
            this.lblGPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPA.Location = new System.Drawing.Point(38, 314);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(40, 17);
            this.lblGPA.TabIndex = 5;
            this.lblGPA.Text = "GPA";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(184, 360);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(144, 36);
            this.btnAddStudent.TabIndex = 7;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(480, 226);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 36);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete Student";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(480, 281);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(138, 36);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Save";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(480, 333);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 33);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 35);
            this.label1.TabIndex = 11;
            this.label1.Text = "Learning Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(731, 408);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.txtGPA);
            this.Controls.Add(this.lblGPA);
            this.Controls.Add(this.txtStudName);
            this.Controls.Add(this.lblStudName);
            this.Controls.Add(this.txtStudID);
            this.Controls.Add(this.lblStudID);
            this.Controls.Add(this.dataGridViewLMS);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LMS";
            this.Load += new System.EventHandler(this.LMS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLMS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLMS;
        private System.Windows.Forms.Label lblStudID;
        private System.Windows.Forms.TextBox txtStudID;
        private System.Windows.Forms.TextBox txtStudName;
        private System.Windows.Forms.Label lblStudName;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.Label lblGPA;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}
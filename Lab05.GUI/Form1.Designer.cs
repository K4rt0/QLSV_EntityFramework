namespace Lab05.GUI
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
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnAction = new System.Windows.Forms.Button();
			this.btnImportPic = new System.Windows.Forms.Button();
			this.picAvatar = new System.Windows.Forms.PictureBox();
			this.cmbFaculty = new System.Windows.Forms.ComboBox();
			this.txtScore = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvStudent = new System.Windows.Forms.DataGridView();
			this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FacultyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AverageScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MajorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.chbListMajor = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(242, 15);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(282, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "Quản Lý Sinh Viên";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnDel);
			this.groupBox1.Controls.Add(this.btnAction);
			this.groupBox1.Controls.Add(this.btnImportPic);
			this.groupBox1.Controls.Add(this.picAvatar);
			this.groupBox1.Controls.Add(this.cmbFaculty);
			this.groupBox1.Controls.Add(this.txtScore);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtID);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(17, 75);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox1.Size = new System.Drawing.Size(248, 309);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông Tin Sinh Viên";
			// 
			// btnDel
			// 
			this.btnDel.Location = new System.Drawing.Point(128, 264);
			this.btnDel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(76, 37);
			this.btnDel.TabIndex = 5;
			this.btnDel.Text = "Xoá";
			this.btnDel.UseVisualStyleBackColor = true;
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// btnAction
			// 
			this.btnAction.Location = new System.Drawing.Point(32, 264);
			this.btnAction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnAction.Name = "btnAction";
			this.btnAction.Size = new System.Drawing.Size(91, 37);
			this.btnAction.TabIndex = 5;
			this.btnAction.Text = "Thêm / Sửa";
			this.btnAction.UseVisualStyleBackColor = true;
			this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
			// 
			// btnImportPic
			// 
			this.btnImportPic.Location = new System.Drawing.Point(57, 191);
			this.btnImportPic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnImportPic.Name = "btnImportPic";
			this.btnImportPic.Size = new System.Drawing.Size(26, 19);
			this.btnImportPic.TabIndex = 4;
			this.btnImportPic.Text = "...";
			this.btnImportPic.UseVisualStyleBackColor = true;
			this.btnImportPic.Click += new System.EventHandler(this.btnImportPic_Click);
			// 
			// picAvatar
			// 
			this.picAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picAvatar.Location = new System.Drawing.Point(90, 126);
			this.picAvatar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picAvatar.Name = "picAvatar";
			this.picAvatar.Size = new System.Drawing.Size(154, 134);
			this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picAvatar.TabIndex = 3;
			this.picAvatar.TabStop = false;
			// 
			// cmbFaculty
			// 
			this.cmbFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbFaculty.FormattingEnabled = true;
			this.cmbFaculty.Location = new System.Drawing.Point(90, 79);
			this.cmbFaculty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cmbFaculty.Name = "cmbFaculty";
			this.cmbFaculty.Size = new System.Drawing.Size(155, 21);
			this.cmbFaculty.TabIndex = 2;
			// 
			// txtScore
			// 
			this.txtScore.Location = new System.Drawing.Point(90, 102);
			this.txtScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtScore.Name = "txtScore";
			this.txtScore.Size = new System.Drawing.Size(155, 20);
			this.txtScore.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(4, 126);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(70, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Ảnh Đại Diện";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(90, 56);
			this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(155, 20);
			this.txtName.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(4, 103);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(86, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Điểm Trung Bình";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(4, 58);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Họ Tên";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(4, 80);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Khoa";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(90, 33);
			this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(155, 20);
			this.txtID.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(4, 35);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Mã Sinh Viên";
			// 
			// dgvStudent
			// 
			this.dgvStudent.AllowUserToAddRows = false;
			this.dgvStudent.AllowUserToDeleteRows = false;
			this.dgvStudent.AllowUserToResizeColumns = false;
			this.dgvStudent.AllowUserToResizeRows = false;
			this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.FullName,
            this.FacultyName,
            this.AverageScore,
            this.MajorName});
			this.dgvStudent.Location = new System.Drawing.Point(270, 75);
			this.dgvStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dgvStudent.Name = "dgvStudent";
			this.dgvStudent.RowHeadersWidth = 51;
			this.dgvStudent.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvStudent.RowTemplate.Height = 24;
			this.dgvStudent.Size = new System.Drawing.Size(518, 309);
			this.dgvStudent.TabIndex = 2;
			this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);
			// 
			// StudentID
			// 
			this.StudentID.HeaderText = "MSSV";
			this.StudentID.MinimumWidth = 6;
			this.StudentID.Name = "StudentID";
			this.StudentID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// FullName
			// 
			this.FullName.HeaderText = "Họ Tên";
			this.FullName.MinimumWidth = 6;
			this.FullName.Name = "FullName";
			this.FullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.FullName.Width = 150;
			// 
			// FacultyName
			// 
			this.FacultyName.HeaderText = "Khoa";
			this.FacultyName.MinimumWidth = 6;
			this.FacultyName.Name = "FacultyName";
			this.FacultyName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.FacultyName.Width = 150;
			// 
			// AverageScore
			// 
			this.AverageScore.HeaderText = "ĐTB";
			this.AverageScore.MinimumWidth = 6;
			this.AverageScore.Name = "AverageScore";
			this.AverageScore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.AverageScore.Width = 70;
			// 
			// MajorName
			// 
			this.MajorName.HeaderText = "Chuyên ngành";
			this.MajorName.MinimumWidth = 6;
			this.MajorName.Name = "MajorName";
			this.MajorName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MajorName.Width = 150;
			// 
			// chbListMajor
			// 
			this.chbListMajor.AutoSize = true;
			this.chbListMajor.Location = new System.Drawing.Point(608, 54);
			this.chbListMajor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.chbListMajor.Name = "chbListMajor";
			this.chbListMajor.Size = new System.Drawing.Size(164, 17);
			this.chbListMajor.TabIndex = 3;
			this.chbListMajor.Text = "Chưa đăng ký chuyên ngành";
			this.chbListMajor.UseVisualStyleBackColor = true;
			this.chbListMajor.CheckedChanged += new System.EventHandler(this.chbListMajor_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(796, 396);
			this.Controls.Add(this.chbListMajor);
			this.Controls.Add(this.dgvStudent);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbFaculty;
		private System.Windows.Forms.TextBox txtScore;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnImportPic;
		private System.Windows.Forms.PictureBox picAvatar;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Button btnAction;
		private System.Windows.Forms.DataGridView dgvStudent;
		private System.Windows.Forms.CheckBox chbListMajor;
		private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
		private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
		private System.Windows.Forms.DataGridViewTextBoxColumn FacultyName;
		private System.Windows.Forms.DataGridViewTextBoxColumn AverageScore;
		private System.Windows.Forms.DataGridViewTextBoxColumn MajorName;
	}
}


using LAB05.BUS;
using LAB05.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05.GUI
{
	public partial class Form1 : Form
	{
		private readonly StudentServices studentService = new StudentServices();
		private readonly FacultyServices facultyService = new FacultyServices();
		public Form1()
		{
			InitializeComponent();
		}

		#region Methods
		void loadFaculty(List<Faculty> faculties)
		{
			faculties.Insert(0, new Faculty());
			cmbFaculty.DataSource = faculties;
			cmbFaculty.DisplayMember = "FacultyName";
			cmbFaculty.ValueMember = "FacultyID";
		}

		void loadStudent(List<Student> students)
		{
			dgvStudent.Rows.Clear();
			foreach (var item in students)
			{
				int index = dgvStudent.Rows.Add();
				dgvStudent.Rows[index].Cells[0].Value = item.StudentID;
				dgvStudent.Rows[index].Cells[1].Value = item.FullName;
				if (item.Faculty != null)
				{
					dgvStudent.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
					dgvStudent.Rows[index].Cells[3].Value = item.AverageScore + "";
				}
				if (item.Major != null)
				{
					dgvStudent.Rows[index].Cells[4].Value = item.Major.MajorName + "";
				}
			}
		}
		#endregion

		private void Form1_Load(object sender, EventArgs e)
		{
			loadFaculty(facultyService.GetAll());
			loadStudent(studentService.GetAll());
			picAvatar.Tag = "";
		}
		private void btnAction_Click(object sender, EventArgs e)
		{
			if (txtID.Text == "" || txtName.Text == "" || txtScore.Text == "" || cmbFaculty.Text == "")
				MessageBox.Show("Bạn chưa nhập đầy đủ thông tin.");
			else
			{
				StudentModel studentModel = new StudentModel();
				Faculty selectedFacultyObj = studentModel.Faculty.FirstOrDefault(f => f.FacultyName == cmbFaculty.Text);
				Student std = new Student() { StudentID = txtID.Text, FullName = txtName.Text, AverageScore = double.Parse(txtScore.Text), FacultyID = selectedFacultyObj.FacultyID, Avatar = picAvatar.Tag != null ? picAvatar.Tag.ToString() : "" };
				
				DialogResult result;
				if (picAvatar.Tag.ToString() == "")
				{
					result = MessageBox.Show("Bạn chưa chọn hình ảnh, bạn có muốn quay lại chính sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

					if(result == DialogResult.No)
					{
						studentService.UpdateStudent(std);
						loadStudent(studentService.GetAll());
					}
					return;
				}
				studentService.UpdateStudent(std);
				loadStudent(studentService.GetAll());
			}
		}

		private void btnDel_Click(object sender, EventArgs e)
		{
			if (dgvStudent.SelectedRows.Count < 1)
				MessageBox.Show("Bạn chưa chọn vào người cần xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			else
			{
				DialogResult dl = MessageBox.Show("Bạn có chắc chắn muốn xoá nhân viên này hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dl == DialogResult.Yes)
				{
					StudentModel studentModel = new StudentModel();
					Student std = studentModel.Student.FirstOrDefault(p => p.StudentID == txtID.Text);
					if (std == null)
						MessageBox.Show("Không tìm thấy sinh viên với StudentID này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					else
					{
						studentModel.Student.Remove(std);
						studentModel.SaveChanges();
						loadStudent(studentModel.Student.ToList());
					}
				}
			}
		}

		private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			if (index != -1)
			{
				txtID.Text = dgvStudent.Rows[index].Cells[0].Value.ToString();
				txtName.Text = dgvStudent.Rows[index].Cells[1].Value.ToString();
				cmbFaculty.Text = dgvStudent.Rows[index].Cells[2].Value.ToString();
				txtScore.Text = dgvStudent.Rows[index].Cells[3].Value.ToString();

				StudentModel studentModel = new StudentModel();
				Student std = studentModel.Student.FirstOrDefault(p => p.StudentID == txtID.Text);
				if(std != null)
				{
					picAvatar.Image = std.Avatar != "" ? Image.FromFile(Application.StartupPath + "\\Images\\" + std.Avatar) : null;
					picAvatar.Tag = std.Avatar != "" ? std.Avatar : "";
				}
			}
		}


		private void chbListMajor_CheckedChanged(object sender, EventArgs e)
		{
			List<Student> listStudent = new List<Student>();
			listStudent = chbListMajor.Checked ? studentService.GetAllHasNoMajor() : studentService.GetAll();
			loadStudent(listStudent);
		}

		private void btnImportPic_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "Image (*.jpg *png)|*.jpg;*.png;";
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				string imagePath = dlg.FileName;
				picAvatar.Image = Image.FromFile(imagePath);
				picAvatar.Tag = Path.GetFileName(imagePath);
			}
		}
	}
}

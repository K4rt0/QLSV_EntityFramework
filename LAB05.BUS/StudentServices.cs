using LAB05.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB05.BUS
{
	public class StudentServices
	{
		public List<Student> GetAll()
		{
			StudentModel student = new StudentModel();
			return student.Student.ToList();
		}
		public Student FindByID(string studentID)
		{
			StudentModel context = new StudentModel();
			return context.Student.FirstOrDefault(p => p.StudentID == studentID);
		}
		public void UpdateStudent(Student student)
		{
			StudentModel context = new StudentModel();
			context.Student.AddOrUpdate(student);
			context.SaveChanges();
		}
		public List<Student> GetAllHasNoMajor()
		{
			StudentModel context = new StudentModel();
			return context.Student.Where(p => p.MajorID == null).ToList();
		}
	}
}

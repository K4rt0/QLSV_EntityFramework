using LAB05.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB05.BUS
{
	public class FacultyServices
	{
		public List<Faculty> GetAll()
		{
			StudentModel context = new StudentModel();
			return context.Faculty.ToList();
		}
	}
}

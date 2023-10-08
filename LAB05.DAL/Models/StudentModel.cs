using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LAB05.DAL.Models
{
	public partial class StudentModel : DbContext
	{
		public StudentModel()
			: base("name=StudentModel")
		{
		}

		public virtual DbSet<Faculty> Faculty { get; set; }
		public virtual DbSet<Major> Major { get; set; }
		public virtual DbSet<Student> Student { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Faculty>()
				.HasMany(e => e.Major)
				.WithRequired(e => e.Faculty)
				.WillCascadeOnDelete(false);
		}
	}
}

using C42_G01_EF01.Context;
using C42_G01_EF01.Entities;
using Microsoft.EntityFrameworkCore.Design;

namespace EF02
{
	internal class Program
	{
		static void Main(string[] args)
		{
			using CompanyDbContext context = new CompanyDbContext();

			var Student01 = new Student
			{
				FName = "joo",
				LName = "ayman",
				Address = "15 Street",
				Age = 24,
				Dep_Id = 1
			};
			var Student02 = new Student
			{
				FName = "yousef",
				LName = "ayman",
				Address = "15 Street",
				Age = 22,
				Dep_Id = 2
			};

			Console.WriteLine(context.Entry(Student01).State);//detached
			context.Add(Student01);
			Console.WriteLine(context.Entry(Student01).State);//added
			context.SaveChanges();
			Console.WriteLine(context.Entry(Student01).State); //unchanged


		}
	}
}

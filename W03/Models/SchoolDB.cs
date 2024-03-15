using Bogus;

namespace W03.Models
{
	//Mock Database, only for simulation
	public static class SchoolDB
	{
		public static List<Student> Students = new List<Student>();

		public static void InitialiazeDb(int number)
		{
			if (Students.Count == 0)
			{
				for(int i = 1; i <= number; i++)
				{
					var student = new Faker<Student>()
						.RuleFor(s => s.Id, f => i)
						.RuleFor(s => s.Name, f => f.Name.FullName())
						.RuleFor(s => s.Email, (f, s) => f.Internet.Email(s.Name))
						.RuleFor(s => s.Age, f => f.Random.Int(18, 30));

					Students.Add(student);
				}
			}
		}
	}
}

using Microsoft.AspNetCore.Mvc;

namespace WebApiExample.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class WeatherForecastController : ControllerBase
	{
		[HttpGet("/name")]
		public string GetData()
		{
			

			string name = "arun";

			return name;
		}

		[HttpGet("/student")]
        public Student StudentData()
        {
            Student student = new Student()
            {
                Name = "arun kumar",
                Id = Guid.NewGuid(),
                Age = 23,
                Marks = 99.23f
            };
            return student;
        }

    }

	public class Student
	{
		public string Name { get; set; }
		public Guid Id { get; set; }
		public int Age { get; set; }
		public float Marks { get; set; }
			

	}
}

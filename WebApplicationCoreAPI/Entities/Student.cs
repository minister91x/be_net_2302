namespace WebApplicationCoreAPI.Entities
{
    public class Student
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public ILogger _logger { get; set; }
        public Student(string name, string department, ILogger<Student> logger)
        {
            Name = name;
            Department = department;
            _logger = logger;
            _logger.LogInformation("Name of student is " + Name + " and his department is " + Department);
        }

    }
}

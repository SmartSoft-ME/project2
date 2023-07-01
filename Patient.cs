namespace project2
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Address { get; set; }
        public int Age { get; set; }

        public string Injury;
        public Patient(int id, string name, string? address, int age, string injury)
        {
            Injury = injury;
            Id = id;
            Name = name;
            Address = address;
            Age = age;
        }
    }
}

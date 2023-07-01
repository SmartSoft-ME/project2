using project2;

List<Patient> patients = new();
void CreatePatient()
{
    Console.WriteLine("Name:");
    var name = Console.ReadLine();
    while (string.IsNullOrEmpty(name))
    {
        Console.WriteLine("Name can't be null or empty!");
        Console.WriteLine("Name:");
        name = Console.ReadLine();
    }
    Console.WriteLine("Address:");
    var address = Console.ReadLine();
    Console.WriteLine("Age:");
    var inputAge = Console.ReadLine();
    while (string.IsNullOrEmpty(inputAge))
    {
        Console.WriteLine("Age can't be null or empty!");
        Console.WriteLine("Age:");
        inputAge = Console.ReadLine();
    }
    int age = int.Parse(inputAge);
    Console.WriteLine("Injury");
    var injury = Console.ReadLine();
    while (string.IsNullOrEmpty(injury))
    {
        Console.WriteLine("Injury can't be null or empty!");
        Console.WriteLine("Injury:");
        injury = Console.ReadLine();
    }
    int id = patients.Max(p => p.Id) + 1;
    var patient = new Patient(id, name, address, age, injury);
    patients.Add(patient);

}
void RemovePatient()
{
    Console.WriteLine("Give the patient id to remove.");
    var inputId = Console.ReadLine();
    while (string.IsNullOrEmpty(inputId))
    {
        Console.WriteLine("Id can't be null or empty!");
        Console.WriteLine("Give the patient id to remove.");
        inputId = Console.ReadLine();
    }
    int id = int.Parse(inputId);
    var patient = patients.Find(p => p.Id == id);
    if (patient != null)
    {
        patients.Remove(patient);
        Console.WriteLine($"{patient.Name} is removed");
    }
    else
        Console.WriteLine("The patient doesn't exist");
}
void UpdatePatient()
{
    Console.WriteLine("give the patient id to update");
    int id = int.Parse(Console.ReadLine());
    Patient pa = patients.Find(p => p.Id == id);
    if (pa != null)
    {
        Console.WriteLine("Enter new patient details:");
        Console.Write("Name: ");
        pa.Name = Console.ReadLine();
        Console.Write("Age: ");
        pa.Age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Address: ");
        pa.Address = Console.ReadLine();
        Console.WriteLine("Injury");
        pa.Injury = Console.ReadLine();
    }
    else
        Console.WriteLine("patient unavailable");
}
void Display()
{
    foreach (var p in patients)
    {
        Console.WriteLine("ID: " + p.Id);
        Console.WriteLine("Name: " + p.Name);
        Console.WriteLine("Address: " + p.Address);
        Console.WriteLine("Age: " + p.Age);
        Console.WriteLine("Injury: " + p.Injury);
    }
}

while (true)
{
    Console.WriteLine("1-create a patient");
    Console.WriteLine("2-remove a patient");
    Console.WriteLine("3-update a patient");
    Console.WriteLine("4-display the patients");

    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            CreatePatient();
            break;
        case 2:
            RemovePatient();
            break;
        case 3:
            UpdatePatient();
            break;
        case 4:
            Display();
            break;
        default:
            Console.WriteLine("invalid,please choose another option:");
            break;
    }
}

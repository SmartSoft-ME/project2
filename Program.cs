using System;
using System.Collections.Generic;

namespace project2
{
    public class Patient
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public string Injury;
        public Patient(int id, string name, string address, int age, string injury)
        {
            Injury = injury;
            Id = id;
            Name = name;
            Address = address;
            Age = age;
        }
    }
    internal class Program
    {
        static List<Patient> lst = new List<Patient>();
        static void CreatePatient()
        {
            Console.WriteLine("Id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Address");
            string address = Console.ReadLine();
            Console.WriteLine("age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("injury");
            string injury = Console.ReadLine();
            Patient pa = new Patient(id, name, address, age, injury);
            lst.Add(pa);

        }
        static void RemovePatient()
        {
            Console.WriteLine("give the patient id to remove");
            int id = int.Parse(Console.ReadLine());
            Patient pa = lst.Find(p => p.Id == id);
            if (pa != null)
            {
                lst.Remove(pa);
                Console.WriteLine("the patient is removed");
            }
            else
                Console.WriteLine("the patient didnt exist");
        }
        static void UpdatePatient()
        {
            Console.WriteLine("give the patient id to update");
            int id = int.Parse(Console.ReadLine());
            Patient pa = lst.Find(p => p.Id == id);
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
        static void Display()
        {
            foreach (var p in lst)
            {
                Console.WriteLine("ID: " + p.Id);
                Console.WriteLine("Name: " + p.Name);
                Console.WriteLine("Address: " + p.Address);
                Console.WriteLine("Age: " + p.Age);
                Console.WriteLine("Injury: " + p.Injury);
            }
        }

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("1-create a pateint");
                Console.WriteLine("2-remove a patient");
                Console.WriteLine("3-update a patient");
                Console.WriteLine("4-display the patients");

                int choix = Convert.ToInt32(Console.ReadLine());
                switch (choix)
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
        }

    }
}
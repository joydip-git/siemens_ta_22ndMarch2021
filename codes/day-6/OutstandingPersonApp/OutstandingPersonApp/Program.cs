using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutstandingPersonApp
{
    class Program
    {
        static void PrintMenu()
        {
            Console.WriteLine("1. Author");
            Console.WriteLine("2. Student");
        }
        static char GetChoice()
        {
            Console.Write("\nEnter Choice[a/A/s/S]: ");
            char choice = char.Parse(Console.ReadLine());
            return char.IsUpper(choice) ? char.ToLower(choice) : choice;
            //if (char.IsUpper(choice))
            //{
            //    choice = char.ToLower(choice);
            //}
            //return choice;
        }
        static int GetCount()
        {
            Console.Write("How many records? ");
            return int.Parse(Console.ReadLine());
        }
        static Person[] CreateStorage(int count)
        {
            Person[] people = new Person[count];
            return people;
        }
        static Person CreatePerson(char choice)
        {
            Person person = null;
            Console.Write("\nName: ");
            string name = Console.ReadLine();
            switch (choice)
            {
                case 'a':
                    Console.Write("Number of books published? ");
                    int number = int.Parse(Console.ReadLine());
                    person = new Author(name, number);
                    break;

                case 's':
                    Console.Write("Marks Obtained? ");
                    double marks = double.Parse(Console.ReadLine());
                    person = new Student(name, marks);
                    break;

                default:
                    Console.WriteLine("\nEnter proper choice");
                    break;
            }
            return person;
        }
        static void AddRecord(Person[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                PrintMenu();
                char choice = GetChoice();
                Person person = CreatePerson(choice);
                people[i] = person;
            }
        }
        static void PrintOustandingPerson(Person[] people)
        {
            foreach (Person person in people)
            {
                if(person != null)
                {
                    bool isOutstanding = person.IsOutstanding();
                    if (isOutstanding)
                    {
                        if(person is Author)
                        {
                            Author author = person as Author;
                            string information = author.Show();
                            Console.WriteLine(information);
                        }
                        if (person is Student)
                        {
                            Student student = person as Student;
                            string information = student.Print();
                            Console.WriteLine(information);
                        }
                    }
                }
            }
        }
        static void Main()
        {
            int recordCount = GetCount();
            Person[] people = CreateStorage(recordCount);
            AddRecord(people);
            PrintOustandingPerson(people);
        }
    }
}

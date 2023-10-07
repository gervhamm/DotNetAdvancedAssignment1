using DotNetAdvancedAssignment1.Model;

namespace DotNetAdvancedAssignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student();
            student1.FirstName = "Gert";
            student1.FirstName = "Van Hamme";
            student1.Age = 30;

            var teacher1 = new Teacher();
            teacher1.FirstName = "Werner";
            teacher1.LastName = "von Siemens";
            teacher1.Age = 99;
            teacher1.courses[0] = null;
            teacher1.courses[1] = "Java";

            DeclareName(student1);

            List<Person> persons = new List<Person>();
            persons.Add(student1);
            persons.Add(teacher1);

            foreach (Person person in persons)
            {
                Print(person);
                Console.WriteLine("Age: {0}",person.Age);
            }

        }

        static void Print (Person person)
        {
            Console.WriteLine("{0} {1}", person.FirstName,person.LastName);
        }
        static void DeclareName(Person person)
        {
            Console.WriteLine("Enter first name:");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter last name:");
            var lastName = Console.ReadLine();
            Console.WriteLine("You entered: {0} {1}", firstName, lastName);

            person.FirstName = firstName;
            person.LastName = lastName;
        }
    }
}
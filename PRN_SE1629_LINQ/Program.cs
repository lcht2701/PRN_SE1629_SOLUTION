using System.Linq;
using PRN_SE1629;

string[] names = { "dong", "hai", "long", "Nguyen Van C", "Park Hang Seo", "Cong Phuong" };

var orderedNames = names.OrderBy(x => x.Length); 

foreach (string name in orderedNames)
{
    Console.WriteLine(name);
}

Console.WriteLine("==========================================");

SortedSet<string> sorted = new SortedSet<string>(names);
foreach (string name in sorted)
{
    Console.WriteLine(name);
}

//Define 1 tap hop Student
List<Student> students = new List<Student>();
students.Add(new Student(1, 8.5d));
students.Add(new Student(2, 5.5d));
students.Add(new Student(3, 9d));
students.Add(new Student(4, 4.5d));
students.Add(new Student(5, 7d));
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    public class Group
    {

        public string Grp { get; set; }
        double average = 0;
        private List<Student> students = new List<Student>();

        public void AddStudent(Student obj)
        {
            students.Add(obj);

        }

        public void findYoungest()
        {

            students.Sort((x, y) => Comparer<int>.Default.Compare(x.Age, y.Age));
            Console.WriteLine($"youngest student is: {students[0].FirstName} with {students[0].Age} years.");
        }

        public void OldestStudent()
        {

            students.Sort((x, y) => Comparer<int>.Default.Compare(x.Age, y.Age));
            students.Reverse();
            Console.WriteLine($"oldest student is: {students[0].FirstName} with {students[0].Age} years.");

        }
        public void findShortestName()
        {
            students.Sort((x, y) => Comparer<int>.Default.Compare(x.GetNameLength(), y.GetNameLength()));

            Console.WriteLine($"shortest student's name is: {students[0].FirstName} with {students[0].GetNameLength()} characters.");
        }

        public void findLongestName()
        {

            students.Sort((x, y) => Comparer<int>.Default.Compare(x.GetNameLength(), y.GetNameLength()));
            students.Reverse();
            Console.WriteLine($"longest student's name is: {students[0].FirstName} with {students[0].GetNameLength()} characters.");
        }

        public void findShortestLastName()
        {
            students.Sort((x, y) => Comparer<int>.Default.Compare(x.GetLastNameLength(), y.GetLastNameLength()));

            Console.WriteLine($"shortest student's Last Name is: {students[0].LastName} with {students[0].GetLastNameLength()} characters.");
        }


        public void findLongestLastName()
        {

            students.Sort((x, y) => Comparer<int>.Default.Compare(x.GetLastNameLength(), y.GetLastNameLength()));
            students.Reverse();
            Console.WriteLine($"longest student's Last Name is: {students[0].LastName} with {students[0].GetLastNameLength()} characters.");
        }


        public void findAverageYears()
        {

            foreach (var student in students)
            {
                average += student.Age;
            }
            average /= students.Count;
            Console.WriteLine($"average students Age is {average} years.");
        }

        public void CountStudents()
        {
            Console.WriteLine($"group '4' have {students.Count} students.");
        }
    }
}

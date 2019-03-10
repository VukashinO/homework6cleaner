using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class Program
    {

        static void Main(string[] args)
        {


            GetGroup();
        }





        public static Group GetGroup()
        {
            var group4Summary = new Group() { Grp = "G4" };
            Console.WriteLine($"Summary for {group4Summary.Grp}:");
            Console.WriteLine();
            group4Summary.AddStudent(
                new Student
                {
                    FirstName = "Vukashin",
                    LastName = "Obrdovik",
                    Age = 23
                });
            group4Summary.AddStudent(
              new Student
              {
                  FirstName = "Venko",
                  LastName = "Trajkovski",
                  Age = 24
              });
            group4Summary.AddStudent(
             new Student
             {
                 FirstName = "Nikola",
                 LastName = "Dalcevski",
                 Age = 25
             });
            group4Summary.AddStudent(
             new Student
             {
                 FirstName = "Stojanco",
                 LastName = "Stoilov",
                 Age = 40
             });
            group4Summary.AddStudent(
             new Student
             {
                 FirstName = "Nevena",
                 LastName = "Georgieva",
                 Age = 35
             });
            group4Summary.AddStudent(
             new Student
             {
                 FirstName = "Borce",
                 LastName = "Stoiloski",
                 Age = 36
             });


            group4Summary.findYoungest();
            group4Summary.OldestStudent();
            group4Summary.findShortestName();
            group4Summary.findLongestName();
            group4Summary.findShortestLastName();
            group4Summary.findLongestLastName();
            group4Summary.findAverageYears();
            group4Summary.CountStudents();

            return group4Summary;
        }
    }
}

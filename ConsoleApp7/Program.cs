using ConsoleApp7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArrayMethodTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            string name = "";
            int groupNo = 0;
            double avgPoint = 0;
            string searchName = "";


            Console.Write("No deyerini daxil edin: ");
            Console.WriteLine("---------------------");
            string no = Console.ReadLine();

            byte studentLimit = 0;

            do
            {
                Console.Write("Student limitini daxil edin: ");
                Console.WriteLine("---------------------");

            }
            while (!byte.TryParse(Console.ReadLine(), out studentLimit));

            Group group = new Group(no, studentLimit);

            do
            {

                Console.WriteLine("1 - Telebe elave et");
                Console.WriteLine("2 - Butun telebelere bax");
                Console.WriteLine("3 - Telebeler uzre axtaris et");
                Console.WriteLine("0 - Programi bitir");

                Console.Write("Secim edin: ");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Telebe adini daxil edin: ");
                    name = Console.ReadLine();


                    do
                    {
                        Console.Write("Telebe balini daxil edin: ");
                    }
                    while (!(double.TryParse(Console.ReadLine(), out avgPoint) && (avgPoint >= 0 && avgPoint <= 100)));
                    groupNo++;
                    Student student = new Student(name, groupNo, avgPoint);

                    group.AddStudent(student);

                }
                else if (choice == "2")
                {
                    group.ShowAllStudent();
                }
                else if (choice == "3")
                {
                    Console.Write("Axtarmaq istediyiniz telebenin adini daxil edin: ");
                    searchName = Console.ReadLine();
                    foreach (var item in group.SearchStudent(searchName))
                    {
                        item.ShowInfo();
                    }
                }
            }
            while (choice != "0");


        }
    }
}
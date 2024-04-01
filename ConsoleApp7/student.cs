using ConsoleApp7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Student
    {
        public string FullName;
        public int GroupNo;
        private double _avgPoint;

        public double AvgPoint
        {
            get
            {
                return _avgPoint;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _avgPoint = value;
                }
                else
                {
                    Console.WriteLine("Duzgun bal daxil et");
                }
            }
        }

        public Student(string fullName, int groupNo, double avgPoint)
        {
            FullName = fullName;
            GroupNo = groupNo;
            AvgPoint = avgPoint;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"FullName: {FullName}, AvgPoint: {AvgPoint}, GroupNo: {GroupNo}");
        }
    }
}

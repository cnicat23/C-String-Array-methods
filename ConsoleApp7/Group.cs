using ConsoleApp7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArrayMethodTask
{
    internal class Group
    {
        private string _no;
        private byte _studentLimit;

        public string No
        {
            get
            {
                return _no;
            }
            set
            {
                if (value.Length == 5)
                {
                    bool check = false;
                    bool checktwo= false;
                    for (int i = 0; i < value.Length - 3; i++)
                    {

                        if (char.IsLetter(value[i]))
                        {
                            if (value[i].ToString() == value[i].ToString().ToUpper())
                            {
                                check = true;
                            }
                            else
                            {
                                check = false;
                                break;

                            }
                        }
                        else
                        {
                            check = false;
                            break;
                        }
                    }
                    for (int i = value.Length - 3; i < value.Length; i++)
                    {
                        if (char.IsDigit(value[i]))
                        {
                            checktwo = true;
                        }
                        else
                        {
                            checktwo = false;
                            break;
                        }
                    }

                    if (check && checktwo)
                    {
                        _no = value;
                    }
                    else
                    {
                        Console.WriteLine("duzgun No deyeri daxil et");
                    }
                }
                else
                {
                    Console.WriteLine("No deyerinin uzunlugu 5 olmalidi");
                }


            }
        }

        public byte StudentLimit
        {
            get
            {
                return _studentLimit;
            }
            set
            {
                if (value > 0 && value <= 20)
                {
                    _studentLimit = value;
                }
                else
                {
                    Console.WriteLine("Student limiti duzgun daxil et");
                }
            }
        }
        Student[] Students = new Student[] { };

        public void AddStudent(Student student)
        {
            if (Students.Length < StudentLimit && !String.IsNullOrEmpty(No))
            {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length - 1] = student;
            }
            else
            {
                Console.WriteLine("Duzgun student obyekti daxil et");
            }
        }


        public Student[] SearchStudent(string fullName)
        {
            bool f = true;
            Student[] newStudent = new Student[] { };
            if (Students.Length > 0)
            {
                for (int i = 0; i < Students.Length; i++)
                {
                    if (fullName.ToLower() == Students[i].FullName.ToLower())
                    {
                        f = false;
                        Array.Resize(ref newStudent, newStudent.Length + 1);
                        newStudent[newStudent.Length - 1] = Students[i];
                    }
                }
                if (f)
                {
                    Console.WriteLine($"{fullName} telebesi yoxdu");
                }

            }
            else
            {
                Console.WriteLine("Telebe yoxdu");
            }

            return newStudent;

        }

        public void ShowAllStudent()
        {
            if (Students.Length > 0)
            {
                for (int i = 0; i < Students.Length; i++)
                {
                    Console.WriteLine($"FullName: {Students[i].FullName}, AvgPoint: {Students[i].AvgPoint}, GroupNo: {Students[i].GroupNo}");
                }
            }
            else
            {
                Console.WriteLine("Telebe yoxdu");
            }
        }

        public Group(string no, byte studentLimit)
        {
            No = no;
            StudentLimit = studentLimit;
        }


    }
}
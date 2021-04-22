
using System;
using System.Collections.Generic;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)

        {
            List<Student> lisStudents = new List<Student>();
            for(int i =0;i<=lisStudents.Count;i++)
            {
                Console.WriteLine("----------*****************************************----------");
                Console.WriteLine('\n' + "Please Enter Student's Name and Grade: " + '\n' + "*****************************************");

                Console.Write("Name: ");
                lisStudents.Add(new Student());
                string studentName = Console.ReadLine();
                lisStudents[i].Name = studentName;


                Console.Write("Grade: ");
                var studentGrade = Console.ReadLine();
                lisStudents[i].Grade = double.Parse(studentGrade);


                lisStudents[i].Result = calculateResult(lisStudents[i].Grade);

                Console.Write("-------------------------------------" + '\n' + "Do you wish to add another student? (y/n) :  ");
                var userAnswer = Console.ReadLine();

                if (userAnswer == "y")
                {
                    continue;
                }

                else
                {
                    break;
                }


            }

            print(lisStudents);


            Console.WriteLine("\n\nEnter the grade to search:  ");
            string user_gradeToSearch = Console.ReadLine();
            double gradeToSearch = double.Parse(user_gradeToSearch);


            int count = 0;

            for (int i = 0; i < lisStudents.Count; i++)
            {
                if (gradeToSearch == lisStudents[i].Grade)
                {
                    count += 1;
                } 
            }

            Console.WriteLine("\n\nNumber of Students with Grade {0} is {1}:  ", gradeToSearch, count);





        }

        static string calculateResult ( double grade)
        {
            string result;

            if (grade < 60)
            {
                result = "FAILED";
            }

            else
            {
                result = "PASSED";
            }


            return result;

        }

        static void print(List<Student> stu)
        {
            Console.WriteLine("\n\n" + " ---------***Students record***---------");
            Console.WriteLine("\n" + "-----------------------------------------------");
            Console.WriteLine("Name     ", "Grade     ", "Result");
            Console.WriteLine("-----------------------------------------------");


            foreach (Student ss in stu)
            {

                Console.WriteLine(ss.getData());
            }
        }

        //public void SearchGrades(double grade)
        //{
        //    Console.WriteLine("\n\n Enter the grade to search:  ");

        //    string grade_search = Console.ReadLine();

        //    foreach (var item in lis)
        //    {

        //    }

        //}


    }
}

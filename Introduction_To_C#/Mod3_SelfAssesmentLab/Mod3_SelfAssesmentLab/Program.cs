using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_SelfAssesmentLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, birthday, course, program, degree;

            GetStudentInformation(out firstName, out lastName, out birthday);
            PrintStudentDetails(firstName, lastName, birthday);
            GetTeacherInformation(out course, out program, out degree);
            PrintTeacherDetails(course, program, degree);
        }

        static void GetStudentInformation(out string firstName, out string lastName, out string birthday)
        {
            Console.WriteLine("Enter the student's first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name: ");
            lastName = Console.ReadLine();
            // Code to finish getting the rest of the student data
            Console.WriteLine("Enter the studen'ts birthday (yy/mm/dd): ");
            birthday = Console.ReadLine();
            try
            {

                ValidateBirthday(birthday);
            }
            catch (NotImplementedException notImp)
            {
                Console.WriteLine(notImp.Message);
                Console.WriteLine("Method \"ValidateBirthday\" has nothing to implement!");
            }
        }

        static void PrintStudentDetails(string firstName, string lastName, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", firstName, lastName, birthday);
        }

        static void GetTeacherInformation(out string course, out string program, out string degree)
        {
            Console.WriteLine("Enter the teacher's course: ");
            course = Console.ReadLine();
            Console.WriteLine("Enter the teacher's program: ");
            program = Console.ReadLine();
            Console.WriteLine("Enter the teacher's degree: ");
            degree = Console.ReadLine();
        }

        static void PrintTeacherDetails(string course, string program, string degree)
        {
            Console.WriteLine("{0} has program \"{1}\" and teacher's degree is {2}", course, program, degree);
        }

        static void ValidateBirthday(string birthday)
        {
            throw new NotImplementedException();
        }
    }

}

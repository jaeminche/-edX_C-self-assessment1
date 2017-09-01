using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            //student's info
            string SFirstName = "";
            string SLastName = "";
            DateTime SBirthdate;
            string SAddressLine1 = "";
            string SAddressLine2 = "";
            string SCity = "";
            string SState_province = "";
            int SZip_postal = 0;
            string SCountry = "";
            //teacher's info
            string TFirstName = "";
            string TLastName = "";
            DateTime TBirthdate;
            string TAddressLine1 = "";
            string TAddressLine2 = "";
            string TCity = "";
            string TState_province = "";
            int TZip_postal = 0;
            string TCountry = "";
            //UProgram info
            string programName = "";
            string departmentHead = "";
            string degrees = "";
            //degree info
            string degreeName = "";
            bool creditsRequired;
            //course info
            string courseName = "";
            short credits = 0;
            short duration_in_wks = 0;
            string teacher = "";

            //assign some values
            //assign values for student
            SFirstName = "Jae";
            SLastName = "Choi";
            SBirthdate = new DateTime(1983, 2, 7);
            SAddressLine1 = "15, Talsil-ro";
            SAddressLine2 = "Giheung-gu";
            SCity = "Yongin-si";
            SState_province = "Gyeonggi-do";
            SZip_postal = 17042;
            SCountry = "South Korea";
            //assign values for teacher
            TFirstName = "Dan";
            TLastName = "Lee";
            TBirthdate = new DateTime(1987, 1, 2);
            TAddressLine1 = "8080, Google";
            TAddressLine2 = "Seocho";
            TCity = "Seoul";
            TState_province = "";
            TZip_postal = 8080;
            TCountry = "South Korea";
            //UProgram info
            programName = "Front-end Web Development Nanodegree Program";
            departmentHead = "Udacity";
            degrees = "Nanodegree";
            //degree info
            degreeName = "Nanodegree";
            creditsRequired = false;
            //course info
            courseName = "Front-end Web Development Nanodegree Course";
            credits = 1;
            duration_in_wks = 30;
            teacher = "Dan Lee";

            //output to the console window
            Console.WriteLine("Student's first name : {0}", SFirstName);
            Console.WriteLine("Student's last name : {0}", SLastName);
            Console.WriteLine($"\n born on {SBirthdate}");
            Console.WriteLine($"lives on {SAddressLine1} {SAddressLine2} {SCity} {SCountry} {SZip_postal}");
            Console.WriteLine("\n {0} {1} is taking a {2} {3} course titled {4}. It will take about {5} weeks to complete.", SFirstName, SLastName, departmentHead, degreeName, courseName, duration_in_wks);

            //CHALLENGE: Using Console.ReadLine(), prompt a user for information about a student.
            Console.WriteLine("\n Please enter a new name you want the student's first name to be changed to: ");
            SFirstName = Console.ReadLine();
            Console.WriteLine("\n Student's first name has been changed to {0}.", SFirstName);
            Console.WriteLine("\n Please enter a new name you want the student's last name to be changed to: ");
            SLastName = Console.ReadLine();
            Console.WriteLine("\n Student's name has been changed to {0} {1}.", SFirstName, SLastName);
            Console.WriteLine("So... {0} {1}, how old are you?", SFirstName, SLastName);
            int UserAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("I see, {0} {1} is {2} old!", SFirstName, SLastName, UserAge);

            long value = Factorial(10);
            Console.WriteLine(value);
        }

        static long Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }
    }
}

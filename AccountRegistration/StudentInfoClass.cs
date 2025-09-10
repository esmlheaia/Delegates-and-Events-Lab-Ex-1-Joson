using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountRegistration
{
    public delegate int DelegateNumber(int number);
    public delegate string DelegateText(string txt);
    internal class StudentInfoClass
    {
        public static string SetProgram, SetGender, SetBirthday, SetFullName, SetAddress = " ";
        public static int SetAge, SetContactNo, SetStudentNo = 0;

        public static string GetFullName(string FullName)
        {
            return FullName;
        }
        public static string GetAddress(string Address) 
        {
            return Address; 
        }
        public static string GetProgram(string Program)
        {
            return Program;
        }
        public static string GetGender(string Gender)
        {
            return Gender;
        }
        public static string GetBirthday(string Birthday)
        {
            return Birthday;
        }
        public static int GetAge(int Age) 
        {
            return Age;
        }
        public static int GetContactNo(int ContactNo)
        {
            return ContactNo;
        }
        public static int GetStudentNo(int StudentNo)
        {
            return StudentNo;
        }

        }

    }


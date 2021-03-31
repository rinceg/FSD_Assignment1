using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSD_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            TeachersDataUpdation teachersData = new TeachersDataUpdation();
            int flag = 0;
            TeacherDetail teacherDetail = new TeacherDetail();
//            int ID; string Name; string className; char section;
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Rainbow School Teacher's Data Management System.");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Select Option for Confirm Store or Update:");
            Console.WriteLine("1. storing the teacher's data");
            Console.WriteLine("2. updating the teacher's data");
            Console.WriteLine("3. retriving the teacher's data");
            Console.WriteLine("Please type a number (1 or 2 or 3) to perform the action");
            flag = Convert.ToInt32(Console.ReadLine());
            if (flag == 1)
            {
                Console.WriteLine("Please Enter the Teacher Data");
                Console.WriteLine(" ID:");
                teacherDetail.tId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Name:");
                teacherDetail.tName = Console.ReadLine();
                Console.WriteLine(" Classname:");
                teacherDetail.className = Console.ReadLine();
                Console.WriteLine(" section:");
                teacherDetail.section = Console.ReadLine();              

                string result = teachersData.Store(teacherDetail);
            }
            else if (flag == 2)
            {
                Console.WriteLine("Please Enter the Teacher's data to update");
                Console.WriteLine(" ID:");
                teacherDetail.tId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Name:");
                teacherDetail.tName = Console.ReadLine();
                Console.WriteLine(" Classname:");
                teacherDetail.className = Console.ReadLine();
                Console.WriteLine(" section:");
                teacherDetail.section = Console.ReadLine();
                string result = teachersData.update(teacherDetail);
            }
            else if (flag == 3)
            {
              
                Data data = teachersData.read();
                Console.WriteLine($"ID is :{data.id}");
                Console.WriteLine($"Name is :{data.Name}");
                Console.WriteLine($"Class is :{data.Class}");
                Console.WriteLine($"Section is :{data.Section}");
            }
            else
            {
                Console.WriteLine("invalid option");
            }

            Console.ReadKey();

           
        }
    }
}

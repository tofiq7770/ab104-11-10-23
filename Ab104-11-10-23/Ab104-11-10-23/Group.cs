using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab104_11_10_23
{
    internal class Group 
    {
        public string GroupName { get; }
        private Student[] Students;
        private int studentCount;

        public Group(string groupName, int maxStuCount)
        {
            GroupName = groupName;
            Students = new Student[maxStuCount];
            studentCount = 0;
        }

        public void Add(Student student)
        {
            if (studentCount < Students.Length)
            {
                Students[studentCount] = student;
                studentCount++;
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        public void GetAll()
        {
            Console.WriteLine($"Students in {GroupName}: ");
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{Students[i].Name} {Students[i].Surname} ");
            }
        }

        public void GetOnlineStudents()
        {
            Console.WriteLine($"Online Students in {GroupName}: ");
            for (int i = 0; i < studentCount; i++)
            {
                if (Students[i].IsOnline)
                {
                    Console.WriteLine($"{Students[i].Name} {Students[i].Surname} ");
                }
            }
        }

        public void GetOfflineStudents()
        {
            Console.WriteLine($"Offline Students in {GroupName}: ");
            for (int i = 0; i < studentCount; i++)
            {
                if (!Students[i].IsOnline)
                {
                    Console.WriteLine($"{Students[i].Name} {Students[i].Surname} ");
                }
            }
        }
    }

}

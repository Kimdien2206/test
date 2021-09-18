using System;
using System.Collections.Generic;
using System.Text;

namespace BT2
{
    class School
    {
        public List<StudyClass> l;
        public string SchoolName;
        public void CreateSchool()
        {
            l = new List<StudyClass>();
            Console.WriteLine("Nhap ten truong: ");
            SchoolName = Console.ReadLine();
        }
        public void SchoolInput()
        {
            Console.WriteLine("Nhap sl lop: ");
            int n = Convert.ToInt32(Console.ReadLine());
            StudyClass Temp;
            for(int i=0; i<n; i++)
            {
                Temp = new StudyClass();
                Temp.CreateClass();
                l.Add(Temp);
            }
        }
        public void SchoolOutput()
        {
            Console.WriteLine("Ten truong: " + SchoolName);
            for(int i=0; i<l.Count;i++)
            {
                l[i].ClassOutput();
            }
        }
    }
}

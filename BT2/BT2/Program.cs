using System;

namespace BT2
{
    class Program
    {
        static void Main(string[] args)
        {
            StudyClass a = new StudyClass();
            Console.WriteLine("Nhap so luong SV: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                a.ClassInput();
            }
            a.ClassOutput();
            Console.WriteLine("Max:");
            Console.WriteLine();
            Student Temp = a.AverageMax();
            Temp.StudentOutput();
            Console.WriteLine();
            Console.WriteLine("Sort:");
            a.Sort();
            a.ClassOutput();
        }
    }
}
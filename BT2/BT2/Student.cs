using System;
using System.Collections.Generic;
using System.Text;

namespace BT2
{
    class Student
    {
        public string Name;
        public string ID;
        public float MathPoint;
        public float LitPoint;
        public float EngPoint;
        public float Average { get; set; }
        public void StudentInput()
        {
            Console.WriteLine("Nhap Ten: ");
            Name = Console.ReadLine();
            Console.WriteLine("Nhap MSSV: ");
            ID = Console.ReadLine();
            Console.WriteLine("Nhap diem Toan: ");
            MathPoint = (float)Convert.ToDouble(Console.ReadLine());
            while (MathPoint > 10 || MathPoint < 0)
            {
                Console.WriteLine("Nhap lai: ");
                MathPoint = (float)Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Nhap diem Van: ");
            LitPoint = (float)Convert.ToDouble(Console.ReadLine());
            while (LitPoint > 10 || LitPoint < 0)
            {
                Console.WriteLine("Nhap lai: ");
                LitPoint = (float)Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Nhap diem Anh: ");
            EngPoint = (float)Convert.ToDouble(Console.ReadLine());
            while (EngPoint > 10 || EngPoint < 0)
            {
                Console.WriteLine("Nhap lai: ");
                EngPoint = (float)Convert.ToDouble(Console.ReadLine());
            }
            Average = AveragePoint();
        }
        public Student()
        {

        }
        public Student(Student a)
        {
            this.Average = a.Average;
            this.ID = a.ID;
            this.LitPoint = a.LitPoint;
            this.MathPoint = a.MathPoint;
            this.Name = a.Name;
            this.EngPoint = a.EngPoint;
        }
        public void StudentOutput()
        {
            Console.WriteLine("Ten: " + Name);
            Console.WriteLine("MSSV: " + ID);
            Console.WriteLine("Diem Toan: {0}       Diem Van: {1}       Diem Anh: {2}", MathPoint, LitPoint, EngPoint);
        }
        public virtual float AveragePoint()
        {
            return (EngPoint + LitPoint + MathPoint) / 3;
        }
    }
}

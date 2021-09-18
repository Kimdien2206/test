using System;
using System.Collections.Generic;
using System.Text;

namespace BT2
{
    class StudyClass
    {
        public string ClassName;
        public List <Student> a;
        public void CreateClass()
        {
            a = new List<Student>();
            Console.WriteLine("Nhap ten lop: ");
            ClassName = Console.ReadLine();
        }
        public void ClassInput()
        {
            int n = 0;
            Student Temp;
            Console.WriteLine("Nhap mon chuyen: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n > 3 || n < 0)
            {
                Console.WriteLine("Nhap lai: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            switch (n)
            {
                case 0:
                    Temp = new Student();
                    Temp.StudentInput();
                    a.Add(Temp);
                    break;
                case 1:
                    Temp = new MathSpecial();
                    Temp.StudentInput();
                    a.Add(Temp);
                    break;
                case 2:
                    Temp = new LitSpecial();
                    Temp.StudentInput();
                    a.Add(Temp);
                    break;
                case 3:
                    Temp = new EngSpecial();
                    Temp.StudentInput();
                    a.Add(Temp);
                    break;
            }
        }
        public void Sort()
        {
            float Max = 0;
            int MaxIndex = 0;
            for (int i = 0; i < a.Count - 1; i++)
            {
                Max = a[i].Average;
                MaxIndex = i;
                for (int j = i + 1; j < a.Count; j++)
                {
                    if (Max <= a[j].Average)
                    {
                        Max = a[j].Average;
                        MaxIndex = j;
                    }
                }
                Student Temp1 = a[i];
                a[i] = a[MaxIndex];
                a[MaxIndex] = Temp1;
            }
        }
        public void ClassOutput()
        {
            for (int i = 0; i < a.Count; i++)
            {
                a[i].StudentOutput();
            }
        }
        public Student AverageMax()
        {
            float Max = 0;
            Student Temp = a[0];
            for (int i = 0; i < a.Count; i++)
            {
                if (Max < a[i].AveragePoint())
                {
                    Max = a[i].AveragePoint();
                    Temp = a[i];
                }
            }
            return Temp;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsLab2
{
    class Person //человек
    {
        public string fullName;     //поле ФИО
        public string date;         //дата рождения
        public string institute;
        public string group;
        public int course;
        public double GPA;          //средний балл

        public void input()
        {
            Console.WriteLine("Enter full name:");
            fullName = Console.ReadLine();
            Console.WriteLine("The date of birth:");
            date = Console.ReadLine();
            Console.WriteLine("Enter your institute:");
            institute = Console.ReadLine();
            Console.WriteLine("Enter your group:");
            group = Console.ReadLine();
            Console.WriteLine("Enter the number of your course:");
            course = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your GPA");
            GPA = double.Parse(Console.ReadLine());
        }

        public void output()
        {
            Console.WriteLine("Full name:");
            Console.WriteLine(fullName);
            Console.WriteLine("The date of birth:");
            Console.WriteLine(date);
            Console.WriteLine("Institute:");
            Console.WriteLine(institute);
            Console.WriteLine("Group:");
            Console.WriteLine(group);
            Console.WriteLine("The number of course:");
            Console.WriteLine(course);
            Console.WriteLine("GPA");
            Console.WriteLine(GPA);
        }
    }

    class Program
    {
      static void Main(string[] args)
        {
            int k = 0;
            Person[] person = new Person[100];
            while (true)
            {
                Console.WriteLine("1 - create, 2 - show information");
                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        {
                            k=k+1;
                            Console.Write("Person's ID - ");
                            Console.WriteLine(k);
                            person[k] = new Person();
                            person[k].input();
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Enter person's ID:");
                            int n = int.Parse(Console.ReadLine());
                            Console.Write("Person - ");
                            Console.WriteLine(n);
                            person[k].output();
                        }
                        break;
                    //case 3:; break;
                }
            }
        }
    }
}

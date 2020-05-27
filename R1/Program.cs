using System;

namespace R1
{
    class Employee
    {
        public string name {get; set;}
        public string surname { get; set; }
        public int payment { get; set; }
        public int countday { get; set; }


        public void Method()
        {
            Console.WriteLine($"Зарплата: {payment * countday}");
        }
        public Employee(string N, string S, int P, int C)
        {
            name = N;
            surname = S;
            payment = P;
            countday = C;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите имя: ");
            string Name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string Surname = Console.ReadLine();
            Console.Write("Введите ставку за день роботи: ");
            int Payment = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количевство отработаных дней: ");
            int Countday = Convert.ToInt32(Console.ReadLine());
            Employee Emp = new Employee(Name, Surname, Payment, Countday);
            Emp.Method();
            


        }
    }
}


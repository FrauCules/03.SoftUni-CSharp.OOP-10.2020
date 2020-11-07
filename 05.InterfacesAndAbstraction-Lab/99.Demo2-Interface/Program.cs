using System;

namespace _99.Demo2_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            company.Workers.Add(new Worker());
            company.Workers.Add(new Intern());
            company.Workers.Add(new FactoryMan());
            company.Workers.Add(new Boss());

            while (true)
            {
                var input = Console.ReadLine();
                company.WorkDay();

                if(input== "Salary")
                {
                    company.SalaryDay();
                }
            }

        }
    }
}

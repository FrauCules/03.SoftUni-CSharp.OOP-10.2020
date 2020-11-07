using System;
using System.Collections.Generic;
using System.Text;

namespace _99.Demo2_Interface
{
    class Company
    {
        public Company()
        {
            this.Workers = new List<IWorker>();
        }

        public List<IWorker> Workers { get; set; }
        public void WorkDay()
        {
            Workers.ForEach((worker) =>
            {
                if(worker is Worker) // проверява типа на един клас - дали обекта е от този тип
                {
                    Worker workerW = (Worker)worker; // кастваме го към Worker
                    workerW.EatPizza(); // така имаме достъп до всичко, до което има достъп обект от клас Worker
                                        // НЕ Е ПРЕПОРЪЧИТЕЛНО да се прави, защото се губи абстракцията
                                        // може да се прави в спец.случаи, когато го изискват и да се знае затази възможност
                    Console.WriteLine("Worker");
                    
                }
                worker.Work();
            });
        }

        public void SalaryDay()
        {
            Workers.ForEach((worker) =>
            {
                worker.GetSalary();
            });
        }
    }
}

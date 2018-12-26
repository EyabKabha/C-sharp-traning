using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    class Worker : Person
    {

        private int salary;

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public Worker(int salary,string name, int age, string id, bool gender) : base(name, age, id, gender)
        {
            Salary = salary;
         
        }
        public string GetInfoWorker()
        {
            return base.GetInfo()+$"Salary {Salary}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Student : Person
    {

        private string placeofstudy;

        public string Placeofstudy
        {
            get { return placeofstudy; }
            set { placeofstudy = value; }
        }
        private string profession;

        public string Profession
        {
            get { return profession; }
            set { profession = value; }
        }
        public Student(string placeofstudy,string profession,string name, int age, string id, bool gender) : base(name, age, id, gender)
        {
            Placeofstudy = placeofstudy;
            Profession = profession;
           
        }
        public string GetInfoStudent()
        {
            return base.GetInfo() + $"placeofstudy {Placeofstudy} Profession {Profession}";
        }
    }
}

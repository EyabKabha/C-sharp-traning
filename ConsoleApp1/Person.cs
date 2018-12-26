using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set {
                if (value >= 0 && value <= 120)
                  age = value;
            }
        }
        private string id;

        public string Id
        {
            get { return id; }
            set {
                int num;
                if (value.Length==9 && int.TryParse(value,out num))
                 id = value; }
        }

        private bool gender;

        public bool Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public Person(string name,int age,string id,bool gender)
        {
            Name = name;
            Age = age;
            Id = id;
            Gender = gender;

        }
        public string GetInfo()
        {
            return $"Name {Name}\n Age {Age}\n Id {Id}\n Gender{Gender}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AppTask
{
    class Person
    {

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Date birthDate;

        public Date BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }
        private Person dad;

        public Person Dad
        {
            get { return dad; }
            set { dad = value; }
        }
        private Person mom;

        public Person Mom
        {
            get { return mom; }
            set { mom = value; }
        }
        public Person(string name, Date birthDate,Person mom,Person dad)
        {
            Name = name;
            BirthDate = birthDate;
            Dad = dad;
            Mom = mom;
        }
        public override string ToString()
        {
            string res = $"Name:{Name} BirthDate :{birthDate.ToString()}";
            if (Mom != null && Dad != null) 
            {
                res += $"\n{Mom.ToString()}\n{Dad.ToString()}";
            }
            return res;
        }
    }
}

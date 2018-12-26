using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Teacher : Person
    {

        private string teachingprofession;

        public string Teachingprofession
        {
            get { return teachingprofession; }
            set { teachingprofession = value; }
        }
        private string yearsofteaching;

        public string Yearsofteaching
        {
            get { return yearsofteaching; }
            set { yearsofteaching = value; }
        }

        public Teacher(string teachingprofession, string yearsofteaching, string name, int age, string id, bool gender) : base(name, age, id, gender)
        {
            Teachingprofession = teachingprofession;
            Yearsofteaching = yearsofteaching;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    enum Gender { male, female}
    class Person
    {
        static string nameCorrection(string s)
        {
            return s.Substring(0, 1).ToUpper() + s.Substring(1).ToLower();
        }//--
        Random rand = new Random();
        private string name;
        public string FamilyName //HU way
        {
            get { return nameCorrection(name.Substring(0, name.IndexOf(" ")));  }
            // set { name = value; }
        }
        public string GivenName //HU way
        {
            get { return nameCorrection(name.Substring(name.IndexOf(" ")).Trim()); }
            // set { name = value; }
        }
        private int birthYear;
        public int BirthYear
        {
            get { return birthYear; }
            //set { birthYear = value; }
        }
        Gender g;
        public Gender G
        {
            get { return g; }
        }
        public Person(string name, Gender g)
        {
            this.name = name.Trim();
            this.g = g;
            birthYear = rand.Next(1950, 2018);
        }
        public string print()
        {
            return "\n Given name: *" + GivenName + "* Family name: *" + FamilyName + "* Birth year: *" + BirthYear + "* Gender: *" + g + "*";
        }
    }
}

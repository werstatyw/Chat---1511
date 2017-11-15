using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberofPersons = 3;
            int ageDiff = 5;
            Console.WriteLine("\nTask 1: generate data");
            Person[] p = new Person[numberofPersons];
            for (int i = 0; i < p.Length; i++)
            {
                Console.Write("Name of person " + i + " : ");
                string s = Console.ReadLine();
                Console.Write("Gender of person " + i + " (m/f): ");
                string s1 = Console.ReadLine().ToLower();
                if (s1[0] == 'f') { p[i] = new Person(s, Gender.female);}
                else { p[i] = new Person(s, Gender.male);}
            }//end for i
            for (int i = 0; i < p.Length; i++)
            {
                Console.WriteLine(p[i].print());
            }


            Console.WriteLine("The end");
            Console.ReadKey();
        }
    }
}

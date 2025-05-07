using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProject
{
    internal class Person
    {
        private string name;
        private int age;
        private float income;
        
        //constructor
        public Person(string name, int age, float income) //arguments 
        {
            this.name = name; //this.name refers to the class variable
            this.age = age;
            this.income = income;
        }

        public Person () { }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public float Income
        {
            get
            {
                return income;
            }
            set
            {
                income = value;
            }
        }
    }
}

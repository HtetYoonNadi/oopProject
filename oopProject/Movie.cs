using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProject
{
    internal class Movie
    {
        string title;
        int year;
        int runtime;

        //constructor
        public Movie(string title, int year, int runtime) //with arguments constructor
        {
            this.title = title;
            this.year = year;
            this.runtime = runtime;
        }

        public Movie() //without arguments constructor
        {
            this.title = "";
            this.year = 0;
            this.runtime = 0;
        } 

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public int Runtime
        {
            get { return runtime; }
            set { runtime = value; }
        }

        public Boolean FitRunTime (int min, int max)
        {
            if (runtime > min && runtime < max)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

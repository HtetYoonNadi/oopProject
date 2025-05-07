using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace oopProject
{
    internal class Book
    {
        private string title;
        private string author;
        private int year;
        private string isbn;
        private string genre;

        public string Title
        {
        get {  return title; }
        set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }


    }
}

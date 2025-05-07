using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace oopProject
{

    public partial class BookForm : Form
    {
        List<Book> books = new List<Book>();

        public BookForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Title = txtTitle.Text;
            book.Year = int.Parse(txtYear.Text);
            book.Author = txtAuthor.Text;

            books.Add(book);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lstBook.Items.Clear(); 

            foreach (Book book in books)
            {
                if (book.Year < 2025)
                {
                    lstBook.Items.Add("Title: " + book.Title);
                    lstBook.Items.Add("Year: " + book.Year.ToString());
                    lstBook.Items.Add("Author: " + book.Author);
                }
            }

        }

        private void lstBook_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class MovieForm : Form
    {
        List<Movie> movies = new List<Movie>();

        public MovieForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            movie.Title = txtTitle.Text;
            movie.Year = int.Parse(txtYear.Text);
            movie.Runtime = int.Parse(txtRuntime.Text);

            movies.Add(movie);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < movies.Count; i++)
            {
                //lstMovie.Items.Add(movies[i]);
                Movie movie = new Movie();
                movie = movies[i];
                bool check = movie.FitRunTime(60, 120);
                if (check == true)
                {
                    lstMovie.Items.Add(movie.Title);
                    lstMovie.Items.Add(movie.Year);
                    lstMovie.Items.Add(movie.Runtime);
                }
            }
        }

        private void lstMovie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oopProject
{
    public partial class PersonForm : Form
    {
        //global variable

        Person person1, person2, person3;
        int count;


        public PersonForm()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIncome_TextChanged(object sender, EventArgs e)
        {

        }

        private void PersonForm_Load(object sender, EventArgs e)
        {
            count = 0;
            
            person2 = new Person();
            person3 = new Person();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            rtbShowAll.Text += person1.Name + "\n";
            rtbShowAll.Text += person1.Age + "\n";
            rtbShowAll.Text += person1.Income + "\n";

            rtbShowAll.Text += "...................";

            rtbShowAll.Text += person2.Name + "\n";
            rtbShowAll.Text += person2.Age + "\n";
            rtbShowAll.Text += person2.Income + "\n";

            rtbShowAll.Text += "...................";

            rtbShowAll.Text += person3.Name +"\n";
            rtbShowAll.Text += person3.Age + "\n";
            rtbShowAll.Text += person3.Income + "\n";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (count == 3)
            {
                MessageBox.Show("Sorry, only three person allowed!");
                return;
            }

            else
            {
                if (count == 0)
                {
                    person1 = new Person("Adrew", 25, 4000);
                    person1.Name = txtName.Text;
                    person1.Age = int.Parse(txtAge.Text);
                    person1.Income = float.Parse(txtIncome.Text);
                }

                else if (count == 1)
                {
                    person2 = new Person();
                    person2.Name = txtName.Text;
                    person2.Age = int.Parse(txtAge.Text);
                    person2.Income = float.Parse(txtIncome.Text);
                }

                else if (count == 2)
                {
                    person3 = new Person();
                    person3.Name = txtName.Text;
                    person3.Age = int.Parse(txtAge.Text);
                    person3.Income = float.Parse(txtIncome.Text);
                }
            }

            count++;
            txtName.Text = "";
            txtAge.Text = "";
            txtIncome.Text = "";
        }
    }
}

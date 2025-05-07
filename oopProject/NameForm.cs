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
    public partial class NameForm : Form
    {
        public NameForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            int num3 = int.Parse(txtNum3.Text);
            int result = 0;

            ThreeNumberClass tnc = new ThreeNumberClass();

            if (rdoLargest.Checked == true)
            {
                result = tnc.FindLargest(num1, num2, num3);
            }
            else if (rdoSmallest.Checked == true) { 
                result = tnc.FindSmallest(num1, num2, num3);
            }
            else if (rdoTotal.Checked == true)
            {
                result = tnc.FindTotal(num1, num2, num3);

            }

            lblResult.Text = result.ToString();
        }
    }
}

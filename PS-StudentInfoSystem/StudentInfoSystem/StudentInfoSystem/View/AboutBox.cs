using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;


namespace StudentInfoSystem.View
{
    public partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            company.Text = "Company name:  " + Application.CompanyName.Trim();
            product.Text = "Product name:  " + Application.ProductName.Trim();
        }
        private void ok_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}



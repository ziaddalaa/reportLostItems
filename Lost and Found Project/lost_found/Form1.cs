using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace lost_found
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Regex rg = new Regex("^[0-9]{11}");
            bool isValid = rg.IsMatch(phone_text.Text);
            if (!isValid)
            {
                MessageBox.Show("Please Enter Valid Mobile Number");
            }
            bool isEmpty = true;
            if (pass_text.Text == null)
            {
                isEmpty = false;
                MessageBox.Show("Enter Your Password");
            }
            if (isValid && isEmpty)
            {
                this.Hide();
                HomePage openForm = new HomePage();
                openForm.Show();
            }
            else 
            {
                MessageBox.Show("Wrong Password");
            }


            
            
            
        }
    }
}

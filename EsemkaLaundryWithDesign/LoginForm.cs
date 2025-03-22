using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemkaLaundryWithDesign
{
    public partial class Form1 : Form
    {
        public static Employee employee;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbEmail.Text = "glangthorne2@ask.com";
            tbPassword.Text = "19tR2Er31Xla";
            Support.enableField(this);
        }

        private void btnLogin_Click_2(object sender, EventArgs e)
        {
            if (tbEmail.Text == "" || tbPassword.Text == "")
            {
                Support.msw("All fields must be filled");
                return;
            }

            var db = new DataBaseDataContext();
            var query = db.Employees.FirstOrDefault(x => x.Email == tbEmail.Text && x.Password == tbPassword.Text);

            if (query != null)
            {
                employee = query;   
                new MainForm().Show();
                Hide();
            }
            else
            {
                Support.msw("Please Try Again, Your Data is not Valid!");
            }
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}

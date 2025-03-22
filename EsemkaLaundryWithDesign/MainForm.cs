using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemkaLaundryWithDesign
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            panelContainer.Visible = false;
            panelManage.Visible = false;
            panelTransaction.Visible = false;
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            if (panelManage.Visible == true)
            {
                panelManage.Visible = false;
            }
            else
            {
                panelManage.Visible = true;
            }
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            if (panelTransaction.Visible == true)
            {
                panelTransaction.Visible = false;
            }
            else
            {
                panelTransaction.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (panelContainer.Visible == true)
            {
                panelContainer.Visible = false;
            }
            else
            {
                panelContainer.Visible = true;
            }
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var f = new FormEmployee();

            f.TopLevel = false;
            panelMain.Controls.Add(f);
            f.Show();

            btnEmployee.BackColor = Color.FromArgb(199, 22, 28);

            btnService.BackColor = Color.FromArgb(177, 1, 0);
            btnPackage.BackColor = Color.FromArgb(177, 1, 0);
            btnDeposit.BackColor = Color.FromArgb(177, 1, 0);
            btnPrepaid.BackColor = Color.FromArgb(177, 1, 0);
            btnViewTransaction.BackColor = Color.FromArgb(177, 1, 0);

        }

        private void btnService_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var f = new FormService();
            f.TopLevel = false;

            panelMain.Controls.Add(f);
            f.Show();

            btnService.BackColor = Color.FromArgb(199, 22, 28);

            btnEmployee.BackColor = Color.FromArgb(177, 1, 0);
            btnPackage.BackColor = Color.FromArgb(177, 1, 0);
            btnDeposit.BackColor = Color.FromArgb(177, 1, 0);
            btnPrepaid.BackColor = Color.FromArgb(177, 1, 0);
            btnViewTransaction.BackColor = Color.FromArgb(177, 1, 0);
        }

        private void btnPackage_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var f = new FormPackage();
            f.TopLevel = false;

            panelMain.Controls.Add(f);
            f.Show();

            btnPackage.BackColor = Color.FromArgb(199, 22, 28);

            btnService.BackColor = Color.FromArgb(177, 1, 0);
            btnEmployee.BackColor = Color.FromArgb(177, 1, 0);
            btnDeposit.BackColor = Color.FromArgb(177, 1, 0);
            btnPrepaid.BackColor = Color.FromArgb(177, 1, 0);
            btnViewTransaction.BackColor = Color.FromArgb(177, 1, 0);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var f = new FormTransactionDeposit();
            f.TopLevel = false;

            panelMain.Controls.Add(f);
            f.Show();

            btnDeposit.BackColor = Color.FromArgb(199, 22, 28);

            btnService.BackColor = Color.FromArgb(177, 1, 0);
            btnPackage.BackColor = Color.FromArgb(177, 1, 0);
            btnEmployee.BackColor = Color.FromArgb(177, 1, 0);
            btnPrepaid.BackColor = Color.FromArgb(177, 1, 0);
            btnViewTransaction.BackColor = Color.FromArgb(177, 1, 0);
        }

        private void btnPrepaid_Click(object sender, EventArgs e)
        {
            btnPrepaid.BackColor = Color.FromArgb(199, 22, 28);

            btnService.BackColor = Color.FromArgb(177, 1, 0);
            btnPackage.BackColor = Color.FromArgb(177, 1, 0);
            btnDeposit.BackColor = Color.FromArgb(177, 1, 0);
            btnEmployee.BackColor = Color.FromArgb(177, 1, 0);
            btnViewTransaction.BackColor = Color.FromArgb(177, 1, 0);
        }

        private void btnViewTransaction_Click(object sender, EventArgs e)
        {
            btnViewTransaction.BackColor = Color.FromArgb(199, 22, 28);

            btnService.BackColor = Color.FromArgb(177, 1, 0);
            btnPackage.BackColor = Color.FromArgb(177, 1, 0);
            btnDeposit.BackColor = Color.FromArgb(177, 1, 0);
            btnPrepaid.BackColor = Color.FromArgb(177, 1, 0);
            btnEmployee.BackColor = Color.FromArgb(177, 1, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Hide();
        }
    }
}

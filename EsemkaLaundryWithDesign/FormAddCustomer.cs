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
    public partial class FormAddCustomer : Form
    {
        public FormAddCustomer()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var db = new DataBaseDataContext();

            if (tbName.Text == "" || tbPhoneNumber.Text == "" || tbAddress.Text == "")
            {
                Support.msw("All fields must be filled");
                return;
            }

            var queryCheck = db.Customers.FirstOrDefault(x => x.PhoneNumber == tbPhoneNumber.Text);

            if (queryCheck != null)
            {
                Support.msw("Field phone number must be unniqe");
                return;
            }

            if (tbPhoneNumber.Text.Substring(0, 1) != "+" || !tbPhoneNumber.Text.Replace("+", "").All(x => char.IsDigit(x)))
            {
                Support.msw("Field Phone number must be start with " + " and another with digit");
                return;    
            }

            var query = new Customer();
            query.Name = tbName.Text;
            query.PhoneNumber = tbPhoneNumber.Text; 
            query.Address = tbAddress.Text;

            db.Customers.InsertOnSubmit(query);
            db.SubmitChanges();
            Hide();
        }
    }
}

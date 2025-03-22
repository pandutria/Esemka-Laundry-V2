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
    public partial class FormPrepaidPackage : Form
    {
        DataBaseDataContext db = new DataBaseDataContext();
        int IdCustomer;
        int IdPackage;
        public FormPrepaidPackage()
        {
            InitializeComponent();
        }

        private void tbPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            var query = db.Customers.FirstOrDefault(x => x.PhoneNumber == tbPhoneNumber.Text);

            if (query != null)
            {
                IdCustomer = query.Id;
                lblName.Text = "Name: " + query.Name;
                lblAddress.Text = "Address: " + query.Address;
            }
        }

        private void linkAddNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FormAddCustomer().ShowDialog();
        }

        void showData()
        {
            dgvData.Columns.Clear();

            var query = db.PrepaidPackages.Where(x => x.CompletedDatetime == null && x.Customer.Name.StartsWith(tbSearch.Text) || x.Package.Service.Name.StartsWith(tbSearch.Text)).ToList()
                .Select(x => new {
                    PrepaidPackageId = x.Id,
                    Customer = x.Customer.Name,
                    PackageName = $"{x.Package.Service.Name} {x.Package.TotalUnit}KG",
                    Price = x.Price,
                    x.IdPackage
                }).ToList();

            dgvData.DataSource = query;

            dgvData.Columns["IdPackage"].Visible = false;
        }
        private void FormPrepaidPackage_Load(object sender, EventArgs e)
        {
            Support.enableField(this);
            tbId.Enabled = false;
            showData();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            showData();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbId.Text = dgvData.Rows[e.RowIndex].Cells["PrepaidPackageId"].Value.ToString();
                cboPackage.Text = dgvData.Rows[e.RowIndex].Cells["PackageName"].Value.ToString();
                nupPrice.Value = (int) dgvData.Rows[e.RowIndex].Cells["Price"].Value;
                IdPackage = (int) dgvData.Rows[e.RowIndex].Cells["IdPackage"].Value;

                var query = db.Customers.FirstOrDefault(x => x.Name == dgvData.Rows[e.RowIndex].Cells["Customer"].Value.ToString()); 

                if (query != null)
                {
                    tbPhoneNumber.Text = query.PhoneNumber;

                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbId.Text == "" || tbPhoneNumber.Text == "" || nupPrice.Value == 0)
            {
                Support.msw("All fields must be filled");
                return;
            }

            var query = db.PrepaidPackages.FirstOrDefault(x => x.Id == Convert.ToInt32( tbId.Text));

            if (query != null)
            {
                query.IdCustomer = IdCustomer;
                query.IdPackage = IdPackage;
                query.Price = (int) nupPrice.Value;
                query.CompletedDatetime = DateTime.Now;

                db.SubmitChanges();
                Support.msi("Berhasil");
                Hide();
            }
        }
    }
}

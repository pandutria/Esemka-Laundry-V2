using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EsemkaLaundryWithDesign
{
    public partial class FormPackage : Form
    {
        DataBaseDataContext db = new DataBaseDataContext();
        string mode;
        public FormPackage()
        {
            InitializeComponent();
        }

        void enableButton(bool e)
        {
            btnInsert.Enabled = e;
            btnUpdate.Enabled = e;
            btnDelete.Enabled = e;

            btnSave.Enabled = !e;
            btnCancel.Enabled = !e;
        }

        void enableField(bool e)
        {
            nupPrice.Enabled = !e;
            cboService.Enabled = !e;
            nupPrice.Enabled = !e;
            nupUnit.Enabled = !e;
        }

        void enableFieldAndButton(bool e)
        {
            enableButton(e);
            enableField(e);
        }

        void showDataCbo()
        {
            cboService.DataSource = db.Services;
            cboService.ValueMember = "Id";
            cboService.DisplayMember = "Name";
        }

        void showData()
        {
            dgvData.Columns.Clear();

            var query = db.Packages.Where(x => x.Service.Name.StartsWith(tbSearch.Text) || x.TotalUnit.ToString().Equals(tbSearch.Text) || x.Price.ToString().Equals(tbSearch.Text)).ToList()
                .Select(x => new {
                    PackageID = x.Id,
                    ServiceName = x.Service.Name,
                    TotalUnit = x.TotalUnit,
                    x.Price,
                }).ToList();

            dgvData.DataSource = query;
        }

        private void FormPackage_Load(object sender, EventArgs e)
        {
            Support.enableField(this);
            showDataCbo();
            showData();
            tbId.Enabled = false;
            enableFieldAndButton(true);

            nupPrice.Minimum = 0;
            nupPrice.Maximum = 9999999;

            nupUnit.Minimum = 0;
            nupUnit.Maximum = 9999999;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            showData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            mode = "insert";
            Support.clearField(this);
            enableFieldAndButton(false);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbId.Text == "")
            {
                Support.msw("Click row!!!");
                return;
            }

            mode = "update";
            enableFieldAndButton(false);
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbId.Text = dgvData.Rows[e.RowIndex].Cells["PackageID"].Value.ToString();
                cboService.Text = dgvData.Rows[e.RowIndex].Cells["ServiceName"].Value.ToString();
                nupPrice.Value = Convert.ToDecimal(dgvData.Rows[e.RowIndex].Cells["Price"].Value);
                nupUnit.Value = Convert.ToDecimal(dgvData.Rows[e.RowIndex].Cells["TotalUnit"].Value);
            }
        }

        private bool validation()
        {
            if (cboService.Text == "" || nupUnit.Value == 0
                || nupPrice.Value == 0)
            {
                Support.msw("All fields must be filled");
                return true;
            }

            return false;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validation())
                {
                    if (mode == "insert")
                    {
                        var query = new Package();
                        query.IdService = Convert.ToInt32(cboService.SelectedValue);
                        query.Price = Convert.ToInt32(nupPrice.Value);
                        query.TotalUnit = Convert.ToInt32(nupUnit.Value);

                        db.Packages.InsertOnSubmit(query);
                        db.SubmitChanges();
                        Support.msi("Insert data success");
                        Support.clearField(this);
                        showDataCbo();
                        showData();
                        enableFieldAndButton(true);
                    }

                    if (mode == "update")
                    {
                        var query = db.Packages.FirstOrDefault(x => x.Id == Convert.ToInt32(tbId.Text));

                        if (query != null)
                        {
                            query.Service.Name =cboService.Text;
                            query.Price = Convert.ToInt32(nupPrice.Value);
                            query.TotalUnit = Convert.ToInt32(nupUnit.Value);

                            db.SubmitChanges();
                            Support.msi("update data success");
                            Support.clearField(this);
                            showDataCbo();
                            showData();
                            enableFieldAndButton(true);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Support.mse(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbId.Text == "")
            {
                Support.msw("CLick row !!!");
                return;
            }

            var query = db.Packages.FirstOrDefault(x => x.Id == Convert.ToInt32(tbId.Text));

            if (query != null)
            {
                var dialog = MessageBox.Show("Are you sure want to delete this data!", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    db.Packages.DeleteOnSubmit(query);
                    db.SubmitChanges();
                    Support.msi("delete data success");
                    Support.clearField(this);
                    showDataCbo();
                    showData();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Support.clearField(this);
            enableFieldAndButton(true);
        }
    }
}

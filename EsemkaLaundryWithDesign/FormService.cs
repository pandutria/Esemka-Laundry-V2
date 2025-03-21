using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemkaLaundryWithDesign
{
    public partial class FormService : Form
    {
        DataBaseDataContext db = new DataBaseDataContext();
        string mode;
        public FormService()
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
            tbName.Enabled = !e;
            cboUnit.Enabled = !e;
            cboCategory.Enabled = !e;
            nupPrice.Enabled = !e;
            nupDuration.Enabled = !e;
        }

        void enableFieldAndButton(bool e)
        {
            enableButton(e);
            enableField(e);
        }

        void showDataCbo()
        {
            cboCategory.DataSource = db.Categories;
            cboCategory.ValueMember = "Id";
            cboCategory.DisplayMember = "Name";

            cboUnit.DataSource = db.Units;
            cboUnit.ValueMember = "Id";
            cboUnit.DisplayMember = "Name";  
        }

        void showData()
        {
            dgvData.Columns.Clear();

            var query = db.Services.Where(x => x.Name.StartsWith(tbSearch.Text) || x.Category.Name.StartsWith(tbSearch.Text) || x.Unit.Name.StartsWith(tbSearch.Text) || x.PriceUnit.ToString().Equals(tbSearch.Text)).ToList()
                .Select(x => new {
                    ServiceID = x.Id,
                    ServiceName = x.Name,
                    Category = x.Category.Name,
                    Unit = x.Unit.Name,
                    Price = x.PriceUnit,
                    x.EstimationDuration
                }).ToList();

            dgvData.DataSource = query;
        }

        private void FormService_Load(object sender, EventArgs e)
        {
            Support.enableField(this);
            showDataCbo();
            showData();
            tbId.Enabled = false;
            enableFieldAndButton(true);

            nupPrice.Minimum = 0;
            nupPrice.Maximum = 9999999;

            nupDuration.Minimum = 0;
            nupDuration.Maximum = 9999999;
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
                tbId.Text = dgvData.Rows[e.RowIndex].Cells["ServiceID"].Value.ToString();
                tbName.Text = dgvData.Rows[e.RowIndex].Cells["ServiceName"].Value.ToString();
                cboCategory.Text = dgvData.Rows[e.RowIndex].Cells["Category"].Value.ToString();
                cboUnit.Text = dgvData.Rows[e.RowIndex].Cells["Unit"].Value.ToString();
                nupPrice.Value = Convert.ToDecimal(dgvData.Rows[e.RowIndex].Cells["Price"].Value);
                nupDuration.Value = Convert.ToDecimal(dgvData.Rows[e.RowIndex].Cells["EstimationDuration"].Value);
            }
        }

        private bool validation()
        {
            if (tbName.Text == "" || cboCategory.Text == "" || cboUnit.Text == "" || nupDuration.Value == 0
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
                        var query = new Service();
                        query.Name = tbName.Text;
                        query.IdCategory = Convert.ToInt32(cboCategory.SelectedValue);
                        query.IdUnit = Convert.ToInt32(cboUnit.SelectedValue);
                        query.PriceUnit = Convert.ToInt32( nupPrice.Value);
                        query.EstimationDuration = Convert.ToInt32( nupDuration.Value);

                        db.Services.InsertOnSubmit(query);
                        db.SubmitChanges();
                        Support.msi("Insert data success");
                        Support.clearField(this);
                        showDataCbo();
                        showData();
                        enableFieldAndButton(true);
                    }

                    if (mode == "update")
                    {
                        var query = db.Services.FirstOrDefault(x => x.Id == Convert.ToInt32(tbId.Text));

                        if (query != null)
                        {
                            query.Name = tbName.Text;
                            query.Category.Name = cboCategory.Text;
                            query.Unit.Name = cboUnit.Text;
                            query.PriceUnit = Convert.ToInt32(nupPrice.Value);
                            query.EstimationDuration = Convert.ToInt32(nupDuration.Value);

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

            var query = db.Services.FirstOrDefault(x => x.Id == Convert.ToInt32(tbId.Text));

            if (query != null)
            {
                var dialog = MessageBox.Show("Are you sure want to delete this data!", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    db.Services.DeleteOnSubmit(query);
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

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
    public partial class FormTransactionDeposit : Form
    {
        DataBaseDataContext db = new DataBaseDataContext();
        int estimateDuration;
        string category;
        int IdCustomer;

        int totalEstimateDuration;
        public FormTransactionDeposit()
        {
            InitializeComponent();
        }

        void showDataCbo()
        {
            cboService.DataSource = db.Services;
            cboService.ValueMember = "Id";
            cboService.DisplayMember = "Name";
        }

        private void FormTransactionDeposit_Load(object sender, EventArgs e)
        {
            Support.enableField(this);
            showDataCbo();
            tbPrice.Enabled = false;
            lblCurrentTime.Text = DateTime.Now.ToString("dd-MMM-yy hh:mm:ss");
        }

        private void btnAdd_Click(object sender, EventArgs e)   
        {
            if (nupUnit.Value == 0)
            {
                Support.msw("Field total unit must be minimal 0.1");
                return;
            }

            if (!cboUsePrepaid.Checked)
            {
                dgvData.Rows.Add(cboService.Text, null, tbPrice.Text, nupUnit.Value, (Convert.ToDecimal(tbPrice.Text) * nupUnit.Value).ToString().Replace(".0", ""), btnDelete.Text = "Delete", cboService.SelectedValue, estimateDuration, category);
            } else
            {
                dgvData.Rows.Add(cboService.Text, $"{cboService.Text} {nupUnit.Value}", tbPrice.Text, nupUnit.Value, 0, btnDelete.Text = "Delete", cboService.SelectedValue, estimateDuration, category);
            }

            countTotalAndEstimateTime();
        }

        private void cboService_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboService.SelectedValue != null)
            {
                var query = db.Services.FirstOrDefault(x => x.Name == cboService.Text);

                if (query != null)
                {
                    tbPrice.Text = query.PriceUnit.ToString();
                    estimateDuration = query.EstimationDuration;
                    category = query.Category.Name;
                }
            }
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

        void countTotalAndEstimateTime()
        {
            var total = 0;
            var estimateTime = 0;

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells[4].Value != null)
                {
                    total += Convert.ToInt32( row.Cells[4].Value);
                }

                if (row.Cells[7].Value != null)
                {
                    if (row.Cells[8].Value != null && row.Cells[8].Value.ToString().Contains("Kiloan"))
                    {
                        totalEstimateDuration += Convert.ToInt32(row.Cells[7].Value);
                        estimateTime += Convert.ToInt32(row.Cells[7].Value);
                    } 
                    else
                    {
                        totalEstimateDuration += Convert.ToInt32(row.Cells[7].Value) * Convert.ToInt32(row.Cells[3].Value);
                        estimateTime += Convert.ToInt32(row.Cells[7].Value) * Convert.ToInt32(row.Cells[3].Value);
                    }
                    
                }

            }
            lblEstimateDate.Text = new TimeSpan(estimateTime,0, 0).ToString();
            lblTotalPay.Text = total.ToString();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvData.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                dgvData.Rows.RemoveAt(e.RowIndex);
                countTotalAndEstimateTime();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count < 1)
            {
                Support.msw("datagridview must be more than or equals one.");
                return;
            }

            var queryCheck = db.Customers.FirstOrDefault(x => x.PhoneNumber == tbPhoneNumber.Text);

            if (queryCheck == null)
            {
                Support.msw("Customer not found");
                return;
            }

            try
            {
                var queryHeader = new HeaderDeposit();
                queryHeader.IdCustomer = IdCustomer;
                queryHeader.IdEmployee = Form1.employee.Id;
                queryHeader.TransactionDatetime = DateTime.Now;
                queryHeader.CompleteEstimationDatetime = DateTime.Now.AddHours(totalEstimateDuration);

                db.HeaderDeposits.InsertOnSubmit(queryHeader);
                db.SubmitChanges();

                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    if (row.Cells[1].Value != null)
                    {
                        var queryPackage = new Package();
                        queryPackage.IdService = Convert.ToInt32(row.Cells[6].Value);
                        queryPackage.TotalUnit = Convert.ToInt32(row.Cells[3].Value);
                        queryPackage.Price = Convert.ToInt32(row.Cells[2].Value);

                        db.Packages.InsertOnSubmit(queryPackage);
                        db.SubmitChanges();

                        var queryPrepaidPackage = new PrepaidPackage();
                        queryPrepaidPackage.IdCustomer = IdCustomer;
                        queryPrepaidPackage.IdPackage = queryPackage.Id;
                        queryPrepaidPackage.Price = Convert.ToInt32(row.Cells[4].Value);
                        queryPrepaidPackage.StartDateTime = DateTime.Now;
                        
                        db.PrepaidPackages.InsertOnSubmit(queryPrepaidPackage);
                        db.SubmitChanges();

                        var queryDetail = new DetailDeposit();
                        queryDetail.IdDeposit = queryHeader.Id;
                        queryDetail.IdService = Convert.ToInt32(row.Cells[6].Value);
                        queryDetail.IdPrepaidPackage = queryPrepaidPackage.Id;
                        queryDetail.PriceUnit = Convert.ToInt32(row.Cells[2].Value);
                        queryDetail.TotalUnit = Convert.ToInt32(row.Cells[3].Value);

                        db.DetailDeposits.InsertOnSubmit(queryDetail);
                        db.SubmitChanges();
                    } 
                    
                    else
                    {
                        var queryDetail = new DetailDeposit();
                        queryDetail.IdDeposit = queryHeader.Id;
                        queryDetail.IdService = Convert.ToInt32(row.Cells[6].Value);
                        queryDetail.PriceUnit = Convert.ToInt32(row.Cells[2].Value);
                        queryDetail.TotalUnit = Convert.ToInt32(row.Cells[3].Value);

                        db.DetailDeposits.InsertOnSubmit(queryDetail);
                        db.SubmitChanges();
                    }
                }

                db.SubmitChanges();
                Support.msi("Berhasil");
                Support.clearField(this);

            } catch (Exception ex)
            {
                Support.mse(ex.Message);
            }
        }

        private void linkAddNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FormAddCustomer().ShowDialog();
        }
    }
}

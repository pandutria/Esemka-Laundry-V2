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
    public partial class FormViewTransaction : Form
    {
        DataBaseDataContext db = new DataBaseDataContext();
        int IdHeader;
        public FormViewTransaction()
        {
            InitializeComponent();
        }

        void showDataHeader()
        {
            dgvDataHeader.Columns.Clear();

            var query = db.HeaderDeposits.Where(x => x.Customer.Name.StartsWith(tbSearch.Text) || x.Employee.Name.StartsWith(tbSearch.Text) || x.TransactionDatetime.ToString().StartsWith(tbSearch.Text))
                .Select(x => new
                {
                    ID =x.Id,
                    CustomerId = x.IdCustomer,
                    EmployeeName = x.Employee.Name,
                    x.TransactionDatetime,
                    x.CompleteEstimationDatetime,
                });

            dgvDataHeader.DataSource = query;
        }

        void showDataDetail()
        {
            dgvDataDetail.Columns.Clear();

            var query = db.DetailDeposits.Where(x => x.IdDeposit == IdHeader && x.CompletedDatetime == null)
                .Select(x => new
                {
                    ServiceName = x.Service.Name,
                    PrepaidPackage = x.IdPrepaidPackage,
                    PricePerUnit = x.PriceUnit,
                    TotalUnit = x.TotalUnit,
                    CompleteDateTime = x.CompletedDatetime,
                    x.Id
                });

            dgvDataDetail.DataSource = query;

            var btnAction = new DataGridViewButtonColumn();
            btnAction.Text = "Complete";
            btnAction.HeaderText = "Action";
            btnAction.UseColumnTextForButtonValue = true;
            btnAction.Name = "btnAction";

            dgvDataDetail.Columns.Add(btnAction);

            dgvDataDetail.Columns["Id"].Visible = false;
        }

        private void FormViewTransaction_Load(object sender, EventArgs e)
        {
            Support.enableField(this);
            showDataHeader();
        }

        private void dgvDataHeader_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                IdHeader = (int) dgvDataHeader.Rows[e.RowIndex].Cells["ID"].Value;
                showDataDetail();
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            showDataHeader();
        }

        private void dgvDataDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDataDetail.Columns["btnAction"].Index && e.RowIndex >= 0)
            {
                var query = db.DetailDeposits.FirstOrDefault(x => x.Id == (int)dgvDataDetail.Rows[e.RowIndex].Cells["Id"].Value);

                if (query != null)
                {
                    query.CompletedDatetime = DateTime.Now;
                    db.SubmitChanges();
                    Support.msi("Berhasil");
                    showDataHeader();
                    showDataDetail();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemkaLaundryWithDesign
{
    public partial class FormEmployee : Form
    {
        DataBaseDataContext db = new DataBaseDataContext();
        string mode;
        public FormEmployee()
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
            tbEmail.Enabled = !e;
            tbPhone.Enabled = !e;
            tbAddress.Enabled = !e;
            dtpBirth.Enabled = !e;
            cboJob.Enabled = !e;
            nupSalary.Enabled = !e;
            tbPassword.Enabled = !e;
            tbConfirmPassword.Enabled = !e;
        }

        void enableFieldAndButton(bool e)
        {
            enableButton(e);
            enableField(e);
        }

        void showDataCbo()
        {
            cboJob.DataSource = db.Jobs;
            cboJob.ValueMember = "Id";
            cboJob.DisplayMember = "Name";
        }

        void showData()
        {
            dgvData.Columns.Clear();

            var query = db.Employees.Where(x => x.Name.StartsWith(tbSearch.Text) || x.Email.StartsWith(tbSearch.Text) || x.PhoneNumber.StartsWith(tbSearch.Text)).ToList()
                .Select(x => new {
                    EmployeeId = x.Id,
                    x.Name,
                    x.Email, 
                    x.PhoneNumber,
                    x.Address,
                    x.DateOfBirth,
                    Job = x.Job.Name,
                    Salary = x.Salary.ToString("N0").Replace(",", ""),
                    SalaryHidden = x.Salary,
                    x.Password
                }).ToList();

            dgvData.DataSource = query;
            dgvData.Columns["SalaryHidden"].Visible = false;
            dgvData.Columns["Password"].Visible = false;
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            Support.enableField(this);
            nupSalary.Minimum = 0;
            nupSalary.Maximum = 9999999;
            tbId.Enabled = false;
            enableFieldAndButton(true);
            showData();
            showDataCbo();
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

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
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

        private bool isValidEmail(string email)
        {
            var regex = @"^\S+@\S+\.\S+$";
            return Regex.IsMatch(email, regex);
        }

        private bool validation()
        {
            if (tbName.Text == "" || tbEmail.Text == "" || tbPhone.Text == "" || tbAddress.Text == "" 
                || cboJob.Text == "" || nupSalary.Value == 0 || tbPassword.Text == "")
            {
                Support.msw("All fields must be filled");
                return true;
            }

            if (!isValidEmail(tbEmail.Text))
            {
                Support.msw("Filed email must be valid format");
                return true;
            }

            if (tbPassword.Text != tbConfirmPassword.Text)
            {
                Support.msw("Field password and confirm password must be valid format");
                return true;
            }

            if (tbPhone.Text.Substring(0, 1) != "+" || !tbPhone.Text.Replace("+", "").All(x => char.IsDigit(x)))
            {
                Support.msw("Field Phone number must be start with "+" and another with digit");
                return true;
            }

            if (dtpBirth.Value > DateTime.Now)
            {
                Support.msw("date of birth must be less than current");
                return true;
            }

            return false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if  (!validation())
                {
                    if (mode == "insert")
                    {
                        var query = new Employee();
                        query.Name = tbName.Text;
                        query.Email = tbEmail.Text;
                        query.PhoneNumber = tbPhone.Text;
                        query.Address = tbAddress.Text;
                        query.DateOfBirth = dtpBirth.Value;
                        query.IdJob = Convert.ToInt32( cboJob.SelectedValue);
                        query.Salary = nupSalary.Value;
                        query.Password = tbPassword.Text;

                        db.Employees.InsertOnSubmit(query);
                        db.SubmitChanges();
                        Support.msi("Insert data success");
                        Support.clearField(this);
                        showDataCbo();
                        showData();
                        enableFieldAndButton(true);
                    }

                    if (mode == "update")
                    {
                        var query = db.Employees.FirstOrDefault(x => x.Id == Convert.ToInt32( tbId.Text));

                        if (query != null)
                        {
                            query.Name = tbName.Text;
                            query.Email = tbEmail.Text;
                            query.PhoneNumber = tbPhone.Text;
                            query.Address = tbAddress.Text;
                            query.DateOfBirth = dtpBirth.Value;
                            query.IdJob = Convert.ToInt32(cboJob.SelectedValue);
                            query.Salary = nupSalary.Value;
                            query.Password = tbPassword.Text;

                            db.SubmitChanges();
                            Support.msi("update data success");
                            Support.clearField(this);
                            showDataCbo();
                            showData();
                            enableFieldAndButton(true);
                        }
                    }
                }
            } catch (Exception ex)
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

            var query = db.Employees.FirstOrDefault(x => x.Id == Convert.ToInt32(tbId.Text)); 

            if (query != null)
            {
                var dialog = MessageBox.Show("Are you sure want to delete this data!","Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    db.Employees.DeleteOnSubmit(query);
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

        private void dgvData_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbId.Text = dgvData.Rows[e.RowIndex].Cells["EmployeeID"].Value.ToString();
                tbName.Text = dgvData.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                tbEmail.Text = dgvData.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                tbPhone.Text = dgvData.Rows[e.RowIndex].Cells["PhoneNumber"].Value.ToString();
                tbAddress.Text = dgvData.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                dtpBirth.Value = (DateTime)dgvData.Rows[e.RowIndex].Cells["DateOfBirth"].Value;
                cboJob.Text = dgvData.Rows[e.RowIndex].Cells["Job"].Value.ToString();
                nupSalary.Value = Convert.ToDecimal(dgvData.Rows[e.RowIndex].Cells["SalaryHidden"].Value.ToString().Replace(".0000", ""));
                tbPassword.Text = dgvData.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                tbConfirmPassword.Text = dgvData.Rows[e.RowIndex].Cells["Password"].Value.ToString();
            }
        }
    }
}

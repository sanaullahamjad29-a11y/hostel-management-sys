using hostelmanagement.Database;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace hostelmanagement
{
    public partial class Pay : Form
    {
        public Pay()
        {
            InitializeComponent();
        }

        private void Pay_Load(object sender, EventArgs e)
        {
            dtpMonth.Format =
                DateTimePickerFormat.Custom;

            dtpMonth.CustomFormat =
                "MMMM yyyy";

            dtpMonth.ShowUpDown = true;
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            DataGridView dgvFees =
                new DataGridView();

            dgvFees.Name = "dgvFees";

            dgvFees.Location =
                new Point(50, 300);

            dgvFees.Size =
                new Size(600, 300);

            dgvFees.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvFees.BackgroundColor =
                Color.White;

            dgvFees.AllowUserToAddRows = false;

            Control existingGrid =
                this.Controls["dgvFees"];

            if (existingGrid != null)
                this.Controls.Remove(existingGrid);

            this.Controls.Add(dgvFees);

            string selectedMonth =
                dtpMonth.Value.ToString("MMMM yyyy");

            try
            {
                DataTable dt =
                    PaymentDB.GetFeeStatus(selectedMonth);

                dgvFees.DataSource = dt;

                foreach (DataGridViewRow row in dgvFees.Rows)
                {
                    if (row.Cells["FeeStatus"].Value != null)
                    {
                        string status =
                            row.Cells["FeeStatus"].Value.ToString();

                        row.DefaultCellStyle.BackColor =
                            (status == "Paid")
                            ? Color.LightGreen
                            : Color.LightCoral;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
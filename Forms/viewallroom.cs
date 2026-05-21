using hostelmanagement.Database;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace hostelmanagement
{
    public partial class viewallroom : Form
    {
        public viewallroom()
        {
            InitializeComponent();
        }

        private void viewallroom_Load(object sender, EventArgs e)
        {
            try
            {
                dvgRooms.DataSource =
                    RoomDB.GetAllRooms();

                foreach (DataGridViewRow row in dvgRooms.Rows)
                {
                    if (row.Cells["RoomStatus"].Value?.ToString() == "Full")
                    {
                        row.DefaultCellStyle.BackColor =
                            Color.LightPink;
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

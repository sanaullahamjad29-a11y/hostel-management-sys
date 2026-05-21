using hostelmanagement.Database;
using hostelmanagement.Models;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace hostelmanagement
{
    public partial class addroom : Form
    {
        public addroom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Please fill all fields", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Room r = new Room();

                r.RoomNumber = Convert.ToInt32(textBox1.Text);
                r.HostelName = textBox2.Text;

                RoomDB.AddRoom(r);

                MessageBox.Show("New Room Added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

using hostelmanagement.Database;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace hostelmanagement
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();

            ApplyHoverEffects();
        }

        // =========================
        // HOVER EFFECTS
        // =========================

        private void ApplyHoverEffects()
        {
            AddHover(btnDashboard);
            AddHover(btnStudents);
            AddHover(btnRooms);
            AddHover(btnFees);
            AddHover(btnLogout);
        }

        private void AddHover(Button btn)
        {
            btn.MouseEnter += (s, e) =>
            {
                if (btn != btnLogout)
                {
                    btn.BackColor =
                        Color.FromArgb(59, 130, 246);
                }
            };

            btn.MouseLeave += (s, e) =>
            {
                if (btn == btnLogout)
                {
                    btn.BackColor =
                        Color.FromArgb(220, 38, 38);
                }
                else
                {
                    btn.BackColor =
                        Color.FromArgb(30, 41, 59);
                }
            };
        }

        // =========================
        // DASHBOARD
        // =========================

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Welcome to Hostel Management Dashboard",
                "Dashboard",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // =========================
        // STUDENTS
        // =========================

        private void btnStudents_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menu =
                new ContextMenuStrip();

            menu.Items.Add(
                "Add Student",
                null,
                (s, ev) =>
                {
                    Addstudentform f =
                        new Addstudentform();

                    f.ShowDialog();
                });

            menu.Items.Add(
                "View Students",
                null,
                (s, ev) =>
                {
                    viewstudents f =
                        new viewstudents();

                    f.ShowDialog();
                });

            menu.Items.Add(
                "Delete Student",
                null,
                (s, ev) =>
                {
                    deletestd f =
                        new deletestd();

                    f.ShowDialog();
                });

            menu.Show(
                btnStudents,
                new Point(0, btnStudents.Height));
        }

        // =========================
        // ROOMS
        // =========================

        private void btnRooms_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menu =
                new ContextMenuStrip();

            menu.Items.Add(
                "Add Room",
                null,
                (s, ev) =>
                {
                    addroom f =
                        new addroom();

                    f.ShowDialog();
                });

            menu.Items.Add(
                "View Rooms",
                null,
                (s, ev) =>
                {
                    viewallroom f =
                        new viewallroom();

                    f.ShowDialog();
                });

            menu.Show(
                btnRooms,
                new Point(0, btnRooms.Height));
        }

        // =========================
        // FEES
        // =========================

        private void btnFees_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menu =
                new ContextMenuStrip();

            menu.Items.Add(
                "Enter Fee",
                null,
                (s, ev) =>
                {
                    enterfee f =
                        new enterfee();

                    f.ShowDialog();
                });

            menu.Items.Add(
                "Fee Status",
                null,
                (s, ev) =>
                {
                    Pay f =
                        new Pay();

                    f.ShowDialog();
                });

            menu.Show(
                btnFees,
                new Point(0, btnFees.Height));
        }

        // =========================
        // LOGOUT
        // =========================

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to logout?",
                    "Logout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm login =
                    new LoginForm();

                login.Show();

                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            long bytes = dbconfig.GetDatabaseFileSize();
            double megabytes = (double)bytes / (1024 * 1024);
            lblsize.Text = "DB Active Size: " + megabytes.ToString("0.00") + " MB";
        }
    }
}
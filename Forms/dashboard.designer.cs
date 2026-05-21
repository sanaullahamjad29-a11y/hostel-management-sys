namespace hostelmanagement
{
    partial class dashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing &&
                (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            sidebarPanel = new Panel();
            btnDashboard = new Button();
            btnStudents = new Button();
            btnRooms = new Button();
            btnFees = new Button();
            btnLogout = new Button();
            topPanel = new Panel();
            lblsize = new Label();
            lblTitle = new Label();
            lblWelcome = new Label();
            cardStudents = new Panel();
            lblStudents = new Label();
            cardRooms = new Panel();
            lblRooms = new Label();
            cardFees = new Panel();
            lblFees = new Label();
            sidebarPanel.SuspendLayout();
            topPanel.SuspendLayout();
            cardStudents.SuspendLayout();
            cardRooms.SuspendLayout();
            cardFees.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(30, 41, 59);
            sidebarPanel.Controls.Add(btnDashboard);
            sidebarPanel.Controls.Add(btnStudents);
            sidebarPanel.Controls.Add(btnRooms);
            sidebarPanel.Controls.Add(btnFees);
            sidebarPanel.Controls.Add(btnLogout);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(250, 800);
            sidebarPanel.TabIndex = 0;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(30, 41, 59);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 120);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(250, 60);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "🏠 Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnStudents
            // 
            btnStudents.BackColor = Color.FromArgb(30, 41, 59);
            btnStudents.FlatAppearance.BorderSize = 0;
            btnStudents.FlatStyle = FlatStyle.Flat;
            btnStudents.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnStudents.ForeColor = Color.White;
            btnStudents.Location = new Point(0, 190);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(250, 60);
            btnStudents.TabIndex = 1;
            btnStudents.Text = "👨 Students";
            btnStudents.UseVisualStyleBackColor = false;
            btnStudents.Click += btnStudents_Click;
            // 
            // btnRooms
            // 
            btnRooms.BackColor = Color.FromArgb(30, 41, 59);
            btnRooms.FlatAppearance.BorderSize = 0;
            btnRooms.FlatStyle = FlatStyle.Flat;
            btnRooms.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRooms.ForeColor = Color.White;
            btnRooms.Location = new Point(0, 260);
            btnRooms.Name = "btnRooms";
            btnRooms.Size = new Size(250, 60);
            btnRooms.TabIndex = 2;
            btnRooms.Text = "🛏 Rooms";
            btnRooms.UseVisualStyleBackColor = false;
            btnRooms.Click += btnRooms_Click;
            // 
            // btnFees
            // 
            btnFees.BackColor = Color.FromArgb(30, 41, 59);
            btnFees.FlatAppearance.BorderSize = 0;
            btnFees.FlatStyle = FlatStyle.Flat;
            btnFees.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFees.ForeColor = Color.White;
            btnFees.Location = new Point(0, 330);
            btnFees.Name = "btnFees";
            btnFees.Size = new Size(250, 60);
            btnFees.TabIndex = 3;
            btnFees.Text = "💰 Fees";
            btnFees.UseVisualStyleBackColor = false;
            btnFees.Click += btnFees_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(220, 38, 38);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(25, 700);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(200, 50);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "🚪 Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.White;
            topPanel.Controls.Add(lblTitle);
            topPanel.Controls.Add(lblWelcome);
            topPanel.Location = new Point(250, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1150, 100);
            topPanel.TabIndex = 1;
            // 
            // lblsize
            // 
            lblsize.AutoSize = true;
            lblsize.Font = new Font("Segoe UI", 12F);
            lblsize.Location = new Point(1105, 525);
            lblsize.Name = "lblsize";
            lblsize.Size = new Size(78, 32);
            lblsize.TabIndex = 5;
            lblsize.Text = "label1";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblTitle.Location = new Point(40, 3);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(766, 65);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOSTEL MANAGEMENT SYSTEM";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F);
            lblWelcome.ForeColor = Color.Gray;
            lblWelcome.Location = new Point(45, 60);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(291, 32);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome Back, Admin 👋";
            // 
            // cardStudents
            // 
            cardStudents.BackColor = Color.White;
            cardStudents.Controls.Add(lblStudents);
            cardStudents.Location = new Point(320, 170);
            cardStudents.Name = "cardStudents";
            cardStudents.Size = new Size(300, 180);
            cardStudents.TabIndex = 2;
            // 
            // lblStudents
            // 
            lblStudents.AutoSize = true;
            lblStudents.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblStudents.ForeColor = Color.FromArgb(37, 99, 235);
            lblStudents.Location = new Point(35, 40);
            lblStudents.Name = "lblStudents";
            lblStudents.Size = new Size(251, 114);
            lblStudents.TabIndex = 0;
            lblStudents.Text = "👨 Total Students\n\n120";
            // 
            // cardRooms
            // 
            cardRooms.BackColor = Color.White;
            cardRooms.Controls.Add(lblRooms);
            cardRooms.Location = new Point(670, 170);
            cardRooms.Name = "cardRooms";
            cardRooms.Size = new Size(300, 180);
            cardRooms.TabIndex = 3;
            // 
            // lblRooms
            // 
            lblRooms.AutoSize = true;
            lblRooms.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblRooms.ForeColor = Color.FromArgb(16, 185, 129);
            lblRooms.Location = new Point(25, 40);
            lblRooms.Name = "lblRooms";
            lblRooms.Size = new Size(281, 114);
            lblRooms.TabIndex = 0;
            lblRooms.Text = "🛏 Available Rooms\n\n35";
            // 
            // cardFees
            // 
            cardFees.BackColor = Color.White;
            cardFees.Controls.Add(lblFees);
            cardFees.Location = new Point(1020, 170);
            cardFees.Name = "cardFees";
            cardFees.Size = new Size(300, 180);
            cardFees.TabIndex = 4;
            // 
            // lblFees
            // 
            lblFees.AutoSize = true;
            lblFees.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblFees.ForeColor = Color.FromArgb(220, 38, 38);
            lblFees.Location = new Point(35, 40);
            lblFees.Name = "lblFees";
            lblFees.Size = new Size(236, 114);
            lblFees.TabIndex = 0;
            lblFees.Text = "💰 Pending Fees\n\n15";
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1400, 800);
            Controls.Add(lblsize);
            Controls.Add(sidebarPanel);
            Controls.Add(topPanel);
            Controls.Add(cardStudents);
            Controls.Add(cardRooms);
            Controls.Add(cardFees);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hostel Management Dashboard";
            Load += Form1_Load;
            sidebarPanel.ResumeLayout(false);
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            cardStudents.ResumeLayout(false);
            cardStudents.PerformLayout();
            cardRooms.ResumeLayout(false);
            cardRooms.PerformLayout();
            cardFees.ResumeLayout(false);
            cardFees.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel sidebarPanel;

        private System.Windows.Forms.Panel topPanel;

        private System.Windows.Forms.Button btnDashboard;

        private System.Windows.Forms.Button btnStudents;

        private System.Windows.Forms.Button btnRooms;

        private System.Windows.Forms.Button btnFees;

        private System.Windows.Forms.Button btnLogout;

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Label lblWelcome;

        private System.Windows.Forms.Panel cardStudents;

        private System.Windows.Forms.Panel cardRooms;

        private System.Windows.Forms.Panel cardFees;

        private System.Windows.Forms.Label lblStudents;

        private System.Windows.Forms.Label lblRooms;

        private System.Windows.Forms.Label lblFees;
        private Label lblsize;
    }
}
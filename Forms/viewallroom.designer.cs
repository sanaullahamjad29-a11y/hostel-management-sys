namespace hostelmanagement
{
    partial class viewallroom
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
            panelTop = new Panel();

            labelTitle = new Label();

            dvgRooms = new DataGridView();

            panelTop.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)dvgRooms).BeginInit();

            SuspendLayout();

            // FORM

            AutoScaleDimensions =
                new SizeF(8F, 20F);

            AutoScaleMode =
                AutoScaleMode.Font;

            BackColor =
                Color.FromArgb(241, 245, 249);

            ClientSize =
                new Size(1200, 700);

            StartPosition =
                FormStartPosition.CenterScreen;

            FormBorderStyle =
                FormBorderStyle.FixedSingle;

            MaximizeBox = false;

            Text = "View All Rooms";

            // TOP PANEL

            panelTop.BackColor =
                Color.White;

            panelTop.Dock =
                DockStyle.Top;

            panelTop.Height = 90;

            // TITLE

            labelTitle.AutoSize = true;

            labelTitle.Font =
                new Font(
                    "Segoe UI",
                    22F,
                    FontStyle.Bold);

            labelTitle.ForeColor =
                Color.FromArgb(30, 41, 59);

            labelTitle.Location =
                new Point(30, 20);

            labelTitle.Text =
                "ALL ROOMS";

            // DATAGRIDVIEW

            dvgRooms.BackgroundColor =
                Color.White;

            dvgRooms.BorderStyle =
                BorderStyle.None;

            dvgRooms.Location =
                new Point(30, 120);

            dvgRooms.Size =
                new Size(1130, 520);

            dvgRooms.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dvgRooms.RowTemplate.Height = 35;

            dvgRooms.Font =
                new Font(
                    "Segoe UI",
                    10F);

            dvgRooms.ColumnHeadersDefaultCellStyle.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Bold);

            dvgRooms.EnableHeadersVisualStyles = false;

            dvgRooms.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(59, 130, 246);

            dvgRooms.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dvgRooms.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dvgRooms.GridColor =
                Color.LightGray;

            // ADD CONTROLS

            panelTop.Controls.Add(labelTitle);

            Controls.Add(panelTop);

            Controls.Add(dvgRooms);

            // LOAD EVENT

            Load += viewallroom_Load;

            panelTop.ResumeLayout(false);

            panelTop.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)dvgRooms).EndInit();

            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;

        private Label labelTitle;

        private DataGridView dvgRooms;
    }
}
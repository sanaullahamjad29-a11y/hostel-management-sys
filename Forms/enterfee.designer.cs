using System.Drawing;
using System.Windows.Forms;

namespace hostelmanagement
{
    partial class enterfee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up resources.
        /// </summary>
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
            panelCard = new Panel();
            lblTitle = new Label();
            lblStudent = new Label();
            txtStudentID = new TextBox();
            lblMonth = new Label();
            txtMonth = new TextBox();
            btnUpdate = new Button();
            panelCard.SuspendLayout();
            SuspendLayout();
            // 
            // panelCard
            // 
            panelCard.BackColor = Color.White;
            panelCard.Controls.Add(lblTitle);
            panelCard.Controls.Add(lblStudent);
            panelCard.Controls.Add(txtStudentID);
            panelCard.Controls.Add(lblMonth);
            panelCard.Controls.Add(txtMonth);
            panelCard.Controls.Add(btnUpdate);
            panelCard.Location = new Point(180, 70);
            panelCard.Name = "panelCard";
            panelCard.Padding = new Padding(10);
            panelCard.Size = new Size(580, 380);
            panelCard.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(26, 37, 48);
            lblTitle.Location = new Point(145, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(273, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "UPDATE FEE";
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblStudent.ForeColor = Color.FromArgb(26, 37, 48);
            lblStudent.Location = new Point(75, 120);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(123, 30);
            lblStudent.TabIndex = 1;
            lblStudent.Text = "Student ID";
            // 
            // txtStudentID
            // 
            txtStudentID.BorderStyle = BorderStyle.FixedSingle;
            txtStudentID.Font = new Font("Segoe UI", 11F);
            txtStudentID.Location = new Point(75, 155);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.PlaceholderText = "Enter Student ID";
            txtStudentID.Size = new Size(430, 37);
            txtStudentID.TabIndex = 2;
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblMonth.ForeColor = Color.FromArgb(26, 37, 48);
            lblMonth.Location = new Point(75, 220);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(164, 30);
            lblMonth.TabIndex = 3;
            lblMonth.Text = "Month + YEAR";
            // 
            // txtMonth
            // 
            txtMonth.BorderStyle = BorderStyle.FixedSingle;
            txtMonth.Font = new Font("Segoe UI", 11F);
            txtMonth.Location = new Point(75, 255);
            txtMonth.Name = "txtMonth";
            txtMonth.PlaceholderText = "Write like \"MAY 2026\"";
            txtMonth.Size = new Size(430, 37);
            txtMonth.TabIndex = 4;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(41, 128, 185);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(190, 320);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(200, 50);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // enterfee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 247);
            ClientSize = new Size(950, 550);
            Controls.Add(panelCard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "enterfee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Fee";
            panelCard.ResumeLayout(false);
            panelCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCard;

        private Label lblTitle;

        private Label lblStudent;

        private TextBox txtStudentID;

        private Label lblMonth;

        private TextBox txtMonth;

        private Button btnUpdate;
    }
}
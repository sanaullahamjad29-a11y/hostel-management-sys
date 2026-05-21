namespace hostelmanagement
{
    partial class Pay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">
        /// true if managed resources should be disposed; otherwise, false.
        /// </param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.btnshow = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    14F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point);

            this.label1.Location =
                new System.Drawing.Point(50, 50);

            this.label1.Name = "label1";

            this.label1.Size =
                new System.Drawing.Size(235, 32);

            this.label1.TabIndex = 0;

            this.label1.Text = "Select Fee Month";

            // 
            // dtpMonth
            // 
            this.dtpMonth.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    12F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point);

            this.dtpMonth.Location =
                new System.Drawing.Point(50, 100);

            this.dtpMonth.Name = "dtpMonth";

            this.dtpMonth.Size =
                new System.Drawing.Size(250, 34);

            this.dtpMonth.TabIndex = 1;

            // 
            // btnshow
            // 
            this.btnshow.BackColor =
                System.Drawing.Color.SteelBlue;

            this.btnshow.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point);

            this.btnshow.ForeColor =
                System.Drawing.Color.White;

            this.btnshow.Location =
                new System.Drawing.Point(50, 170);

            this.btnshow.Name = "btnshow";

            this.btnshow.Size =
                new System.Drawing.Size(180, 50);

            this.btnshow.TabIndex = 2;

            this.btnshow.Text = "Show Status";

            this.btnshow.UseVisualStyleBackColor = false;

            this.btnshow.Click +=
                new System.EventHandler(this.btnshow_Click);

            // 
            // Pay
            // 
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 20F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.WhiteSmoke;

            this.ClientSize =
                new System.Drawing.Size(800, 650);

            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.dtpMonth);
            this.Controls.Add(this.label1);

            this.Name = "Pay";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "View Fee Status";

            this.Load +=
                new System.EventHandler(this.Pay_Load);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.DateTimePicker dtpMonth;

        private System.Windows.Forms.Button btnshow;
    }
}
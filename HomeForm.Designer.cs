namespace CrystalReportsDashboard
{
    partial class HomeForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblWelcome;

        private System.Windows.Forms.Panel card1;
        private System.Windows.Forms.Panel card2;
        private System.Windows.Forms.Panel card3;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();

            this.card1 = new System.Windows.Forms.Panel();
            this.card2 = new System.Windows.Forms.Panel();
            this.card3 = new System.Windows.Forms.Panel();

            this.SuspendLayout();

            // lblWelcome

            this.lblWelcome.Text = "Dashboard Overview";
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblWelcome.Location = new System.Drawing.Point(30, 30);

            // card1

            this.card1.BackColor = System.Drawing.Color.SteelBlue;
            this.card1.Location = new System.Drawing.Point(40, 120);
            this.card1.Size = new System.Drawing.Size(220, 120);

            // card2

            this.card2.BackColor = System.Drawing.Color.Teal;
            this.card2.Location = new System.Drawing.Point(300, 120);
            this.card2.Size = new System.Drawing.Size(220, 120);

            // card3

            this.card3.BackColor = System.Drawing.Color.DarkOrange;
            this.card3.Location = new System.Drawing.Point(560, 120);
            this.card3.Size = new System.Drawing.Size(220, 120);

            // HomeForm

            this.ClientSize = new System.Drawing.Size(900, 500);

            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.card1);
            this.Controls.Add(this.card2);
            this.Controls.Add(this.card3);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.ResumeLayout(false);
        }
    }
}

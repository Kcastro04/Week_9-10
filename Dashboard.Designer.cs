namespace CrystalReportsDashboard
{
    partial class Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTop;

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnLogout;

        private System.Windows.Forms.Label lblTitle;

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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();

            this.btnHome = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();

            this.lblTitle = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // panelMenu

            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(11, 24, 45);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Size = new System.Drawing.Size(220, 600);

            // btnHome

            this.btnHome.Text = "HOME";
            this.btnHome.Location = new System.Drawing.Point(20, 100);
            this.btnHome.Size = new System.Drawing.Size(180, 50);
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);

            // btnReports

            this.btnReports.Text = "REPORTS";
            this.btnReports.Location = new System.Drawing.Point(20, 170);
            this.btnReports.Size = new System.Drawing.Size(180, 50);
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);

            // btnLogout

            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.Location = new System.Drawing.Point(20, 240);
            this.btnLogout.Size = new System.Drawing.Size(180, 50);
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // panelTop

            this.panelTop.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(220, 0);
            this.panelTop.Size = new System.Drawing.Size(980, 80);

            // lblTitle

            this.lblTitle.Text = "Dashboard Home Form";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);

            // Controls

            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.btnReports);
            this.panelMenu.Controls.Add(this.btnLogout);

            this.panelTop.Controls.Add(this.lblTitle);

            // Dashboard

            this.IsMdiContainer = true;
            this.ClientSize = new System.Drawing.Size(1200, 600);

            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMenu);

            this.Name = "Dashboard";
            this.Text = "Dashboard";

            this.ResumeLayout(false);
        }
    }
}

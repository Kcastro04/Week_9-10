using System;
using System.Windows.Forms;

namespace CrystalReportsDashboard
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.MdiParent = this;
            home.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Form1 report = new Form1();
            report.MdiParent = this;
            report.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

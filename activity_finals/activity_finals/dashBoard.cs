using System;
using System.Drawing;
using System.Windows.Forms;

namespace activity_finals
{
    public partial class dashBoard : Form
    {
        public dashBoard()
        {
            InitializeComponent();

            btnLogout.Click += btnLogout_Click;

            LoadProducts();

            Resize += (s, e) => CenterMain();
            pnlContent.Resize += (s, e) => CenterDashboard();
            Shown += (s, e) =>
            {
                CenterMain();
                CenterDashboard();
                productGrid.ClearSelection();
            };
        }

        private void CenterMain()
        {
            int x = Math.Max(0, (ClientSize.Width - pnlMain.Width) / 2);
            int y = Math.Max(0, (ClientSize.Height - pnlMain.Height) / 2);
            pnlMain.Location = new Point(x, y);
        }

        private void CenterDashboard()
        {
            int x = Math.Max(0, (pnlContent.ClientSize.Width - pnlDashboard.Width) / 2);
            int y = Math.Max(0, (pnlContent.ClientSize.Height - pnlDashboard.Height) / 2);
            pnlDashboard.Location = new Point(x, y);
        }

        private void LoadProducts()
        {
            productGrid.Rows.Clear();

            try
            {
                foreach (object[] row in Db.GetProducts())
                {
                    productGrid.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load products: " + ex.Message,
                    "Database error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show(
                "Are you sure you want to log out?",
                "Log Out",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (answer == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
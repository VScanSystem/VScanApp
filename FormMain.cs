using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VScanApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void maintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSettings s = new FormSettings();
            s.ShowDialog();
        }

        private void scanTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormScanM s = new FormScanM();
            s.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMUsers s = new FormMUsers();
            s.ShowDialog();
        }

        private void newScanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormScan s = new FormScan();
            s.ShowDialog();
        }
    }
}

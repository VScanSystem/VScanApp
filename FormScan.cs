using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;


namespace VScanApp
{
    public partial class FormScan : Form
    {
        public FormScan()
        {
            InitializeComponent();           
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {

            string IP = textBoxInitIP.Text;
            Scan(IP);

        }


        public void Scan(string IP)
        {
            int startPort = int.Parse(textBoxInitPort.Text);
            int EndPort = int.Parse(textBoxFinalPort.Text);

            progressBar1.Value = 0;

            progressBar1.Maximum = EndPort - startPort + 1;

            Cursor.Current = Cursors.WaitCursor;

            for(int currPort=startPort;currPort<=EndPort;currPort++)
            {
                TcpClient tcpportScan = new TcpClient();

                try
                {

                    tcpportScan.Connect(IP, currPort);
                    textBoxResults.AppendText("Port " + currPort.ToString() + " Opened.\n");
                }
                catch
                {
                    
                }

                progressBar1.PerformStep();


            }

            Cursor.Current = Cursors.Arrow;
            textBoxResults.AppendText("Scan Completed");
        }

    }
}

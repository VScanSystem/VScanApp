using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VScanApp
{
    public partial class FormScanM : Form
    {
        public SqlConnection conection;
        public DataTable mydata;

        public FormScanM()
        {
            InitializeComponent();
            conection = new SqlConnection("server=MASTERSTORM-PC ; database=ScanDB ; integrated security = true");

            try
            {
                conection.Open();
                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        public void load()
        {

            try
            {


                string query = "select * from ScanType;";

                SqlDataAdapter data = new SqlDataAdapter(query, conection);
                mydata = new DataTable();
                data.Fill(mydata);

                tableData.DataSource = mydata;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void FormScanM_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                conection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {

            if (textBoxScanID.Text != "" && textBoxDescript.Text != "" && textBoxInitPort.Text != "" && textBoxFinalPort.Text != "" && textBoxInitIP.Text != "" &&
                textBoxFinalIP.Text != "" && textBoxSetComm.Text != "")
            {

                try
                {

                    string query = "insert into ScanType(ScanID,ScanDescription,InitPort,FinalPort,InitIP,FinalIP,SetCommand) " +
                        "values (" + textBoxScanID.Text + ",'" + textBoxDescript.Text + "'," + textBoxInitPort.Text + "," + textBoxFinalPort.Text + ",'" +
                        textBoxInitIP.Text + "','" + textBoxFinalIP.Text + "','" + textBoxSetComm.Text + "');";

                    SqlCommand command = new SqlCommand(query, conection);
                    command.ExecuteNonQuery();
                    load();

                    textBoxScanID.Text = "";
                    textBoxDescript.Text = "";
                    textBoxInitPort.Text = "";
                    textBoxFinalPort.Text = "";
                    textBoxInitIP.Text = "";
                    textBoxFinalIP.Text = "";
                    textBoxSetComm.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else MessageBox.Show("Fields empty");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxScanID.Text != "" && textBoxDescript.Text != "" && textBoxInitPort.Text != "" && textBoxFinalPort.Text != "" && textBoxInitIP.Text != "" &&
               textBoxFinalIP.Text != "" && textBoxSetComm.Text != "")
            {

                try
                {

                    string query = "update ScanType SET ScanDescription='" + textBoxDescript.Text + "',InitPort=" + textBoxInitPort.Text +
                        ",FinalPort=" + textBoxFinalPort.Text + ",InitIP='" + textBoxInitIP.Text + "',FinalIP='" + textBoxFinalIP.Text + "',SetCommand='" +
                        textBoxSetComm.Text + "' WHERE ScanID=" + textBoxScanID.Text + ";";

                    SqlCommand command = new SqlCommand(query, conection);
                    command.ExecuteNonQuery();
                    load();

                    textBoxScanID.Text = "";
                    textBoxDescript.Text = "";
                    textBoxInitPort.Text = "";
                    textBoxFinalPort.Text = "";
                    textBoxInitIP.Text = "";
                    textBoxFinalIP.Text = "";
                    textBoxSetComm.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else MessageBox.Show("Fields empty");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxIDdel.Text != "")
            {

                try
                {

                    string query = "delete from ScanType where ScanID=" + textBoxIDdel.Text + ";";

                    SqlCommand command = new SqlCommand(query, conection);
                    command.ExecuteNonQuery();
                    load();

                    textBoxScanID.Text = "";
                    textBoxDescript.Text = "";
                    textBoxInitPort.Text = "";
                    textBoxFinalPort.Text = "";
                    textBoxInitIP.Text = "";
                    textBoxFinalIP.Text = "";
                    textBoxSetComm.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else MessageBox.Show("Delete Field IDs empty");

        }

        private void tableData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            textBoxScanID.Text = tableData.SelectedCells[0].Value.ToString();
            textBoxDescript.Text = tableData.SelectedCells[1].Value.ToString();
            textBoxInitPort.Text = tableData.SelectedCells[2].Value.ToString();
            textBoxFinalPort.Text = tableData.SelectedCells[3].Value.ToString();
            textBoxInitIP.Text = tableData.SelectedCells[4].Value.ToString();
            textBoxFinalIP.Text = tableData.SelectedCells[5].Value.ToString();
            textBoxSetComm.Text = tableData.SelectedCells[6].Value.ToString();


        }
    }
}

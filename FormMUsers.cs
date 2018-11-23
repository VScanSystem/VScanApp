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
    public partial class FormMUsers : Form
    {

        public SqlConnection conection;
        public DataTable mydata;

        public FormMUsers()
        {
            InitializeComponent();
            conection = new SqlConnection("server=MASTERSTORM-PC ; database=ScanDB ; integrated security = true");

            try
            {
                conection.Open();
                load();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        public void load()
        {

            try
            {

                    
                    string query = "select * from users;";

                    SqlDataAdapter data = new SqlDataAdapter(query,conection);
                    mydata = new DataTable();
                    data.Fill(mydata);

                    tableData.DataSource = mydata;                           
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }






        private void FormMUsers_FormClosing(object sender, FormClosingEventArgs e)
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

        private void tableData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            textBoxUserID.Text = tableData.SelectedCells[0].Value.ToString();
            textBoxUserName.Text= tableData.SelectedCells[1].Value.ToString();
            textBoxPassword.Text= tableData.SelectedCells[2].Value.ToString();
            textBoxRoleID.Text= tableData.SelectedCells[3].Value.ToString();
            textBoxFn.Text= tableData.SelectedCells[4].Value.ToString();
            textBoxLn.Text= tableData.SelectedCells[5].Value.ToString();
            textBoxEmail.Text= tableData.SelectedCells[6].Value.ToString();


        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {

            if (textBoxUserID.Text != "" && textBoxUserName.Text != "" && textBoxPassword.Text != "" && textBoxRoleID.Text != "" && textBoxFn.Text != "" &&
                textBoxLn.Text != "" && textBoxEmail.Text != "")
            {

                try
                {

                    string query = "insert into users(UserID,UserName,UserPassword,RoleID,FirstName,LastName,UserEmail) " +
                        "values (" + textBoxUserID.Text + ",'"+textBoxUserName.Text+"','"+textBoxPassword.Text + "'," +textBoxRoleID.Text+",'"+
                        textBoxFn.Text + "','" + textBoxLn.Text + "','" + textBoxEmail.Text+ "');";

                    SqlCommand command = new SqlCommand(query, conection);
                    command.ExecuteNonQuery();
                    load();

                    textBoxUserID.Text = "";
                    textBoxUserName.Text = "";
                    textBoxPassword.Text = "";
                    textBoxRoleID.Text = "";
                    textBoxFn.Text = "";
                    textBoxLn.Text = "";
                    textBoxEmail.Text = "";

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
            if (textBoxUserID.Text != "" && textBoxUserName.Text != "" && textBoxPassword.Text != "" && textBoxRoleID.Text != "" && textBoxFn.Text != "" &&
               textBoxLn.Text != "" && textBoxEmail.Text != "")
            {

                try
                {

                    string query = "update users SET UserName='" + textBoxUserName.Text + "',UserPassword='" + textBoxPassword.Text +
                        "',RoleID=" + textBoxRoleID.Text + ",FirstName='" + textBoxFn.Text + "',LastName='" + textBoxLn.Text + "',UserEmail='" +
                        textBoxEmail.Text + "' WHERE UserID=" + textBoxUserID.Text + ";";

                    SqlCommand command = new SqlCommand(query, conection);
                    command.ExecuteNonQuery();
                    load();

                    textBoxUserID.Text = "";
                    textBoxUserName.Text = "";
                    textBoxPassword.Text = "";
                    textBoxRoleID.Text = "";
                    textBoxFn.Text = "";
                    textBoxLn.Text = "";
                    textBoxEmail.Text = "";

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
            if (textBoxIDdel.Text!="")
            {

                try
                {

                    string query = "delete from users where UserID=" + textBoxIDdel.Text+ ";";

                    SqlCommand command = new SqlCommand(query, conection);
                    command.ExecuteNonQuery();
                    load();

                    textBoxUserID.Text = "";
                    textBoxUserName.Text = "";
                    textBoxPassword.Text = "";
                    textBoxRoleID.Text = "";
                    textBoxFn.Text = "";
                    textBoxLn.Text = "";
                    textBoxEmail.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else MessageBox.Show("Delete Field IDs empty");

        }
    }
}

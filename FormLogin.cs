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
using System.IO;
using System.Collections;

namespace VScanApp
{
    public partial class FormLogin : Form
    {

        public SqlConnection conection;

        public FormLogin()
        {
            InitializeComponent();
            StreamReader objReader = new StreamReader("db.txt");
            string sLine = "";
            sLine = objReader.ReadLine();

            
            conection = new SqlConnection(sLine);            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {

                if (textBox1.Text != "" && textBox2.Text != "")
                {

                    conection.Open();


                    string user = textBox1.Text;
                    string password = textBox2.Text;
                    string query = "select UserID,RoleID from users where UserName='"+user+ "' and  UserPassword='"+ password + "';";

                    SqlCommand command = new SqlCommand(query, conection);
                    SqlDataReader data = command.ExecuteReader();
                    if (data.Read())
                    {
                       

                        FormMain m = new FormMain();
                        m.ShowDialog();
                        conection.Close();
                        textBox1.Text = "";
                        textBox2.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Invalid user or password");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        conection.Close();

                    }

                }
                else
                {
                    MessageBox.Show("Please Inser user and password values");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }




        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using MetroFramework;
using System.Windows.Forms;

namespace r_ServiceApp_Beta_V._1._2
{
    public partial class W_Register : MetroForm
    {
        public W_Register()
        {
            InitializeComponent();
        }
        SqlCommand PerintahSql = new SqlCommand();

        private void TexClear()
        {
            TxtNumber.Clear();
            TxtUsername.Clear();
            txtEmail.Clear();
            txtNoPhone.Clear();
            txtPassword.Clear();
        }

        W_Login bn = new W_Login();
        private void Pregister_Click(object sender, EventArgs e)
        {
            bn.Show();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            connectionSetting.OpenConnection();
            PerintahSql = new SqlCommand(@"INSERT INTO tb_Register([No],[Username],[Password],[Email],[No_Phone])
            VALUES(" + TxtNumber.Text + ",'" + TxtUsername.Text + "','" + txtPassword.Text + "','" + txtEmail.Text + "'," + txtNoPhone.Text + ")", connectionSetting.CON);
            PerintahSql.ExecuteNonQuery();
            TexClear();
            if (PerintahSql.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Data Succes Register");
                this.Visible = true;
                bn.Visible = false;
                

            }
            else

            {
                MessageBox.Show("Data Failed Register");
            }
            connectionSetting.CloseConnection();                 
            
           
        }

        private void W_Register_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

      
    }
}

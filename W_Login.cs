using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;



using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Common;

using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Fonts;
using MetroFramework.Components;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace r_ServiceApp_Beta_V._1._2
{
    public partial class W_Login : MetroForm
    {
        public W_Login()
        {
            Thread t = new Thread(new ThreadStart(Loading));
            t.Start();
            InitializeComponent();
            for (int i = 0; i <= 1000; i++)
                Thread.Sleep(10);
            t.Abort();
        }
        SqlCommand PerintahSql = new SqlCommand();
        private void Loading()
        {
            W_SplashScreen frm = new W_SplashScreen();
            Application.Run(frm);
        }

        private void  clear()
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
        }
        SqlCommand CMD = new SqlCommand();

        private void W_Login_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            connectionSetting.OpenConnection();
            SqlCommand CMD = new SqlCommand("SELECT * FROM tb_Account WHERE [Username]='"+txtUsername.Text+ "' AND [Password]='"+txtPassword.Text+"'", connectionSetting.CON);
            SqlDataReader dr;
            dr = CMD.ExecuteReader();
            int Counnt = 0;
            while (dr.Read())
            {
                Counnt += 1;
            }

            if (Counnt == 1)
            {
               
                MessageBox.Show("USERNAME AND PASSWORD MATCH");
                W_ControlPanel bs = new W_ControlPanel();
                bs.Show();
            }
            else if (Counnt > 0)
            {
                MessageBox.Show("USER DUPLICATED");
            }
            else 
            {
                MessageBox.Show("CHECK AGAIN USERNAMA OR PASSWORD ARE MATCHING");
            }
            connectionSetting.CloseConnection();
            clear();          
         
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
          

            DialogResult dr = MetroMessageBox.Show(this, "\n\nContinue To Exit Application?", "LOGIN MODULE | LOG OUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Ok, Here we go");
            }
        }

        private void lRegister_Click(object sender, EventArgs e)
        {
          
            this.Visible = true;
            W_Register bnd = new W_Register();
            bnd.Show();
            //OnClientClick = "this.disabled='true';return true;"


        }
    }       
}

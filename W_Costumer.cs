using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Drawing;
using MetroFramework.Components;
using System.Data.Common;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using MetroFramework;

namespace r_ServiceApp_Beta_V._1._2
{
    public partial class W_Costumer : MetroForm
    {
        public W_Costumer()
        {
            InitializeComponent();
        }

        SqlCommand PerintahSql = new SqlCommand();

        private void SelectPangilHapus()
        {
            connectionSetting.OpenConnection();
            PerintahSql = new SqlCommand("DELETE tb_Costumer WHERE [No]='" + CostTxtNo.Text + "'",connectionSetting.CON);
            PerintahSql.ExecuteNonQuery();
            connectionSetting.CloseConnection();
            BersihkanTextbox();
            SelectPangilDatabase();
        }

        private void SelectPangilTambah()
        {
            connectionSetting.OpenConnection();
            PerintahSql = new SqlCommand(@"INSERT INTO tb_Costumer([No],[Nama],[Address],[Phone_Number],[Email])
            VALUES('" + CostTxtNo.Text + "','" + CostTxtNane.Text + "','" + CostTxtAddres.Text + "', '" + CostTxtNumber.Text + "','" + CostTxtEmail.Text + "')", connectionSetting.CON);
            PerintahSql.ExecuteNonQuery();

            BersihkanTextbox();

            if (PerintahSql.ExecuteNonQuery() < 1)
            {
                MessageBox.Show("Your data succes add to database,thank you");

            }
            else
            {
                DialogResult dr = MetroMessageBox.Show(this, "\n\nData Not Fill?", "ERROR MODULE | BE PATIENCE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }             
            
            connectionSetting.CloseConnection();
            SelectPangilDatabase();
            // if (PerintahSql.ExecuteNonQuery() > 0)
            //    {
            //     MessageBox.Show("YOUR DATA SUCCESS ADD TO DATABASE,THANK YOU!");

            //  }
            // else
            //   {

            //  }
        }

        private void SelectPangilUbah()
        {
            PerintahSql = new SqlCommand("UPDATE tb_Costumer SET [Nama]=@nama,[Address]=@addres,[Phone_Number]=@phoneNumber,[Email]=@email WHERE [No]=@nomor ", connectionSetting.CON);
            connectionSetting.OpenConnection();
            PerintahSql.Parameters.AddWithValue("@nomor", CostTxtNo.Text);
            PerintahSql.Parameters.AddWithValue("@nama", CostTxtNane.Text);
            PerintahSql.Parameters.AddWithValue("@addres", CostTxtAddres.Text);
            PerintahSql.Parameters.AddWithValue("@phoneNumber", CostTxtNumber.Text);
            PerintahSql.Parameters.AddWithValue("@email", CostTxtEmail.Text);
            PerintahSql.ExecuteNonQuery();
            connectionSetting.CloseConnection();
            BersihkanTextbox();
            SelectPangilDatabase();
        }
        private void SelectPangilDatabase()
        {
            connectionSetting.OpenConnection();
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM tb_Costumer", connectionSetting.CON);
            DataTable DATA = new DataTable();
            SDA.Fill(DATA);
            CostDgv.DataSource = DATA;
            connectionSetting.CloseConnection();

        }
        private void W_Costumer_Load(object sender, EventArgs e)
        {
            SelectPangilDatabase();
        }
        private void BersihkanTextbox()
        {
            CostTxtNo.Text = "";
            CostTxtNane.Text = "";
            CostTxtAddres.Text = "";
            CostTxtNumber.Text = "";
            CostTxtEmail.Text = "";
        }
        private void CostDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CostTxtNo.Text = CostDgv.SelectedRows[0].Cells["No"].Value.ToString();
            CostTxtNane.Text = CostDgv.SelectedRows[0].Cells["Nama"].Value.ToString();
            CostTxtAddres.Text = CostDgv.SelectedRows[0].Cells["Address"].Value.ToString();
            CostTxtNumber.Text = CostDgv.SelectedRows[0].Cells["Phone_Number"].Value.ToString();
            CostTxtEmail.Text = CostDgv.SelectedRows[0].Cells["Email"].Value.ToString();
        }
        private void CosPdelete_Click(object sender, EventArgs e)
        {
            SelectPangilHapus();
        }
        private void CosPsave_Click(object sender, EventArgs e)
        {
            SelectPangilTambah();
        }
        private void CosbtnDelete_Click(object sender, EventArgs e)
        {
            SelectPangilHapus();
        }
        private void CosPrefresh_Click(object sender, EventArgs e)
        {
            SelectPangilDatabase();
        }
        private void CosbtnRefresh_Click(object sender, EventArgs e)
        {
            SelectPangilDatabase();
        }
        private void CosbtnSave_Click(object sender, EventArgs e)
        {
            SelectPangilTambah();
        }

        private void CosbtnEddit_Click(object sender, EventArgs e)
        {
            SelectPangilUbah();
        }
        private void CosPedit_Click(object sender, EventArgs e)
        {
            SelectPangilUbah();
        }
        private void metroTextBox5_Click(object sender, EventArgs e)
        {
          
        }

        private void CostTxtNane_Click(object sender, EventArgs e)
        {
            
        }

        private void CostTxtAddres_Click(object sender, EventArgs e)
        {
          

        }

        private void CostTxtNumber_Click(object sender, EventArgs e)
        {
            
        }

      
    }
}

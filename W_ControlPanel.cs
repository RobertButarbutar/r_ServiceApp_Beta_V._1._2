using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;



//this system using for database required
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;


//this system using for component library for form
using MetroFramework.Forms;
using MetroFramework.Fonts;
using MetroFramework.Components;
//end system for using add or partical


namespace r_ServiceApp_Beta_V._1._2
{
    public partial class W_ControlPanel : MetroForm
    {
        //system form here
       // W_ControlPanel cp = new W_ControlPanel();

        public W_ControlPanel()
        {
            InitializeComponent();
        }
        private void mProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            W_Product hj = new W_Product();
            hj.Show();
        }

        private void W_ControlPanel_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void Pexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            W_Login bj = new W_Login();
            bj.Show();


           
          
            
        }

       
    }
}

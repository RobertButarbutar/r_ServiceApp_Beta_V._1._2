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
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace r_ServiceApp_Beta_V._1._2
{
    public partial class W_Product : MetroForm
    {
        public W_Product()
        {
            InitializeComponent();
        }

        private void W_Product_Load(object sender, EventArgs e)
        {

        }

        private void Pexit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Oracletry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // create connection
                  OracleConnection con = new OracleConnection();
                 con.ConnectionString = "User Id=sys;Password =1234SYS;DBA Privilege=SYSDBA; Data Source = (DESCRIPTION =" +
    "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
   " (CONNECT_DATA =" +
     " (SERVER = DEDICATED)" +
      "(SERVICE_NAME = orcl)" +
   " )" +
 "  )";
          
                con.Open();
                MessageBox.Show("p");
                OracleCommand cmd = new OracleCommand("SELECT * from Table_1", con);
                var reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                dataGridView1.DataSource = table;
                con.Close();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

           
        }
    }
}

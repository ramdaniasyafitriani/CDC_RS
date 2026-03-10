using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AkademikADOApp
{
    public partial class Form1 : Form
    {
        // Connection  string
        string connString = "Data Source=LAPTOP-M4FI536S\\RAMDANIAA;Initial Catalog=DBAkademikADO;Integrated Security=True";

        //Object SQL Connection
        SqlConnection conn;

        public Form1()
        {

            InitializeComponent();

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connString);

                conn.Open();

                lblStatus.Text = "Status : Database Connected";

                MessageBox.Show("Koneksi ke database berhasil!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal : " + ex.Message);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}





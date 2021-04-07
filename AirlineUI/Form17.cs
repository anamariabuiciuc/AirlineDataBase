using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    public partial class AdminSumaTotala : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4EV01H0\SQLEXPRESS;Initial Catalog=companieaeriana;Integrated Security=True");

        public AdminSumaTotala()
        {
            InitializeComponent();
            populate();
        }

        private void populate()
        {
            String queryString = " SELECT  Id_client, SUM(Pret) 'Suma totala (lei)'  FROM Rezervare GROUP BY Id_client HAVING SUM(Pret) >= '" + textBox1.Text + "' ";
            SqlCommand cmd = new SqlCommand(queryString, con);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void AdminSumaTotala_Load(object sender, EventArgs e)
        {

        }
    }
}

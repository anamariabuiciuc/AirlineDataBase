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
    public partial class AdminZbor : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4EV01H0\SQLEXPRESS;Initial Catalog=companieaeriana;Integrated Security=True");


        public AdminZbor()
        {
            InitializeComponent();
        }

        private void zborBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zborBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.companieaerianaDataSet6);

        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companieaerianaDataSet6.Zbor' table. You can move, or remove it, as needed.
            this.zborTableAdapter.Fill(this.companieaerianaDataSet6.Zbor);
            comboBox_zboruri();
            comboBox_zboruri_ordine();
            Load_zboruri();
        }

        private void comboBox_zboruri()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Id_zbor");
            comboBox1.Items.Add("Id_aeronava");
            comboBox1.Items.Add("Id_ruta");
            comboBox1.Items.Add("Data_zbor");
        }

        private void comboBox_zboruri_ordine()
        {
            comboBox2.Items.Clear();
            comboBox2.Items.Add("Ascendent");
            comboBox2.Items.Add("Descendent");
        }

        private void Load_zboruri()
        {

            String queryString = "SELECT * FROM Zbor ORDER BY Id_aeronava";
            SqlCommand cmd = new SqlCommand(queryString, con);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            zborDataGridView.DataSource = dt;
            con.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String queryString = "SELECT * FROM Zbor ORDER BY " + comboBox1.SelectedItem.ToString();
            SqlCommand cmd = new SqlCommand(queryString, con);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            zborDataGridView.DataSource = dt;
            con.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String ord;

            if (comboBox2.SelectedIndex == 0) ord = "asc";
            else ord = "desc";

            if (comboBox1.SelectedIndex >= 0)
            {
                String queryString = "SELECT * FROM Zbor ORDER BY " + comboBox1.SelectedItem.ToString() + " " + ord;
                SqlCommand cmd = new SqlCommand(queryString, con);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                zborDataGridView.DataSource = dt;
                con.Close();
            }
        }

        private void buttonCautareZbor_Click(object sender, EventArgs e)
        {

            AdminQueryZbor frm = new AdminQueryZbor();
            frm.Show();
           
        }
    }
}

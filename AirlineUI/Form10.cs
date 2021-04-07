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

    public partial class AdminAeronave : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4EV01H0\SQLEXPRESS;Initial Catalog=companieaeriana;Integrated Security=True");


        public AdminAeronave()
        {
            InitializeComponent();
        }

        private void aeronavaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aeronavaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.companieaerianaDataSet2);

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companieaerianaDataSet2.Aeronava' table. You can move, or remove it, as needed.
            this.aeronavaTableAdapter.Fill(this.companieaerianaDataSet2.Aeronava);
            comboBox_aeronave();
            comboBox_aeronave_ordine();
            Load_aeronave();


        }

        private void aeronavaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox_aeronave()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Id_aeronava");
            comboBox1.Items.Add("Nume_aeronava");
            comboBox1.Items.Add("Nr_locuri");
        }

        private void comboBox_aeronave_ordine()
        {
            comboBox2.Items.Clear();
            comboBox2.Items.Add("Ascendent");
            comboBox2.Items.Add("Descendent");
        }

        private void Load_aeronave()
        {

            String queryString = "SELECT * FROM Aeronava ORDER BY Id_aeronava";
            SqlCommand cmd = new SqlCommand(queryString, con);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            aeronavaDataGridView.DataSource = dt;
            con.Close();

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String queryString = "SELECT * FROM Aeronava ORDER BY " + comboBox1.SelectedItem.ToString();
            SqlCommand cmd = new SqlCommand(queryString, con);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            aeronavaDataGridView.DataSource = dt;
            con.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String ord;

            if (comboBox2.SelectedIndex == 0) ord = "asc";
            else ord = "desc";

            if (comboBox1.SelectedIndex >= 0)
            {
                String queryString = "SELECT * FROM Aeronava ORDER BY " + comboBox1.SelectedItem.ToString() + " " + ord;
                SqlCommand cmd = new SqlCommand(queryString, con);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                aeronavaDataGridView.DataSource = dt;
                con.Close();
            }
        }
    }
}

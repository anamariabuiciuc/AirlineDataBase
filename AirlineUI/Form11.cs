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
    public partial class AdminPiloti : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4EV01H0\SQLEXPRESS;Initial Catalog=companieaeriana;Integrated Security=True");

        public AdminPiloti()
        {
            InitializeComponent();
        }

        private void pilotBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pilotBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.companieaerianaDataSet3);

        }

        private void AdminPiloti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companieaerianaDataSet3.Pilot' table. You can move, or remove it, as needed.
            this.pilotTableAdapter.Fill(this.companieaerianaDataSet3.Pilot);
            ComboBox_piloti();
            ComboBox_piloti_ordine();
            Load_piloti();

        }

        private void pilotiDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ComboBox_piloti()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Id_pilot");
            comboBox1.Items.Add("Id_aeronava");
            comboBox1.Items.Add("Nume");
            comboBox1.Items.Add("Gen");
            comboBox1.Items.Add("Data_nastere");
            comboBox1.Items.Add("Data_angajare");
        }

        private void ComboBox_piloti_ordine()
        {
            comboBox2.Items.Clear();
            comboBox2.Items.Add("Ascendent");
            comboBox2.Items.Add("Descendent");

        }

        private void Load_piloti()
        {

            String queryString = "SELECT * FROM Pilot ORDER BY Id_pilot";
            SqlCommand cmd = new SqlCommand(queryString, con);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            pilotDataGridView.DataSource = dt;
            con.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            String queryString = "SELECT * FROM Pilot ORDER BY " + comboBox1.SelectedItem.ToString();
            SqlCommand cmd = new SqlCommand(queryString, con);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            pilotDataGridView.DataSource = dt;
            con.Close();
        }

      

        private void genLabel1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            String ord;

            if (comboBox2.SelectedIndex == 0) ord = "asc";
            else ord = "desc";

            if (comboBox1.SelectedIndex >= 0)
            {
                String queryString = "SELECT * FROM Pilot ORDER BY " + comboBox1.SelectedItem.ToString() + " " + ord;
                SqlCommand cmd = new SqlCommand(queryString, con);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                pilotDataGridView.DataSource = dt;
                con.Close();
            }
        }
    }
}

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
    public partial class AdminAeroport : Form


    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4EV01H0\SQLEXPRESS;Initial Catalog=companieaeriana;Integrated Security=True");



        public AdminAeroport()
        {
            InitializeComponent();
        }

        private void aeroportBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aeroportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.companieaerianaDataSet4);

        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companieaerianaDataSet4.Aeroport' table. You can move, or remove it, as needed.
            this.aeroportTableAdapter.Fill(this.companieaerianaDataSet4.Aeroport);
            comboBox_aeroporturi();
            comboBox_aeroporturi_ordine();
            Load_aeroporturi();

        }

        private void comboBox_aeroporturi()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Cod_aeroport");
            comboBox1.Items.Add("Nume_aeroport");
            comboBox1.Items.Add("Tara");
            comboBox1.Items.Add("Regiune");

        }

        private void comboBox_aeroporturi_ordine()
        {
            comboBox2.Items.Clear();
            comboBox2.Items.Add("Ascendent");
            comboBox2.Items.Add("Descendent");
        }

        private void Load_aeroporturi()
        {

            String queryString = "SELECT * FROM Aeroport ORDER BY Cod_aeroport";
            SqlCommand cmd = new SqlCommand(queryString, con);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            aeroportDataGridView.DataSource = dt;
            con.Close();

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String queryString = "SELECT * FROM Aeroport ORDER BY " + comboBox1.SelectedItem.ToString();
            SqlCommand cmd = new SqlCommand(queryString, con);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            aeroportDataGridView.DataSource = dt;
            con.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String ord;

            if (comboBox2.SelectedIndex == 0) ord = "asc";
            else ord = "desc";

            if (comboBox1.SelectedIndex >= 0)
            {
                String queryString = "SELECT * FROM Aeroport ORDER BY " + comboBox1.SelectedItem.ToString() + " " + ord;
                SqlCommand cmd = new SqlCommand(queryString, con);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                aeroportDataGridView.DataSource = dt;
                con.Close();
            }
        }

        
    }
    
}


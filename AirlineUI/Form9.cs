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
    public partial class AdminBilete : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4EV01H0\SQLEXPRESS;Initial Catalog=companieaeriana;Integrated Security=True");

        public AdminBilete()
        {
            InitializeComponent();
        }

        private void biletBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.biletBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.companieaerianaDataSet1);

        }

        private void AdminBilete_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companieaerianaDataSet1.Bilet' table. You can move, or remove it, as needed.
            this.biletTableAdapter.Fill(this.companieaerianaDataSet1.Bilet);
            ComboBox_bilete();
            ComboBox_bilete_ordine();
            Load_bilete();

        }

        private void ComboBox_bilete()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Id_bilet");
            comboBox1.Items.Add("Id_rezervare");
            comboBox1.Items.Add("Id_zbor");
            comboBox1.Items.Add("Tip_bilet");
        }

        private void ComboBox_bilete_ordine()
        {
            comboBox2.Items.Clear();
            comboBox2.Items.Add("Ascendent");
            comboBox2.Items.Add("Descendent");

        }

        private void Load_bilete()
        {

            String queryString = "SELECT * FROM Bilet ORDER BY Id_bilet";
            SqlCommand cmd = new SqlCommand(queryString, con);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            biletDataGridView.DataSource = dt;
            con.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String queryString = "SELECT * FROM Bilet ORDER BY " + comboBox1.SelectedItem.ToString();
            SqlCommand cmd = new SqlCommand(queryString, con);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            biletDataGridView.DataSource = dt;
            con.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String ord;

            if (comboBox2.SelectedIndex == 0) ord = "asc";
            else ord = "desc";

            if (comboBox1.SelectedIndex >= 0)
            {
                String queryString = "SELECT * FROM Bilet ORDER BY " + comboBox1.SelectedItem.ToString() + " " + ord;
                SqlCommand cmd = new SqlCommand(queryString, con);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                biletDataGridView.DataSource = dt;
                con.Close();
            }
        }
    }
}

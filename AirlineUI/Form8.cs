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
    public partial class AdminRezervari : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4EV01H0\SQLEXPRESS;Initial Catalog=companieaeriana;Integrated Security=True");

        public AdminRezervari()
        {
            InitializeComponent();
        }

        private void rezervareBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rezervareBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.companieaerianaDataSet);

        } 

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companieaerianaDataSet.Rezervare' table. You can move, or remove it, as needed.
            this.rezervareTableAdapter.Fill(this.companieaerianaDataSet.Rezervare);
            ComboBox_rezervari();
            ComboBox_rezervari_ordine();
            Load_rezervari();

        }



        private void ComboBox_rezervari()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Id_rezervare");
            comboBox1.Items.Add("Id_client");
            comboBox1.Items.Add("Data_achizitie");
            comboBox1.Items.Add("Metoda_achizitie");
            comboBox1.Items.Add("Pret");

        }

        private void ComboBox_rezervari_ordine()
        {
            comboBox2.Items.Clear();
            comboBox2.Items.Add("Ascendent");
            comboBox2.Items.Add("Descendent");

        }

        private void Load_rezervari()
        {

            String queryString = "SELECT * FROM Rezervare ORDER BY Id_rezervare";
            SqlCommand cmd = new SqlCommand(queryString, con);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            rezervareDataGridView.DataSource = dt;
            con.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            String queryString = "SELECT * FROM Rezervare ORDER BY Id_rezervare";
            SqlCommand cmd = new SqlCommand(queryString, con);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            rezervareDataGridView.DataSource = dt;
            con.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String ord;

            if (comboBox2.SelectedIndex == 0) ord = "asc";
            else ord = "desc";

            if (comboBox1.SelectedIndex >= 0)
            {
                String queryString = "SELECT * FROM Rezervare ORDER BY " + comboBox1.SelectedItem.ToString() + " " + ord;
                SqlCommand cmd = new SqlCommand(queryString, con);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                rezervareDataGridView.DataSource = dt;
                con.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rezervareDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void data_achizitieDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rezervareBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}

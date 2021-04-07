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
    public partial class AdminRuta : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4EV01H0\SQLEXPRESS;Initial Catalog=companieaeriana;Integrated Security=True");

        public AdminRuta()
        {
            InitializeComponent();
        }

        private void rutaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rutaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.companieaerianaDataSet5);

        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companieaerianaDataSet5.Ruta' table. You can move, or remove it, as needed.
            this.rutaTableAdapter.Fill(this.companieaerianaDataSet5.Ruta);
            comboBox_rute();
            comboBox_rute_ordine();
            Load_rute();


        }


        private void comboBox_rute()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Id_ruta");
            comboBox1.Items.Add("Cod_plecare");
            comboBox1.Items.Add("Cod_destinatie");
        }

        private void comboBox_rute_ordine()
        {
            comboBox2.Items.Clear();
            comboBox2.Items.Add("Ascendent");
            comboBox2.Items.Add("Descendent");
        }

        private void Load_rute()
        {

            String queryString = "SELECT * FROM Ruta ORDER BY Id_ruta";
            SqlCommand cmd = new SqlCommand(queryString, con);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            rutaDataGridView.DataSource = dt;
            con.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            String queryString = "SELECT * FROM Ruta ORDER BY Id_ruta";
            SqlCommand cmd = new SqlCommand(queryString, con);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            rutaDataGridView.DataSource = dt;
            con.Close();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            String ord;

            if (comboBox2.SelectedIndex == 0) ord = "asc";
            else ord = "desc";

            if (comboBox1.SelectedIndex >= 0)
            {
                String queryString = "SELECT * FROM Ruta ORDER BY " + comboBox1.SelectedItem.ToString() + " " + ord;
                SqlCommand cmd = new SqlCommand(queryString, con);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                rutaDataGridView.DataSource = dt;
                con.Close();
            }
        }

        private void id_rutaTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

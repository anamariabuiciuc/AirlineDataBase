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
    public partial class RezervarileMele : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4EV01H0\SQLEXPRESS;Initial Catalog=companieaeriana;Integrated Security=True");

        public RezervarileMele()
        {
            InitializeComponent();
            populate();
            populateq();
            populateZboruri();

        }

        private void populate()
        {
            String queryString = " 	SELECT * FROM Rezervare WHERE Id_client = '"+ textBox1.Text +"'";
            SqlCommand cmd = new SqlCommand(queryString, con);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }


        private void populateq()
        {
            String queryString = "  SELECT c.Id_client, c.Nume, c.Prenume, r.Id_rezervare,  b.Id_bilet, b.Id_zbor, u.Cod_plecare, u.Cod_destinatie,b.Nr_loc, b.Tip_bilet, r.Data_achizitie, r.Metoda_achizitie FROM Bilet b JOIN Rezervare r ON r.Id_rezervare = b.Id_rezervare  JOIN Client c ON  r.Id_client = c.Id_client JOIN Zbor z ON z.Id_zbor = b.Id_zbor JOIN Ruta u ON u.Id_ruta = z.Id_ruta WHERE c.Id_client = '"+textBox1.Text+"' AND r.Id_rezervare = '"+textBox2.Text+"' ";
            
            SqlCommand cmd = new SqlCommand(queryString, con);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();

        }

        private void populateZboruri()
        {
            String queryString = "SET DATEFORMAT DMY;SELECT z.Id_zbor, a.Id_aeronava, a.Nume_aeronava, z.Data_zbor, z.Ora_decolare, z.Ora_aterizare, r.Cod_plecare,x.Regiune, x.Tara, r.Cod_destinatie, y.Regiune, y.Tara FROM Zbor z JOIN Aeronava a ON  z.Id_aeronava = a.Id_aeronava JOIN Ruta r ON z.Id_ruta = r.Id_ruta JOIN Aeroport x ON r.Cod_plecare = x.Cod_aeroport JOIN Aeroport  y ON r.Cod_destinatie = y.Cod_aeroport WHERE z.Data_zbor = '"+textBox3.Text+"' and x.Tara = '"+textBox4.Text+"' and y.Tara = '"+textBox5.Text+"'";
            SqlCommand cmd = new SqlCommand(queryString, con);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            con.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RezervarileMele_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companieaerianaDataSet.Rezervare' table. You can move, or remove it, as needed.
            this.rezervareTableAdapter.Fill(this.companieaerianaDataSet.Rezervare);

        }



        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            populateq();
        }

        private void rezervareBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rezervareBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.companieaerianaDataSet);

        }

        private void metoda_achizitieTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void data_achizitieDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            populateZboruri();
        }
    }
}

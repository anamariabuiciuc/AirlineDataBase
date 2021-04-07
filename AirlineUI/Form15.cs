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
    public partial class AdminQueryZbor : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4EV01H0\SQLEXPRESS;Initial Catalog=companieaeriana;Integrated Security=True");

        public AdminQueryZbor()
        {
            InitializeComponent();
            populate();
        }

        private void populate()
        {
            String queryString = "SELECT z.Id_zbor, a.Id_aeronava, a.Nume_aeronava, z.Data_zbor, z.Ora_decolare, z.Ora_aterizare, r.Cod_plecare,x.Regiune,  x.Tara, r.Cod_destinatie, y.Regiune, y.Tara FROM Zbor z JOIN Aeronava a ON  z.Id_aeronava = a.Id_aeronava JOIN Ruta r ON z.Id_ruta = r.Id_ruta JOIN Aeroport x ON r.Cod_plecare = x.Cod_aeroport JOIN Aeroport  y ON r.Cod_destinatie = y.Cod_aeroport WHERE z.Data_zbor <= '"+ textBox2.Text+"' and y.Tara = '"+textBox1.Text+"' ";
            SqlCommand cmd = new SqlCommand(queryString, con);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

      private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           /* String queryString = " SELECT z.Id_zbor, a.Id_aeronava, a.Nume_aeronava, z.Data_zbor, z.Ora_decolare, z.Ora_aterizare, r.Cod_plecare,x.Regiune, x.Tara, r.Cod_destinatie, y.Regiune, y.Tara FROM Zbor z JOIN Aeronava a ON z.Id_aeronava = a.Id_aeronava JOIN Ruta r ON z.Id_ruta = r.Id_ruta JOIN Aeroport x ON r.Cod_plecare = x.Cod_aeroport  JOIN Aeroport  y ON r.Cod_destinatie = y.Cod_aeroport WHERE z.Data_zbor <= " +dateTimePicker1.ToString();
            SqlCommand cmd = new SqlCommand(queryString, con);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            zborDataGridView.DataSource = dt;
            con.Close(); */
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*String queryString = " SELECT z.Id_zbor, a.Id_aeronava, a.Nume_aeronava, z.Data_zbor, z.Ora_decolare, z.Ora_aterizare, r.Cod_plecare,x.Regiune, x.Tara, r.Cod_destinatie, y.Regiune, y.Tara FROM Zbor z JOIN Aeronava a ON z.Id_aeronava = a.Id_aeronava JOIN Ruta r ON z.Id_ruta = r.Id_ruta JOIN Aeroport x ON r.Cod_plecare = x.Cod_aeroport  JOIN Aeroport  y ON r.Cod_destinatie = y.Cod_aeroport WHERE z.Data_zbor <= " + dataTimePicker1.SelectedItem.ToString() "and y.Tara =" + textBox1.SelectedItem.ToString();
            SqlCommand cmd = new SqlCommand(queryString, con);
            SqlCommand cmd = new SqlCommand(queryString, con);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            zborDataGridView.DataSource = dt;
            con.Close();*/
        }

        private void zborBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zborBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.companieaerianaDataSet6);

        }

        private void AdminQueryZbor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companieaerianaDataSet6.Zbor' table. You can move, or remove it, as needed.
            this.zborTableAdapter.Fill(this.companieaerianaDataSet6.Zbor);

        }

        private void buttonCautareZboruri_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

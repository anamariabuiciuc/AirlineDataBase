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
    public partial class SortareClienti : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4EV01H0\SQLEXPRESS;Initial Catalog=companieaeriana;Integrated Security=True");
    

        public SortareClienti()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.companieaerianaClient_ClientNou);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companieaerianaClient_ClientNou.Client' table. You can move, or remove it, as needed.
             this.clientTableAdapter.Fill(this.companieaerianaClient_ClientNou.Client);
            ComboBox_clienti();
            ComboBox_clienti_ordine();
            Load_clienti();
          
            
        }

        private void ComboBox_clienti()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Id_client");
            comboBox1.Items.Add("Nume");
            comboBox1.Items.Add("Data_nasterii");
        }

        private void ComboBox_clienti_ordine()
        {
            comboBox2.Items.Clear();
            comboBox2.Items.Add("Ascendent");
            comboBox2.Items.Add("Descendent");
          
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Load_clienti()
        {
            
            String queryString = "SELECT * FROM Client ORDER BY Id_client";
            SqlCommand cmd = new SqlCommand(queryString, con);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            clientDataGridView.DataSource = dt;
            con.Close();

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String queryString = "SELECT * FROM Client ORDER BY " + comboBox1.SelectedItem.ToString();
            SqlCommand cmd = new SqlCommand(queryString, con);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            clientDataGridView.DataSource = dt;
            con.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String ord;

            if (comboBox2.SelectedIndex == 0) ord = "asc";
            else ord = "desc";

            if(comboBox1.SelectedIndex >= 0)
            {
                String queryString = "SELECT * FROM Client ORDER BY " + comboBox1.SelectedItem.ToString() + " " + ord;
                SqlCommand cmd = new SqlCommand(queryString, con);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                clientDataGridView.DataSource = dt;
                con.Close();
            }
        }

        private void numeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCautareClienti_Click(object sender, EventArgs e)
        {
            AdminSumaTotala frm = new AdminSumaTotala();
            frm.Show();
        }

        private void adresa_mailLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

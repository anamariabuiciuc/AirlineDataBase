using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    public partial class Administrare : Form
    {
        public Administrare()
        {
            InitializeComponent();
        }

        private void buttonAdminClienti_Click(object sender, EventArgs e)
        {
            SortareClienti frm = new SortareClienti();
            frm.Show();
        }

        private void buttonAdminRezervari_Click(object sender, EventArgs e)
        {
            AdminRezervari frm = new AdminRezervari();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminZbor frm = new AdminZbor();
            frm.Show();
        }

        private void buttonAdminBilete_Click(object sender, EventArgs e)
        {
            AdminBilete frm = new AdminBilete();
            frm.Show();
        }

        private void buttonAdminAeronava_Click(object sender, EventArgs e)
        {
          AdminAeronave frm = new AdminAeronave();
            frm.Show();
        }

        private void buttonAdminPiloti_Click(object sender, EventArgs e)
        {
            AdminPiloti frm = new AdminPiloti();
            frm.Show();
        }

        private void Administrare_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdminAeroport_Click(object sender, EventArgs e)
        {
            AdminAeroport frm = new AdminAeroport();
            frm.Show();
        }

        private void buttonAdminRute_Click(object sender, EventArgs e)
        {
            AdminRuta frm = new AdminRuta();
            frm.Show();
        }
    }
}

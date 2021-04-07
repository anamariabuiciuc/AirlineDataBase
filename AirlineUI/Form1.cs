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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            Conectare frm = new Conectare();
            frm.Show();
        }

        private void buttonAdministrator_Click(object sender, EventArgs e)
        {
            Administrare frm = new Administrare();
            frm.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

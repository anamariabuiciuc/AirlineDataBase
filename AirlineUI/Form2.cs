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
    public partial class Conectare : Form
    {
        public Conectare()
        {
            InitializeComponent();
        }

        private void buttonClientNou_Click(object sender, EventArgs e)
        {
            ClientNou frm = new ClientNou();
            frm.Show();
        }

        private void buttonClientExistent_Click(object sender, EventArgs e)
        {
            RezervarileMele frm = new RezervarileMele();
            frm.Show();
        }
    }
}

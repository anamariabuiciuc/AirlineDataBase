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
    public partial class AdministrareClienti : Form
    {
        public AdministrareClienti()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.companieaerianaClient_ClientNou);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companieaerianaClient_ClientNou.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.companieaerianaClient_ClientNou.Client);

        }

        private void id_clientLabel_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdminClienti_Click(object sender, EventArgs e)
        {

        }
    }
}

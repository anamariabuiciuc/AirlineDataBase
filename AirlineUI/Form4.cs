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
    public partial class ClientNou : Form
    {
        public ClientNou()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.companieaerianaClient_ClientNou);

        }

        private void ClientNou_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companieaerianaClient_ClientNou.Client' table. You can move, or remove it, as needed.
           // this.clientTableAdapter.Fill(this.companieaerianaClient_ClientNou.Client);

        }
    }
}

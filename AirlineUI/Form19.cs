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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void rezervareBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rezervareBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.companieaerianaDataSet);

        }

        private void Form19_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companieaerianaDataSet.Rezervare' table. You can move, or remove it, as needed.
            this.rezervareTableAdapter.Fill(this.companieaerianaDataSet.Rezervare);

        }
    }
}

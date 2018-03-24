using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonsAndCodeWizardsGame.Forms
{
    public partial class AddItemToPoolForm : Form
    {
        public bool isClosed;

        public AddItemToPoolForm()
        {
            InitializeComponent();
            this.isClosed = false;
        }

        private void AddItemToPoolCancel_Click(object sender, EventArgs e)
        {
            this.isClosed = true;

            this.Close();
        }

        private void AddItemToPoolSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

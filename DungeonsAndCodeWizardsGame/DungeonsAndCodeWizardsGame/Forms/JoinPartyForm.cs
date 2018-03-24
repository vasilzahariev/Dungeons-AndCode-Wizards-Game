using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DungeonsAndCodeWizardsGame.Models.Characters;

namespace DungeonsAndCodeWizardsGame
{
    public partial class JoinPartyForm : Form
    {
        public bool IsClosed;

        public JoinPartyForm()
        {
            InitializeComponent();
            IsClosed = false;
        }

        private void JoinPartyCancel_Click(object sender, EventArgs e)
        {
            this.IsClosed = true;

            this.Close();
        }

        private void JoinPartySubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

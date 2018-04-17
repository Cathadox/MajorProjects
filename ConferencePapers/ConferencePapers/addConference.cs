using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConferencePapers
{
    public partial class addConference : Form
    {
        public addConference()
        {
            InitializeComponent();
        }
        public Conference Conference{ get; set; }
        private void btnadd_Click(object sender, EventArgs e)
        {
            Conference = new Conference(txtname.Text.Trim(), (int)numyear.Value);
            DialogResult = DialogResult.OK;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Дали сигурно сакате да го откажете додавањето на нова конференција?", "Дали сте сигурни?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void addConference_Load(object sender, EventArgs e)
        {
            numyear.Minimum = 2000;
            numyear.Maximum = 2099;
        }

        private void txtname_Validating(object sender, CancelEventArgs e)
        {
            if(txtname.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtname, "Внесете име!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtname, null);
                e.Cancel = false;
            }
        }
    }
}

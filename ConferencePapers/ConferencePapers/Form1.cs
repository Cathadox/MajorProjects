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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboyear.DropDownStyle = ComboBoxStyle.DropDownList;
            comboyear.Items.Add("Сите");

        }
        addConference form;
        public List<Conference> conf = new List<Conference>();
        private void btnadd_Click(object sender, EventArgs e)
        {
            
            form = new addConference();
            form.ShowDialog();
            if(form.DialogResult == DialogResult.OK)
            {
                conf.Add(form.Conference);
                comboyear.Items.Add(form.Conference.getYear());
            }
            showConference();
        }
        void showConference()
        {
            listconference.Items.Clear();
            if (comboyear.SelectedIndex != -1&& !comboyear.SelectedItem.Equals("Сите"))
            {  foreach (Conference c in conf)
               {
                    if (c.getYear() == (int)comboyear.SelectedItem)
                            listconference.Items.Add(c);
               }
            }
            else
            {
                foreach (Conference c in conf)
                    listconference.Items.Add(c);
            }
        }

        private void comboyear_SelectedIndexChanged(object sender, EventArgs e)
        {
            showConference();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (listconference.SelectedIndex != 1)
            {
                DialogResult r = MessageBox.Show("Дали сигурно сакате да ја избришете конференцијата?", "ОПОМЕНА!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (r == DialogResult.Yes)
                {
                    Conference c = listconference.SelectedItem as Conference;
                    conf.Remove(c);
                    listconference.Items.RemoveAt(listconference.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Немате изберено конференција за бришење", "ОПОМЕНА!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}

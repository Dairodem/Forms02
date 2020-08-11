using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbInactive.Items.Add(txtAdd.Text);
            txtAdd.Text = "";
            txtAdd.Focus();

        }

        private void btnToActive_Click(object sender, EventArgs e)
        {
            lbActive.Items.Add(lbInactive.SelectedItem);
            lbInactive.Items.Remove(lbInactive.SelectedItem);
        }

        private void btnToInactive_Click(object sender, EventArgs e)
        {
            lbInactive.Items.Add(lbActive.SelectedItem);
            lbActive.Items.Remove(lbActive.SelectedItem);

        }
    }
}

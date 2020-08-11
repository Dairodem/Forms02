using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oef2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Naam: {txtNaam.Text},\n" +
                            $"Adres: {txtAdres.Text}.\n " +
                            $"Leeftijd: {numAge.Value}.\n" +
                            $"Geslacht: \n" +
                            $"Provincie: ");
        }
    }
}

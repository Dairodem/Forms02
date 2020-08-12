using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oef5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNewItem.Text != null)
                lbxItemList.Items.Add(txtNewItem.Text);

            txtNewItem.Text = "";
            txtNewItem.Focus();


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbxItemList.SelectedIndex >= 0)
                lbxItemList.Items.RemoveAt(lbxItemList.SelectedIndex);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("ItemsList.txt"))
            {
                for (int i = 0; i < lbxItemList.Items.Count; i++)
                {
                    writer.WriteLine(lbxItemList.Items[i]);

                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            lbxItemList.Items.Clear();

            using (StreamReader reader = new StreamReader("ItemsList.txt"))
            {
                while (!reader.EndOfStream)
                {
                    lbxItemList.Items.Add(reader.ReadLine());
                }

            }

        }
    }
}

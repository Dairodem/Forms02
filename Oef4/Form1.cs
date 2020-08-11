using NotitieBoekje;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oef4
{
    public partial class Form1 : Form
    {
        Notitieboek notitieboekje = new Notitieboek();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            notitieboekje.AddNotitie(txtNewNotesList.Text);


            lbNotesList.Items.Clear();
            for (int i = 0; i < notitieboekje.NotitieLijst.Count; i++)
            {
                lbNotesList.Items.Add(notitieboekje.NotitieLijst[i].Name);
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            notitieboekje.RemoveNotitie(lbNotesList.SelectedIndex);


            lbNotesList.Items.Clear();
            for (int i = 0; i < notitieboekje.NotitieLijst.Count; i++)
            {
                lbNotesList.Items.Add(notitieboekje.NotitieLijst[i].Name);
            }

        }

        private void lbNotesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbNotes.Items.Clear();
            for (int i = 0; i < notitieboekje.NotitieLijst[lbNotesList.SelectedIndex].NotesList.Count; i++)
            {
                lbNotes.Items.Add(notitieboekje.NotitieLijst[lbNotesList.SelectedIndex].NotesList[i]);
            }
        }

        private void btnEnterNote_Click(object sender, EventArgs e)
        {
            notitieboekje.NotitieLijst[lbNotesList.SelectedIndex].Bijschrijven(txtNewNote.Text);
            lbNotes.Items.Clear();
            for (int i = 0; i < notitieboekje.NotitieLijst[lbNotesList.SelectedIndex].NotesList.Count; i++)
            {
                lbNotes.Items.Add(notitieboekje.NotitieLijst[lbNotesList.SelectedIndex].NotesList[i]);
            }
        }

        private void btnLaminate_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnEnterNote.Enabled = false;
            btnRemove.Enabled = false;
            btnLaminate.Enabled = false;
            txtNewNote.Enabled = false;
            txtNewNotesList.Enabled = false;
        }
    }
}

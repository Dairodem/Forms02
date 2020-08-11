namespace Oef4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNotebook = new System.Windows.Forms.Label();
            this.lbNotesList = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbNotes = new System.Windows.Forms.ListBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblAddNote = new System.Windows.Forms.Label();
            this.txtNewNote = new System.Windows.Forms.TextBox();
            this.btnLaminate = new System.Windows.Forms.Button();
            this.btnEnterNote = new System.Windows.Forms.Button();
            this.txtNewNotesList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNotebook
            // 
            this.lblNotebook.AutoSize = true;
            this.lblNotebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotebook.Location = new System.Drawing.Point(13, 13);
            this.lblNotebook.Name = "lblNotebook";
            this.lblNotebook.Size = new System.Drawing.Size(103, 17);
            this.lblNotebook.TabIndex = 0;
            this.lblNotebook.Text = "Notitieboekje";
            // 
            // lbNotesList
            // 
            this.lbNotesList.FormattingEnabled = true;
            this.lbNotesList.ItemHeight = 16;
            this.lbNotesList.Location = new System.Drawing.Point(12, 34);
            this.lbNotesList.Name = "lbNotesList";
            this.lbNotesList.Size = new System.Drawing.Size(151, 244);
            this.lbNotesList.TabIndex = 1;
            this.lbNotesList.SelectedIndexChanged += new System.EventHandler(this.lbNotesList_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(12, 309);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(151, 26);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Voeg notitie toe";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(12, 341);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(151, 26);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Scheur notitie uit";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbNotes
            // 
            this.lbNotes.Enabled = false;
            this.lbNotes.FormattingEnabled = true;
            this.lbNotes.ItemHeight = 16;
            this.lbNotes.Location = new System.Drawing.Point(169, 34);
            this.lbNotes.Name = "lbNotes";
            this.lbNotes.Size = new System.Drawing.Size(270, 244);
            this.lbNotes.TabIndex = 4;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(166, 13);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(55, 17);
            this.lblNote.TabIndex = 5;
            this.lblNote.Text = "Notitie";
            // 
            // lblAddNote
            // 
            this.lblAddNote.AutoSize = true;
            this.lblAddNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNote.Location = new System.Drawing.Point(169, 291);
            this.lblAddNote.Name = "lblAddNote";
            this.lblAddNote.Size = new System.Drawing.Size(91, 17);
            this.lblAddNote.TabIndex = 6;
            this.lblAddNote.Text = "Bijschrijven";
            // 
            // txtNewNote
            // 
            this.txtNewNote.Location = new System.Drawing.Point(172, 311);
            this.txtNewNote.Name = "txtNewNote";
            this.txtNewNote.Size = new System.Drawing.Size(227, 22);
            this.txtNewNote.TabIndex = 7;
            // 
            // btnLaminate
            // 
            this.btnLaminate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaminate.Location = new System.Drawing.Point(252, 337);
            this.btnLaminate.Name = "btnLaminate";
            this.btnLaminate.Size = new System.Drawing.Size(187, 26);
            this.btnLaminate.TabIndex = 8;
            this.btnLaminate.Text = "Lamineren";
            this.btnLaminate.UseVisualStyleBackColor = true;
            this.btnLaminate.Click += new System.EventHandler(this.btnLaminate_Click);
            // 
            // btnEnterNote
            // 
            this.btnEnterNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterNote.Location = new System.Drawing.Point(405, 309);
            this.btnEnterNote.Name = "btnEnterNote";
            this.btnEnterNote.Size = new System.Drawing.Size(34, 26);
            this.btnEnterNote.TabIndex = 9;
            this.btnEnterNote.Text = ">";
            this.btnEnterNote.UseVisualStyleBackColor = true;
            this.btnEnterNote.Click += new System.EventHandler(this.btnEnterNote_Click);
            // 
            // txtNewNotesList
            // 
            this.txtNewNotesList.Location = new System.Drawing.Point(12, 281);
            this.txtNewNotesList.Name = "txtNewNotesList";
            this.txtNewNotesList.Size = new System.Drawing.Size(151, 22);
            this.txtNewNotesList.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 375);
            this.Controls.Add(this.txtNewNotesList);
            this.Controls.Add(this.btnEnterNote);
            this.Controls.Add(this.btnLaminate);
            this.Controls.Add(this.txtNewNote);
            this.Controls.Add(this.lblAddNote);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lbNotes);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbNotesList);
            this.Controls.Add(this.lblNotebook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notitieboekje";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNotebook;
        private System.Windows.Forms.ListBox lbNotesList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lbNotes;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblAddNote;
        private System.Windows.Forms.TextBox txtNewNote;
        private System.Windows.Forms.Button btnLaminate;
        private System.Windows.Forms.Button btnEnterNote;
        private System.Windows.Forms.TextBox txtNewNotesList;
    }
}


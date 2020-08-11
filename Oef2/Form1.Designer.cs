namespace Oef2
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
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.gbSex = new System.Windows.Forms.GroupBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.gbProvincie = new System.Windows.Forms.GroupBox();
            this.rbOvl = new System.Windows.Forms.RadioButton();
            this.rbWvl = new System.Windows.Forms.RadioButton();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.rbAntw = new System.Windows.Forms.RadioButton();
            this.rbLim = new System.Windows.Forms.RadioButton();
            this.rbVbr = new System.Windows.Forms.RadioButton();
            this.rbBxl = new System.Windows.Forms.RadioButton();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.gbSex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.gbProvincie.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNaam
            // 
            this.txtNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaam.Location = new System.Drawing.Point(12, 29);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(263, 30);
            this.txtNaam.TabIndex = 0;
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdres.Location = new System.Drawing.Point(12, 91);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(263, 30);
            this.txtAdres.TabIndex = 1;
            // 
            // gbSex
            // 
            this.gbSex.Controls.Add(this.rbFemale);
            this.gbSex.Controls.Add(this.rbMale);
            this.gbSex.Location = new System.Drawing.Point(12, 198);
            this.gbSex.Name = "gbSex";
            this.gbSex.Size = new System.Drawing.Size(263, 79);
            this.gbSex.TabIndex = 2;
            this.gbSex.TabStop = false;
            this.gbSex.Text = "Geslacht";
            // 
            // numAge
            // 
            this.numAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAge.Location = new System.Drawing.Point(12, 157);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(263, 26);
            this.numAge.TabIndex = 3;
            this.numAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(9, 39);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(56, 21);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "man";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(141, 39);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(66, 21);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "vrouw";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // gbProvincie
            // 
            this.gbProvincie.Controls.Add(this.rbBxl);
            this.gbProvincie.Controls.Add(this.rbVbr);
            this.gbProvincie.Controls.Add(this.rbLim);
            this.gbProvincie.Controls.Add(this.rbAntw);
            this.gbProvincie.Controls.Add(this.rbOvl);
            this.gbProvincie.Controls.Add(this.rbWvl);
            this.gbProvincie.Location = new System.Drawing.Point(12, 283);
            this.gbProvincie.Name = "gbProvincie";
            this.gbProvincie.Size = new System.Drawing.Size(260, 189);
            this.gbProvincie.TabIndex = 4;
            this.gbProvincie.TabStop = false;
            this.gbProvincie.Text = "Provincie";
            // 
            // rbOvl
            // 
            this.rbOvl.AutoSize = true;
            this.rbOvl.Location = new System.Drawing.Point(6, 48);
            this.rbOvl.Name = "rbOvl";
            this.rbOvl.Size = new System.Drawing.Size(137, 21);
            this.rbOvl.TabIndex = 1;
            this.rbOvl.TabStop = true;
            this.rbOvl.Text = "Oost-Vlaanderen";
            this.rbOvl.UseVisualStyleBackColor = true;
            // 
            // rbWvl
            // 
            this.rbWvl.AutoSize = true;
            this.rbWvl.Location = new System.Drawing.Point(6, 21);
            this.rbWvl.Name = "rbWvl";
            this.rbWvl.Size = new System.Drawing.Size(139, 21);
            this.rbWvl.TabIndex = 0;
            this.rbWvl.TabStop = true;
            this.rbWvl.Text = "West-Vlaanderen";
            this.rbWvl.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(18, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Naam";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresse.Location = new System.Drawing.Point(18, 71);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(45, 17);
            this.lblAdresse.TabIndex = 6;
            this.lblAdresse.Text = "Adres";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(18, 137);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(54, 17);
            this.lblAge.TabIndex = 7;
            this.lblAge.Text = "Leeftijd";
            // 
            // rbAntw
            // 
            this.rbAntw.AutoSize = true;
            this.rbAntw.Location = new System.Drawing.Point(6, 75);
            this.rbAntw.Name = "rbAntw";
            this.rbAntw.Size = new System.Drawing.Size(96, 21);
            this.rbAntw.TabIndex = 2;
            this.rbAntw.TabStop = true;
            this.rbAntw.Text = "Antwerpen";
            this.rbAntw.UseVisualStyleBackColor = true;
            // 
            // rbLim
            // 
            this.rbLim.AutoSize = true;
            this.rbLim.Location = new System.Drawing.Point(6, 102);
            this.rbLim.Name = "rbLim";
            this.rbLim.Size = new System.Drawing.Size(80, 21);
            this.rbLim.TabIndex = 3;
            this.rbLim.TabStop = true;
            this.rbLim.Text = "Limburg";
            this.rbLim.UseVisualStyleBackColor = true;
            // 
            // rbVbr
            // 
            this.rbVbr.AutoSize = true;
            this.rbVbr.Location = new System.Drawing.Point(6, 129);
            this.rbVbr.Name = "rbVbr";
            this.rbVbr.Size = new System.Drawing.Size(130, 21);
            this.rbVbr.TabIndex = 4;
            this.rbVbr.TabStop = true;
            this.rbVbr.Text = "Vlaams-Brabant";
            this.rbVbr.UseVisualStyleBackColor = true;
            // 
            // rbBxl
            // 
            this.rbBxl.AutoSize = true;
            this.rbBxl.Location = new System.Drawing.Point(6, 156);
            this.rbBxl.Name = "rbBxl";
            this.rbBxl.Size = new System.Drawing.Size(76, 21);
            this.rbBxl.TabIndex = 5;
            this.rbBxl.TabStop = true;
            this.rbBxl.Text = "Brussel";
            this.rbBxl.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(12, 478);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(260, 41);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Bevestigen";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 529);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.gbProvincie);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.gbSex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oefening2";
            this.gbSex.ResumeLayout(false);
            this.gbSex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.gbProvincie.ResumeLayout(false);
            this.gbProvincie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.GroupBox gbSex;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.GroupBox gbProvincie;
        private System.Windows.Forms.RadioButton rbOvl;
        private System.Windows.Forms.RadioButton rbWvl;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.RadioButton rbBxl;
        private System.Windows.Forms.RadioButton rbVbr;
        private System.Windows.Forms.RadioButton rbLim;
        private System.Windows.Forms.RadioButton rbAntw;
        private System.Windows.Forms.Button btnConfirm;
    }
}


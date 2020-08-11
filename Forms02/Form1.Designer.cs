namespace Forms02
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
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbInactive = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnToActive = new System.Windows.Forms.Button();
            this.lbActive = new System.Windows.Forms.ListBox();
            this.btnToInactive = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(18, 32);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(140, 22);
            this.txtAdd.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(164, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(149, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Toevoegen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbInactive
            // 
            this.lbInactive.FormattingEnabled = true;
            this.lbInactive.ItemHeight = 16;
            this.lbInactive.Location = new System.Drawing.Point(18, 81);
            this.lbInactive.Name = "lbInactive";
            this.lbInactive.Size = new System.Drawing.Size(139, 180);
            this.lbInactive.TabIndex = 2;
            // 
            // btnToActive
            // 
            this.btnToActive.Location = new System.Drawing.Point(163, 130);
            this.btnToActive.Name = "btnToActive";
            this.btnToActive.Size = new System.Drawing.Size(50, 45);
            this.btnToActive.TabIndex = 4;
            this.btnToActive.Text = "=>";
            this.btnToActive.UseVisualStyleBackColor = true;
            this.btnToActive.Click += new System.EventHandler(this.btnToActive_Click);
            // 
            // lbActive
            // 
            this.lbActive.FormattingEnabled = true;
            this.lbActive.ItemHeight = 16;
            this.lbActive.Location = new System.Drawing.Point(219, 82);
            this.lbActive.Name = "lbActive";
            this.lbActive.Size = new System.Drawing.Size(149, 180);
            this.lbActive.TabIndex = 5;
            // 
            // btnToInactive
            // 
            this.btnToInactive.Location = new System.Drawing.Point(163, 181);
            this.btnToInactive.Name = "btnToInactive";
            this.btnToInactive.Size = new System.Drawing.Size(50, 45);
            this.btnToInactive.TabIndex = 6;
            this.btnToInactive.Text = "<=";
            this.btnToInactive.UseVisualStyleBackColor = true;
            this.btnToInactive.Click += new System.EventHandler(this.btnToInactive_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Inactief:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "actief:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 283);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnToInactive);
            this.Controls.Add(this.lbActive);
            this.Controls.Add(this.btnToActive);
            this.Controls.Add(this.lbInactive);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAdd);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbInactive;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnToActive;
        private System.Windows.Forms.ListBox lbActive;
        private System.Windows.Forms.Button btnToInactive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


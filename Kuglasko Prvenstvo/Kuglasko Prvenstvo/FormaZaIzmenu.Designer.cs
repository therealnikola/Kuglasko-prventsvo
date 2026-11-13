namespace KuglaskoPrvenstvo
{
    partial class FormaZaIzmenu
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
            this.components = new System.ComponentModel.Container();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.lblKuglaskiTim = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ImeTxt = new System.Windows.Forms.TextBox();
            this.PrezimeTxt = new System.Windows.Forms.TextBox();
            this.datumRodjenjaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.KuglaskiTimComboBox = new System.Windows.Forms.ComboBox();
            this.izmenaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(31, 42);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(31, 96);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(47, 13);
            this.lblPrezime.TabIndex = 1;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.Location = new System.Drawing.Point(31, 150);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(81, 13);
            this.lblDatumRodjenja.TabIndex = 3;
            this.lblDatumRodjenja.Text = "Datum rodjenja:";
            // 
            // lblKuglaskiTim
            // 
            this.lblKuglaskiTim.AutoSize = true;
            this.lblKuglaskiTim.Location = new System.Drawing.Point(31, 200);
            this.lblKuglaskiTim.Name = "lblKuglaskiTim";
            this.lblKuglaskiTim.Size = new System.Drawing.Size(67, 13);
            this.lblKuglaskiTim.TabIndex = 4;
            this.lblKuglaskiTim.Text = "KuglaskiTim:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ImeTxt
            // 
            this.ImeTxt.Location = new System.Drawing.Point(34, 58);
            this.ImeTxt.Name = "ImeTxt";
            this.ImeTxt.Size = new System.Drawing.Size(100, 20);
            this.ImeTxt.TabIndex = 6;
            // 
            // PrezimeTxt
            // 
            this.PrezimeTxt.Location = new System.Drawing.Point(34, 112);
            this.PrezimeTxt.Name = "PrezimeTxt";
            this.PrezimeTxt.Size = new System.Drawing.Size(100, 20);
            this.PrezimeTxt.TabIndex = 7;
            // 
            // datumRodjenjaDateTimePicker
            // 
            this.datumRodjenjaDateTimePicker.Location = new System.Drawing.Point(34, 166);
            this.datumRodjenjaDateTimePicker.Name = "datumRodjenjaDateTimePicker";
            this.datumRodjenjaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datumRodjenjaDateTimePicker.TabIndex = 8;
            // 
            // KuglaskiTimComboBox
            // 
            this.KuglaskiTimComboBox.FormattingEnabled = true;
            this.KuglaskiTimComboBox.Location = new System.Drawing.Point(34, 217);
            this.KuglaskiTimComboBox.Name = "KuglaskiTimComboBox";
            this.KuglaskiTimComboBox.Size = new System.Drawing.Size(121, 21);
            this.KuglaskiTimComboBox.TabIndex = 9;
            // 
            // izmenaBtn
            // 
            this.izmenaBtn.Location = new System.Drawing.Point(34, 253);
            this.izmenaBtn.Name = "izmenaBtn";
            this.izmenaBtn.Size = new System.Drawing.Size(75, 23);
            this.izmenaBtn.TabIndex = 10;
            this.izmenaBtn.Text = "potvrdi izmenu";
            this.izmenaBtn.UseVisualStyleBackColor = true;
            this.izmenaBtn.Click += new System.EventHandler(this.izmenaBtn_Click);
            // 
            // FormaZaIzmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.izmenaBtn);
            this.Controls.Add(this.KuglaskiTimComboBox);
            this.Controls.Add(this.datumRodjenjaDateTimePicker);
            this.Controls.Add(this.PrezimeTxt);
            this.Controls.Add(this.ImeTxt);
            this.Controls.Add(this.lblKuglaskiTim);
            this.Controls.Add(this.lblDatumRodjenja);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Name = "FormaZaIzmenu";
            this.Text = "Izmena igraca";
            this.Load += new System.EventHandler(this.FormaZaIzmenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblDatumRodjenja;
        private System.Windows.Forms.Label lblKuglaskiTim;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox ImeTxt;
        private System.Windows.Forms.TextBox PrezimeTxt;
        private System.Windows.Forms.DateTimePicker datumRodjenjaDateTimePicker;
        private System.Windows.Forms.ComboBox KuglaskiTimComboBox;
        private System.Windows.Forms.Button izmenaBtn;
    }
}
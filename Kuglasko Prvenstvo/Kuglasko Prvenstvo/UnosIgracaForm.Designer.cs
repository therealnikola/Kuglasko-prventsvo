namespace KuglaskoPrvenstvo
{
    partial class UnosIgracaForm
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
            this.ImeIgracalbl = new System.Windows.Forms.Label();
            this.ImeIgracaTxt = new System.Windows.Forms.TextBox();
            this.PrezimeIgracaTxt = new System.Windows.Forms.TextBox();
            this.PrezimeIgracalbl = new System.Windows.Forms.Label();
            this.DatumRodjenjaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DatumRodjenjalbl = new System.Windows.Forms.Label();
            this.PotvrdaButton = new System.Windows.Forms.Button();
            this.Naslovlbl = new System.Windows.Forms.Label();
            this.KuglaskiTimComboBox = new System.Windows.Forms.ComboBox();
            this.KuglaskiTimlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ImeIgracalbl
            // 
            this.ImeIgracalbl.AutoSize = true;
            this.ImeIgracalbl.Location = new System.Drawing.Point(12, 59);
            this.ImeIgracalbl.Name = "ImeIgracalbl";
            this.ImeIgracalbl.Size = new System.Drawing.Size(56, 13);
            this.ImeIgracalbl.TabIndex = 0;
            this.ImeIgracalbl.Text = "Ime igraca";
            // 
            // ImeIgracaTxt
            // 
            this.ImeIgracaTxt.Location = new System.Drawing.Point(15, 75);
            this.ImeIgracaTxt.Name = "ImeIgracaTxt";
            this.ImeIgracaTxt.Size = new System.Drawing.Size(100, 20);
            this.ImeIgracaTxt.TabIndex = 1;
            // 
            // PrezimeIgracaTxt
            // 
            this.PrezimeIgracaTxt.Location = new System.Drawing.Point(15, 124);
            this.PrezimeIgracaTxt.Name = "PrezimeIgracaTxt";
            this.PrezimeIgracaTxt.Size = new System.Drawing.Size(100, 20);
            this.PrezimeIgracaTxt.TabIndex = 2;
            // 
            // PrezimeIgracalbl
            // 
            this.PrezimeIgracalbl.AutoSize = true;
            this.PrezimeIgracalbl.Location = new System.Drawing.Point(15, 102);
            this.PrezimeIgracalbl.Name = "PrezimeIgracalbl";
            this.PrezimeIgracalbl.Size = new System.Drawing.Size(76, 13);
            this.PrezimeIgracalbl.TabIndex = 3;
            this.PrezimeIgracalbl.Text = "Prezime igraca";
            // 
            // DatumRodjenjaDateTimePicker
            // 
            this.DatumRodjenjaDateTimePicker.Location = new System.Drawing.Point(15, 167);
            this.DatumRodjenjaDateTimePicker.Name = "DatumRodjenjaDateTimePicker";
            this.DatumRodjenjaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DatumRodjenjaDateTimePicker.TabIndex = 4;
            // 
            // DatumRodjenjalbl
            // 
            this.DatumRodjenjalbl.AutoSize = true;
            this.DatumRodjenjalbl.Location = new System.Drawing.Point(12, 151);
            this.DatumRodjenjalbl.Name = "DatumRodjenjalbl";
            this.DatumRodjenjalbl.Size = new System.Drawing.Size(78, 13);
            this.DatumRodjenjalbl.TabIndex = 5;
            this.DatumRodjenjalbl.Text = "Datum rodjenja";
            this.DatumRodjenjalbl.Click += new System.EventHandler(this.DatumRodjenjalbl_Click);
            // 
            // PotvrdaButton
            // 
            this.PotvrdaButton.Location = new System.Drawing.Point(15, 245);
            this.PotvrdaButton.Name = "PotvrdaButton";
            this.PotvrdaButton.Size = new System.Drawing.Size(75, 23);
            this.PotvrdaButton.TabIndex = 6;
            this.PotvrdaButton.Text = "potvrda";
            this.PotvrdaButton.UseVisualStyleBackColor = true;
            this.PotvrdaButton.Click += new System.EventHandler(this.PotvrdaButton_Click);
            // 
            // Naslovlbl
            // 
            this.Naslovlbl.AutoSize = true;
            this.Naslovlbl.Location = new System.Drawing.Point(15, 22);
            this.Naslovlbl.Name = "Naslovlbl";
            this.Naslovlbl.Size = new System.Drawing.Size(123, 13);
            this.Naslovlbl.TabIndex = 7;
            this.Naslovlbl.Text = "UNOS NOVOG IGRACA";
            // 
            // KuglaskiTimComboBox
            // 
            this.KuglaskiTimComboBox.FormattingEnabled = true;
            this.KuglaskiTimComboBox.Location = new System.Drawing.Point(15, 218);
            this.KuglaskiTimComboBox.Name = "KuglaskiTimComboBox";
            this.KuglaskiTimComboBox.Size = new System.Drawing.Size(121, 21);
            this.KuglaskiTimComboBox.TabIndex = 8;
            // 
            // KuglaskiTimlbl
            // 
            this.KuglaskiTimlbl.AutoSize = true;
            this.KuglaskiTimlbl.Location = new System.Drawing.Point(15, 202);
            this.KuglaskiTimlbl.Name = "KuglaskiTimlbl";
            this.KuglaskiTimlbl.Size = new System.Drawing.Size(64, 13);
            this.KuglaskiTimlbl.TabIndex = 9;
            this.KuglaskiTimlbl.Text = "KuglaskiTim";
            // 
            // UnosIgracaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KuglaskiTimlbl);
            this.Controls.Add(this.KuglaskiTimComboBox);
            this.Controls.Add(this.Naslovlbl);
            this.Controls.Add(this.PotvrdaButton);
            this.Controls.Add(this.DatumRodjenjalbl);
            this.Controls.Add(this.DatumRodjenjaDateTimePicker);
            this.Controls.Add(this.PrezimeIgracalbl);
            this.Controls.Add(this.PrezimeIgracaTxt);
            this.Controls.Add(this.ImeIgracaTxt);
            this.Controls.Add(this.ImeIgracalbl);
            this.Name = "UnosIgracaForm";
            this.Text = "UnosIgracaForm";
            this.Load += new System.EventHandler(this.UnosIgracaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ImeIgracalbl;
        private System.Windows.Forms.TextBox ImeIgracaTxt;
        private System.Windows.Forms.TextBox PrezimeIgracaTxt;
        private System.Windows.Forms.Label PrezimeIgracalbl;
        private System.Windows.Forms.DateTimePicker DatumRodjenjaDateTimePicker;
        private System.Windows.Forms.Label DatumRodjenjalbl;
        private System.Windows.Forms.Button PotvrdaButton;
        private System.Windows.Forms.Label Naslovlbl;
        private System.Windows.Forms.ComboBox KuglaskiTimComboBox;
        private System.Windows.Forms.Label KuglaskiTimlbl;
    }
}
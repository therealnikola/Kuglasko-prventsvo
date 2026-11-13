namespace KuglaskoPrvenstvo
{
    partial class TabelarniPrikazIgracaForm
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
            this.igraciDataGridView = new System.Windows.Forms.DataGridView();
            this.Filterlbl = new System.Windows.Forms.Label();
            this.filterTxt = new System.Windows.Forms.TextBox();
            this.potvrdaBtn = new System.Windows.Forms.Button();
            this.prikaziSveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.igraciDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // igraciDataGridView
            // 
            this.igraciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.igraciDataGridView.Location = new System.Drawing.Point(12, 62);
            this.igraciDataGridView.Name = "igraciDataGridView";
            this.igraciDataGridView.Size = new System.Drawing.Size(776, 376);
            this.igraciDataGridView.TabIndex = 0;
            // 
            // Filterlbl
            // 
            this.Filterlbl.AutoSize = true;
            this.Filterlbl.Location = new System.Drawing.Point(12, 37);
            this.Filterlbl.Name = "Filterlbl";
            this.Filterlbl.Size = new System.Drawing.Size(95, 13);
            this.Filterlbl.TabIndex = 1;
            this.Filterlbl.Text = "Filter po prezimenu";
            // 
            // filterTxt
            // 
            this.filterTxt.Location = new System.Drawing.Point(113, 34);
            this.filterTxt.Name = "filterTxt";
            this.filterTxt.Size = new System.Drawing.Size(100, 20);
            this.filterTxt.TabIndex = 2;
            // 
            // potvrdaBtn
            // 
            this.potvrdaBtn.Location = new System.Drawing.Point(219, 34);
            this.potvrdaBtn.Name = "potvrdaBtn";
            this.potvrdaBtn.Size = new System.Drawing.Size(75, 23);
            this.potvrdaBtn.TabIndex = 3;
            this.potvrdaBtn.Text = "potvrda";
            this.potvrdaBtn.UseVisualStyleBackColor = true;
            this.potvrdaBtn.Click += new System.EventHandler(this.potvrdaBtn_Click);
            // 
            // prikaziSveBtn
            // 
            this.prikaziSveBtn.Location = new System.Drawing.Point(300, 34);
            this.prikaziSveBtn.Name = "prikaziSveBtn";
            this.prikaziSveBtn.Size = new System.Drawing.Size(75, 23);
            this.prikaziSveBtn.TabIndex = 4;
            this.prikaziSveBtn.Text = "prikazi sve";
            this.prikaziSveBtn.UseVisualStyleBackColor = true;
            this.prikaziSveBtn.Click += new System.EventHandler(this.prikaziSveBtn_Click);
            // 
            // TabelarniPrikazIgracaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prikaziSveBtn);
            this.Controls.Add(this.potvrdaBtn);
            this.Controls.Add(this.filterTxt);
            this.Controls.Add(this.Filterlbl);
            this.Controls.Add(this.igraciDataGridView);
            this.Name = "TabelarniPrikazIgracaForm";
            this.Text = "TabelarniPrikazIgracaForm";
            ((System.ComponentModel.ISupportInitialize)(this.igraciDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView igraciDataGridView;
        private System.Windows.Forms.Label Filterlbl;
        private System.Windows.Forms.TextBox filterTxt;
        private System.Windows.Forms.Button potvrdaBtn;
        private System.Windows.Forms.Button prikaziSveBtn;
    }
}
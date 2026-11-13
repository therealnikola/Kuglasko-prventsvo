namespace KuglaskoPrvenstvo
{
    partial class Pocetna
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.unosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosNovogIgracaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazIgracaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.KuglaskiIgraciDGV = new System.Windows.Forms.DataGridView();
            this.filterlbl = new System.Windows.Forms.Label();
            this.FilterBtn = new System.Windows.Forms.Button();
            this.PrikazSvihBtn = new System.Windows.Forms.Button();
            this.filterTxt = new System.Windows.Forms.TextBox();
            this.izmenaBtn = new System.Windows.Forms.Button();
            this.BrisanjeBtn = new System.Windows.Forms.Button();
            this.StampaBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KuglaskiIgraciDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem,
            this.prikazToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(897, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // unosToolStripMenuItem
            // 
            this.unosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosNovogIgracaToolStripMenuItem});
            this.unosToolStripMenuItem.Name = "unosToolStripMenuItem";
            this.unosToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.unosToolStripMenuItem.Text = "unos";
            // 
            // unosNovogIgracaToolStripMenuItem
            // 
            this.unosNovogIgracaToolStripMenuItem.Name = "unosNovogIgracaToolStripMenuItem";
            this.unosNovogIgracaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.unosNovogIgracaToolStripMenuItem.Text = "unos novog igraca";
            this.unosNovogIgracaToolStripMenuItem.Click += new System.EventHandler(this.unosNovogIgracaToolStripMenuItem_Click);
            // 
            // prikazToolStripMenuItem
            // 
            this.prikazToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikazIgracaToolStripMenuItem});
            this.prikazToolStripMenuItem.Name = "prikazToolStripMenuItem";
            this.prikazToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.prikazToolStripMenuItem.Text = "prikaz";
            // 
            // prikazIgracaToolStripMenuItem
            // 
            this.prikazIgracaToolStripMenuItem.Name = "prikazIgracaToolStripMenuItem";
            this.prikazIgracaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.prikazIgracaToolStripMenuItem.Text = "prikaz igraca";
            this.prikazIgracaToolStripMenuItem.Click += new System.EventHandler(this.prikazIgracaToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // KuglaskiIgraciDGV
            // 
            this.KuglaskiIgraciDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KuglaskiIgraciDGV.Location = new System.Drawing.Point(265, 86);
            this.KuglaskiIgraciDGV.Name = "KuglaskiIgraciDGV";
            this.KuglaskiIgraciDGV.Size = new System.Drawing.Size(620, 302);
            this.KuglaskiIgraciDGV.TabIndex = 1;
            this.KuglaskiIgraciDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // filterlbl
            // 
            this.filterlbl.AutoSize = true;
            this.filterlbl.Location = new System.Drawing.Point(262, 44);
            this.filterlbl.Name = "filterlbl";
            this.filterlbl.Size = new System.Drawing.Size(95, 13);
            this.filterlbl.TabIndex = 2;
            this.filterlbl.Text = "Filter po prezimenu";
            // 
            // FilterBtn
            // 
            this.FilterBtn.Location = new System.Drawing.Point(371, 57);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Size = new System.Drawing.Size(75, 23);
            this.FilterBtn.TabIndex = 3;
            this.FilterBtn.Text = "potvrdi";
            this.FilterBtn.UseVisualStyleBackColor = true;
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            // 
            // PrikazSvihBtn
            // 
            this.PrikazSvihBtn.Location = new System.Drawing.Point(452, 57);
            this.PrikazSvihBtn.Name = "PrikazSvihBtn";
            this.PrikazSvihBtn.Size = new System.Drawing.Size(75, 23);
            this.PrikazSvihBtn.TabIndex = 4;
            this.PrikazSvihBtn.Text = "prikazi sve";
            this.PrikazSvihBtn.UseVisualStyleBackColor = true;
            this.PrikazSvihBtn.Click += new System.EventHandler(this.PrikazSvihBtn_Click);
            // 
            // filterTxt
            // 
            this.filterTxt.Location = new System.Drawing.Point(265, 60);
            this.filterTxt.Name = "filterTxt";
            this.filterTxt.Size = new System.Drawing.Size(100, 20);
            this.filterTxt.TabIndex = 5;
            // 
            // izmenaBtn
            // 
            this.izmenaBtn.Location = new System.Drawing.Point(162, 86);
            this.izmenaBtn.Name = "izmenaBtn";
            this.izmenaBtn.Size = new System.Drawing.Size(75, 23);
            this.izmenaBtn.TabIndex = 6;
            this.izmenaBtn.Text = "Izmeni";
            this.izmenaBtn.UseVisualStyleBackColor = true;
            this.izmenaBtn.Click += new System.EventHandler(this.izmenaBtn_Click);
            // 
            // BrisanjeBtn
            // 
            this.BrisanjeBtn.Location = new System.Drawing.Point(81, 86);
            this.BrisanjeBtn.Name = "BrisanjeBtn";
            this.BrisanjeBtn.Size = new System.Drawing.Size(75, 23);
            this.BrisanjeBtn.TabIndex = 7;
            this.BrisanjeBtn.Text = "Obrisi";
            this.BrisanjeBtn.UseVisualStyleBackColor = true;
            this.BrisanjeBtn.Click += new System.EventHandler(this.BrisanjeBtn_Click);
            // 
            // StampaBtn
            // 
            this.StampaBtn.Location = new System.Drawing.Point(533, 58);
            this.StampaBtn.Name = "StampaBtn";
            this.StampaBtn.Size = new System.Drawing.Size(75, 23);
            this.StampaBtn.TabIndex = 8;
            this.StampaBtn.Text = "stampaj";
            this.StampaBtn.UseVisualStyleBackColor = true;
            this.StampaBtn.Click += new System.EventHandler(this.StampaBtn_Click);
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 450);
            this.Controls.Add(this.StampaBtn);
            this.Controls.Add(this.BrisanjeBtn);
            this.Controls.Add(this.izmenaBtn);
            this.Controls.Add(this.filterTxt);
            this.Controls.Add(this.PrikazSvihBtn);
            this.Controls.Add(this.FilterBtn);
            this.Controls.Add(this.filterlbl);
            this.Controls.Add(this.KuglaskiIgraciDGV);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Pocetna";
            this.Text = "Kuglasko prvenstvo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KuglaskiIgraciDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosNovogIgracaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikazIgracaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView KuglaskiIgraciDGV;
        private System.Windows.Forms.Label filterlbl;
        private System.Windows.Forms.Button FilterBtn;
        private System.Windows.Forms.Button PrikazSvihBtn;
        private System.Windows.Forms.TextBox filterTxt;
        private System.Windows.Forms.Button izmenaBtn;
        private System.Windows.Forms.Button BrisanjeBtn;
        private System.Windows.Forms.Button StampaBtn;
    }
}


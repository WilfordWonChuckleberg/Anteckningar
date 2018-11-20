namespace Anteckningar
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öppnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaSomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utskriftsformatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skrivUtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avslutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redigeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ångraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klippToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopieraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klistraInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taBortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sökToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sökNästaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ersättToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gåTillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markeraAlltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automatiskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teckenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusfältToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hjälpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visaHjälpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omAnteckningarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(798, 411);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkivToolStripMenuItem,
            this.redigeraToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.visaToolStripMenuItem,
            this.hjälpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arkivToolStripMenuItem
            // 
            this.arkivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nyToolStripMenuItem,
            this.öppnaToolStripMenuItem,
            this.sparaToolStripMenuItem,
            this.sparaSomToolStripMenuItem,
            this.utskriftsformatToolStripMenuItem,
            this.skrivUtToolStripMenuItem,
            this.avslutaToolStripMenuItem});
            this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            this.arkivToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.arkivToolStripMenuItem.Text = "Arkiv";
            // 
            // nyToolStripMenuItem
            // 
            this.nyToolStripMenuItem.Name = "nyToolStripMenuItem";
            this.nyToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.nyToolStripMenuItem.Text = "Ny";
            // 
            // öppnaToolStripMenuItem
            // 
            this.öppnaToolStripMenuItem.Name = "öppnaToolStripMenuItem";
            this.öppnaToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.öppnaToolStripMenuItem.Text = "Öppna";
            this.öppnaToolStripMenuItem.Click += new System.EventHandler(this.öppnaToolStripMenuItem_Click);
            // 
            // sparaToolStripMenuItem
            // 
            this.sparaToolStripMenuItem.Name = "sparaToolStripMenuItem";
            this.sparaToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.sparaToolStripMenuItem.Text = "Spara";
            // 
            // sparaSomToolStripMenuItem
            // 
            this.sparaSomToolStripMenuItem.Name = "sparaSomToolStripMenuItem";
            this.sparaSomToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.sparaSomToolStripMenuItem.Text = "Spara som";
            this.sparaSomToolStripMenuItem.Click += new System.EventHandler(this.sparaSomToolStripMenuItem_Click);
            // 
            // utskriftsformatToolStripMenuItem
            // 
            this.utskriftsformatToolStripMenuItem.Name = "utskriftsformatToolStripMenuItem";
            this.utskriftsformatToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.utskriftsformatToolStripMenuItem.Text = "utskriftsformat";
            // 
            // skrivUtToolStripMenuItem
            // 
            this.skrivUtToolStripMenuItem.Name = "skrivUtToolStripMenuItem";
            this.skrivUtToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.skrivUtToolStripMenuItem.Text = "Skriv ut";
            // 
            // avslutaToolStripMenuItem
            // 
            this.avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            this.avslutaToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.avslutaToolStripMenuItem.Text = "Avsluta";
            // 
            // redigeraToolStripMenuItem
            // 
            this.redigeraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ångraToolStripMenuItem,
            this.klippToolStripMenuItem,
            this.kopieraToolStripMenuItem,
            this.klistraInToolStripMenuItem,
            this.taBortToolStripMenuItem,
            this.sökToolStripMenuItem,
            this.sökNästaToolStripMenuItem,
            this.ersättToolStripMenuItem,
            this.gåTillToolStripMenuItem,
            this.markeraAlltToolStripMenuItem,
            this.tidToolStripMenuItem});
            this.redigeraToolStripMenuItem.Name = "redigeraToolStripMenuItem";
            this.redigeraToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.redigeraToolStripMenuItem.Text = "Redigera";
            // 
            // ångraToolStripMenuItem
            // 
            this.ångraToolStripMenuItem.Name = "ångraToolStripMenuItem";
            this.ångraToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.ångraToolStripMenuItem.Text = "Ångra";
            // 
            // klippToolStripMenuItem
            // 
            this.klippToolStripMenuItem.Name = "klippToolStripMenuItem";
            this.klippToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.klippToolStripMenuItem.Text = "Klipp ut";
            // 
            // kopieraToolStripMenuItem
            // 
            this.kopieraToolStripMenuItem.Name = "kopieraToolStripMenuItem";
            this.kopieraToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.kopieraToolStripMenuItem.Text = "Kopiera";
            // 
            // klistraInToolStripMenuItem
            // 
            this.klistraInToolStripMenuItem.Name = "klistraInToolStripMenuItem";
            this.klistraInToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.klistraInToolStripMenuItem.Text = "Klistra in";
            // 
            // taBortToolStripMenuItem
            // 
            this.taBortToolStripMenuItem.Name = "taBortToolStripMenuItem";
            this.taBortToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.taBortToolStripMenuItem.Text = "Ta bort";
            // 
            // sökToolStripMenuItem
            // 
            this.sökToolStripMenuItem.Name = "sökToolStripMenuItem";
            this.sökToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.sökToolStripMenuItem.Text = "Sök";
            // 
            // sökNästaToolStripMenuItem
            // 
            this.sökNästaToolStripMenuItem.Name = "sökNästaToolStripMenuItem";
            this.sökNästaToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.sökNästaToolStripMenuItem.Text = "sök nästa";
            // 
            // ersättToolStripMenuItem
            // 
            this.ersättToolStripMenuItem.Name = "ersättToolStripMenuItem";
            this.ersättToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.ersättToolStripMenuItem.Text = "Ersätt";
            // 
            // gåTillToolStripMenuItem
            // 
            this.gåTillToolStripMenuItem.Name = "gåTillToolStripMenuItem";
            this.gåTillToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.gåTillToolStripMenuItem.Text = "Gå till...";
            // 
            // markeraAlltToolStripMenuItem
            // 
            this.markeraAlltToolStripMenuItem.Name = "markeraAlltToolStripMenuItem";
            this.markeraAlltToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.markeraAlltToolStripMenuItem.Text = "Markera allt";
            // 
            // tidToolStripMenuItem
            // 
            this.tidToolStripMenuItem.Name = "tidToolStripMenuItem";
            this.tidToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.tidToolStripMenuItem.Text = "Tid/datum";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.automatiskToolStripMenuItem,
            this.teckenToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // automatiskToolStripMenuItem
            // 
            this.automatiskToolStripMenuItem.Name = "automatiskToolStripMenuItem";
            this.automatiskToolStripMenuItem.Size = new System.Drawing.Size(259, 30);
            this.automatiskToolStripMenuItem.Text = "Automatiskt radbyte";
            this.automatiskToolStripMenuItem.Click += new System.EventHandler(this.automatiskToolStripMenuItem_Click);
            // 
            // teckenToolStripMenuItem
            // 
            this.teckenToolStripMenuItem.Name = "teckenToolStripMenuItem";
            this.teckenToolStripMenuItem.Size = new System.Drawing.Size(259, 30);
            this.teckenToolStripMenuItem.Text = "Tecken...";
            // 
            // visaToolStripMenuItem
            // 
            this.visaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusfältToolStripMenuItem});
            this.visaToolStripMenuItem.Name = "visaToolStripMenuItem";
            this.visaToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.visaToolStripMenuItem.Text = "visa";
            this.visaToolStripMenuItem.Click += new System.EventHandler(this.visaToolStripMenuItem_Click);
            // 
            // statusfältToolStripMenuItem
            // 
            this.statusfältToolStripMenuItem.Name = "statusfältToolStripMenuItem";
            this.statusfältToolStripMenuItem.Size = new System.Drawing.Size(169, 30);
            this.statusfältToolStripMenuItem.Text = "Statusfält";
            // 
            // hjälpToolStripMenuItem
            // 
            this.hjälpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visaHjälpToolStripMenuItem,
            this.omAnteckningarToolStripMenuItem});
            this.hjälpToolStripMenuItem.Name = "hjälpToolStripMenuItem";
            this.hjälpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.hjälpToolStripMenuItem.Text = "Hjälp";
            // 
            // visaHjälpToolStripMenuItem
            // 
            this.visaHjälpToolStripMenuItem.Name = "visaHjälpToolStripMenuItem";
            this.visaHjälpToolStripMenuItem.Size = new System.Drawing.Size(235, 30);
            this.visaHjälpToolStripMenuItem.Text = "Visa hjälp";
            // 
            // omAnteckningarToolStripMenuItem
            // 
            this.omAnteckningarToolStripMenuItem.Name = "omAnteckningarToolStripMenuItem";
            this.omAnteckningarToolStripMenuItem.Size = new System.Drawing.Size(235, 30);
            this.omAnteckningarToolStripMenuItem.Text = "Om Anteckningar";
            this.omAnteckningarToolStripMenuItem.Click += new System.EventHandler(this.omAnteckningarToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öppnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparaSomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utskriftsformatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skrivUtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avslutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redigeraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ångraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klippToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopieraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klistraInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taBortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sökToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sökNästaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ersättToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gåTillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markeraAlltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automatiskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hjälpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teckenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusfältToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visaHjälpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem omAnteckningarToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}


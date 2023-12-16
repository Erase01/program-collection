namespace Programmsammlung
{
    partial class Hauptformular
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eingefügteFormulareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.varablenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.variablenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schleifenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verzweigungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arraysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.methodenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nährungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wurzelwerteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rekusionsverfahrenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem,
            this.eingefügteFormulareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // eingefügteFormulareToolStripMenuItem
            // 
            this.eingefügteFormulareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.varablenToolStripMenuItem,
            this.variablenToolStripMenuItem,
            this.schleifenToolStripMenuItem,
            this.verzweigungenToolStripMenuItem,
            this.arraysToolStripMenuItem,
            this.methodenToolStripMenuItem,
            this.nährungToolStripMenuItem,
            this.rekusionsverfahrenToolStripMenuItem});
            this.eingefügteFormulareToolStripMenuItem.Name = "eingefügteFormulareToolStripMenuItem";
            this.eingefügteFormulareToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.eingefügteFormulareToolStripMenuItem.Text = "Eingefügte_Formulare";
            // 
            // varablenToolStripMenuItem
            // 
            this.varablenToolStripMenuItem.Name = "varablenToolStripMenuItem";
            this.varablenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.varablenToolStripMenuItem.Text = "Variablen";
            this.varablenToolStripMenuItem.Click += new System.EventHandler(this.varablenToolStripMenuItem_Click);
            // 
            // variablenToolStripMenuItem
            // 
            this.variablenToolStripMenuItem.Name = "variablenToolStripMenuItem";
            this.variablenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.variablenToolStripMenuItem.Text = "FormVariablen";
            this.variablenToolStripMenuItem.Click += new System.EventHandler(this.variablenToolStripMenuItem_Click);
            // 
            // schleifenToolStripMenuItem
            // 
            this.schleifenToolStripMenuItem.Name = "schleifenToolStripMenuItem";
            this.schleifenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.schleifenToolStripMenuItem.Text = "Schleifen";
            this.schleifenToolStripMenuItem.Click += new System.EventHandler(this.schleifenToolStripMenuItem_Click);
            // 
            // verzweigungenToolStripMenuItem
            // 
            this.verzweigungenToolStripMenuItem.Name = "verzweigungenToolStripMenuItem";
            this.verzweigungenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verzweigungenToolStripMenuItem.Text = "Verzweigungen";
            this.verzweigungenToolStripMenuItem.Click += new System.EventHandler(this.verzweigungenToolStripMenuItem_Click);
            // 
            // arraysToolStripMenuItem
            // 
            this.arraysToolStripMenuItem.Name = "arraysToolStripMenuItem";
            this.arraysToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arraysToolStripMenuItem.Text = "Arrays";
            this.arraysToolStripMenuItem.Click += new System.EventHandler(this.arraysToolStripMenuItem_Click);
            // 
            // methodenToolStripMenuItem
            // 
            this.methodenToolStripMenuItem.Name = "methodenToolStripMenuItem";
            this.methodenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.methodenToolStripMenuItem.Text = "Methoden";
            this.methodenToolStripMenuItem.Click += new System.EventHandler(this.methodenToolStripMenuItem_Click);
            // 
            // nährungToolStripMenuItem
            // 
            this.nährungToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wurzelwerteToolStripMenuItem});
            this.nährungToolStripMenuItem.Name = "nährungToolStripMenuItem";
            this.nährungToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nährungToolStripMenuItem.Text = "Nährungsverfahren";
            // 
            // wurzelwerteToolStripMenuItem
            // 
            this.wurzelwerteToolStripMenuItem.Name = "wurzelwerteToolStripMenuItem";
            this.wurzelwerteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wurzelwerteToolStripMenuItem.Text = "Wurzelwerte";
            this.wurzelwerteToolStripMenuItem.Click += new System.EventHandler(this.wurzelwerteToolStripMenuItem_Click);
            // 
            // rekusionsverfahrenToolStripMenuItem
            // 
            this.rekusionsverfahrenToolStripMenuItem.Name = "rekusionsverfahrenToolStripMenuItem";
            this.rekusionsverfahrenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rekusionsverfahrenToolStripMenuItem.Text = "Rekusionsverfahren";
            this.rekusionsverfahrenToolStripMenuItem.Click += new System.EventHandler(this.rekusionsverfahrenToolStripMenuItem_Click);
            // 
            // Hauptformular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Hauptformular";
            this.Text = "Hauptformular";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem beendenToolStripMenuItem;
        private ToolStripMenuItem eingefügteFormulareToolStripMenuItem;
        private ToolStripMenuItem varablenToolStripMenuItem;
        private ToolStripMenuItem variablenToolStripMenuItem;
        private ToolStripMenuItem schleifenToolStripMenuItem;
        private ToolStripMenuItem verzweigungenToolStripMenuItem;
        private ToolStripMenuItem arraysToolStripMenuItem;
        private ToolStripMenuItem methodenToolStripMenuItem;
        private ToolStripMenuItem nährungToolStripMenuItem;
        private ToolStripMenuItem wurzelwerteToolStripMenuItem;
        private ToolStripMenuItem rekusionsverfahrenToolStripMenuItem;
    }
}
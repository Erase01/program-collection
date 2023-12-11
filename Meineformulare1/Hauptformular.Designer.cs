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
            menuStrip1 = new MenuStrip();
            beendenToolStripMenuItem = new ToolStripMenuItem();
            eingefügteFormulareToolStripMenuItem = new ToolStripMenuItem();
            varablenToolStripMenuItem = new ToolStripMenuItem();
            variablenToolStripMenuItem = new ToolStripMenuItem();
            schleifenToolStripMenuItem = new ToolStripMenuItem();
            verzweigungenToolStripMenuItem = new ToolStripMenuItem();
            arraysToolStripMenuItem = new ToolStripMenuItem();
            methodenToolStripMenuItem = new ToolStripMenuItem();
            nährungToolStripMenuItem = new ToolStripMenuItem();
            wurzelwerteToolStripMenuItem = new ToolStripMenuItem();
            rekusionsverfahrenToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { beendenToolStripMenuItem, eingefügteFormulareToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // beendenToolStripMenuItem
            // 
            beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            beendenToolStripMenuItem.Size = new Size(65, 20);
            beendenToolStripMenuItem.Text = "Beenden";
            beendenToolStripMenuItem.Click += beendenToolStripMenuItem_Click_1;
            // 
            // eingefügteFormulareToolStripMenuItem
            // 
            eingefügteFormulareToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { varablenToolStripMenuItem, variablenToolStripMenuItem, schleifenToolStripMenuItem, verzweigungenToolStripMenuItem, arraysToolStripMenuItem, methodenToolStripMenuItem, nährungToolStripMenuItem, rekusionsverfahrenToolStripMenuItem });
            eingefügteFormulareToolStripMenuItem.Name = "eingefügteFormulareToolStripMenuItem";
            eingefügteFormulareToolStripMenuItem.Size = new Size(135, 20);
            eingefügteFormulareToolStripMenuItem.Text = "Eingefügte_Formulare";
            // 
            // varablenToolStripMenuItem
            // 
            varablenToolStripMenuItem.Name = "varablenToolStripMenuItem";
            varablenToolStripMenuItem.Size = new Size(180, 22);
            varablenToolStripMenuItem.Text = "Variablen";
            varablenToolStripMenuItem.Click += varablenToolStripMenuItem_Click;
            // 
            // variablenToolStripMenuItem
            // 
            variablenToolStripMenuItem.Name = "variablenToolStripMenuItem";
            variablenToolStripMenuItem.Size = new Size(180, 22);
            variablenToolStripMenuItem.Text = "FormVariablen";
            variablenToolStripMenuItem.Click += variablenToolStripMenuItem_Click;
            // 
            // schleifenToolStripMenuItem
            // 
            schleifenToolStripMenuItem.Name = "schleifenToolStripMenuItem";
            schleifenToolStripMenuItem.Size = new Size(180, 22);
            schleifenToolStripMenuItem.Text = "Schleifen";
            schleifenToolStripMenuItem.Click += schleifenToolStripMenuItem_Click;
            // 
            // verzweigungenToolStripMenuItem
            // 
            verzweigungenToolStripMenuItem.Name = "verzweigungenToolStripMenuItem";
            verzweigungenToolStripMenuItem.Size = new Size(180, 22);
            verzweigungenToolStripMenuItem.Text = "Verzweigungen";
            verzweigungenToolStripMenuItem.Click += verzweigungenToolStripMenuItem_Click;
            // 
            // arraysToolStripMenuItem
            // 
            arraysToolStripMenuItem.Name = "arraysToolStripMenuItem";
            arraysToolStripMenuItem.Size = new Size(180, 22);
            arraysToolStripMenuItem.Text = "Arrays";
            arraysToolStripMenuItem.Click += arraysToolStripMenuItem_Click;
            // 
            // methodenToolStripMenuItem
            // 
            methodenToolStripMenuItem.Name = "methodenToolStripMenuItem";
            methodenToolStripMenuItem.Size = new Size(180, 22);
            methodenToolStripMenuItem.Text = "Methoden";
            methodenToolStripMenuItem.Click += methodenToolStripMenuItem_Click;
            // 
            // nährungToolStripMenuItem
            // 
            nährungToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { wurzelwerteToolStripMenuItem });
            nährungToolStripMenuItem.Name = "nährungToolStripMenuItem";
            nährungToolStripMenuItem.Size = new Size(180, 22);
            nährungToolStripMenuItem.Text = "Nährungsverfahren";
            // 
            // wurzelwerteToolStripMenuItem
            // 
            wurzelwerteToolStripMenuItem.Name = "wurzelwerteToolStripMenuItem";
            wurzelwerteToolStripMenuItem.Size = new Size(180, 22);
            wurzelwerteToolStripMenuItem.Text = "Wurzelwerte";
            wurzelwerteToolStripMenuItem.Click += wurzelwerteToolStripMenuItem_Click;
            // 
            // rekusionsverfahrenToolStripMenuItem
            // 
            rekusionsverfahrenToolStripMenuItem.Name = "rekusionsverfahrenToolStripMenuItem";
            rekusionsverfahrenToolStripMenuItem.Size = new Size(180, 22);
            rekusionsverfahrenToolStripMenuItem.Text = "Rekusionsverfahren";
            rekusionsverfahrenToolStripMenuItem.Click += rekusionsverfahrenToolStripMenuItem_Click;
            // 
            // Hauptformular
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "Hauptformular";
            Text = "Hauptformular";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
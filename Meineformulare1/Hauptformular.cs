namespace Programmsammlung
{
    public partial class Hauptformular : Form
    {
        public Hauptformular()
        {
            InitializeComponent();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void varablenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Variablen var = new Variablen();
            var.MdiParent = this;
            var.Show();

        }

        private void variablenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formvariablen fv = new Formvariablen();
            fv.MdiParent = this;
            fv.Show();
        }

        private void schleifenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Schleifen schleifen = new Schleifen();
            schleifen.MdiParent = this;
            schleifen.Show();
        }

        private void verzweigungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Verzweigungen verzweigungen = new Verzweigungen();
            verzweigungen.MdiParent = this;
            verzweigungen.Show();
        }

        private void arraysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arrays arrays = new Arrays();
            arrays.MdiParent = this;
            arrays.Show();
        }

        private void methodenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Methoden methoden = new Methoden();
            methoden.MdiParent = this;
            methoden.Show();
        }

        private void wurzelwerteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nährungsverfahren_zur_Berechnung_von_Wurzelwerten wurzelwerte = new Nährungsverfahren_zur_Berechnung_von_Wurzelwerten();
            wurzelwerte.MdiParent = this;
            wurzelwerte.Show();
        }

        private void rekusionsverfahrenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rekusionsverfahren rekusion = new Rekusionsverfahren();
            rekusion.MdiParent = this;
            rekusion.Show();
        }

        private void bernoulliVersuchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bernoulli_Versuch bernoulli_Versuch = new Bernoulli_Versuch();
            bernoulli_Versuch.MdiParent = this;
            bernoulli_Versuch.Show();
        }
    }
}
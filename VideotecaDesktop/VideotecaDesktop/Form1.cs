namespace VideotecaDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tipoDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoDocumentos frmTipoDocumentos = new frmTipoDocumentos();
            frmTipoDocumentos.ShowDialog();
        }

        private void génerosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sociosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void películasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
using System.Windows.Forms.Integration;
using DevExpress.Xpf.PdfViewer;

namespace HostedDevExpressViewer
{
    public partial class Form1 : Form
    {
        public PdfViewerControl PdfViewer;

        public Form1()
        {
            InitializeComponent();

            PdfViewer = new PdfViewerControl();

            var elementHost = new ElementHost();

            panel1.Controls.Add(elementHost);

            elementHost.Dock = DockStyle.Fill;
            elementHost.Child = PdfViewer;

            //Put your test file path here
            PdfViewer.OpenDocument(@"FILE 1.pdf");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Put your test file path here
            PdfViewer.OpenDocument(@"FILE 2.pdf");
        }
    }
}
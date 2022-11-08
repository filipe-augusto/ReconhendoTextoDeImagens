using Tesseract;

namespace ReconhendoTextoDeImagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLerImagem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                txt.Text = openFileDialog1.FileName;

            }
            if (!string.IsNullOrWhiteSpace(txt.Text))
            {
                button1.Enabled = true;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var engine = new TesseractEngine(@"tessdata", "por", EngineMode.Default))
            {
                using (var img = Pix.LoadFromFile(txt.Text))
                {
                    using (var page = engine.Process(img))
                    {
                        lblName.Text = page.GetMeanConfidence().ToString();
                        var texto = page.GetText();
                        if (!string.IsNullOrWhiteSpace(texto))
                        {
                            txtLido.Text += texto;
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)  
        {
            Aspose.OMR.Api.OmrEngine omrEngine = new Aspose.OMR.Api.OmrEngine();
            Aspose.OMR.Generation.GenerationResult generationResult = omrEngine.GenerateTemplate("template3.txt");
            generationResult.Save("", "PROVA.OMR");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Aspose.OMR.Api.OmrEngine omrEngine = new Aspose.OMR.Api.OmrEngine();
            Aspose.OMR.Api.TemplateProcessor templateProcessor = omrEngine.GetTemplateProcessor("PROVA.OMR.omr");
            Aspose.OMR.Model.RecognitionResult recognitionResult = templateProcessor.RecognizeImage("asd.png");
            string result = recognitionResult.GetCsv();
            txtLido.Text += "\n" + result;
            Console.WriteLine(result);

        }
    }
}
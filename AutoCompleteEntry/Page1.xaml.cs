using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PdfSharpCore;
using PdfSharp;
using Syncfusion;
using PdfSharp.Xamarin.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Runtime.InteropServices.WindowsRuntime;


namespace AutoCompleteEntry
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1(formulario form1)

        {
            BindingContext = form1;
            InitializeComponent();
            nivel.Text = nivel.Text + form1.nivel;
            for (int i = 0; i < form1.listas21.Count; i++)
            {
                agr.Text = agr.Text + "-" + form1.listas21[i];
                agr.Text = agr.Text + "\n";
            }
            for (int i = 0; i < form1.listas31.Count; i++)
            {
                aptitudes.Text = aptitudes.Text + "-" + form1.listas31[i] + "\n";

            }
            for (int i = 0; i < form1.listas41.Count; i++)
            {
                habilidades.Text = habilidades.Text + "-" + form1.listas41[i] + "\n";

            }
            for (int i = 0; i < form1.listas51.Count; i++)
            {
                experiencia.Text = experiencia.Text + "-" + form1.listas51[i] + "\n";

            }
            for (int i = 0; i < form1.listas61.Count; i++)
            {
                formacion.Text = formacion.Text + "-" + form1.listas61[i] + "\n";

            }








//convierte la hoja en un pdf 
        }
        private async void genera_1(object sender, EventArgs e)
        {
            var pdf = PDFManager.GeneratePDFFromView(maingrid); 
            var basepath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var pdfpath = Path.Combine(basepath, $"/mypdf.pdf");
            pdf.Save(pdfpath);
            try
            {
                await Share.RequestAsync(new ShareFileRequest(new ShareFile(pdfpath)));
            }
            catch
            {

            }
        }
    }
}

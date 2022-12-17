using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
                agr.Text = agr.Text +"-" + form1.listas21[i];
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









        }
    }
}
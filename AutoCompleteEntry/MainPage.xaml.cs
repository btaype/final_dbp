using dotMorten.Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Text;
using System.Threading.Tasks;


namespace AutoCompleteEntry
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    { 
        private List<string> CountriesList;

    
        
        public MainPage()
        {
            
            InitializeComponent();
            GetCountriesFromFile();
        }

        public List<string> listas1=new List<string>();
        public List<string> listas2 = new List<string>();
        public List<string> listas3 = new List<string>();
        public List<string> listas4 = new List<string>();
        public List<string> listas5= new List<string>();

        public string datos;
        public formulario formulario1 { get; set; }
        void ButtonSubmitClicked(object sender, EventArgs e)
        {
            formulario1 = new formulario();
            formulario1.nombre1 = nombre.Text;
            formulario1.nacionalidad1 = nacionalidad.SelectedItem as string;
            formulario1.telf1 = telf.Text;
            formulario1.correo1 = email.Text;
            formulario1.ocupacion1 = ocupacion.Text;
            formulario1.nivel = datos;
            formulario1.perfil = editor.Text;
            formulario1.listas21 = listas1;
            formulario1.listas31 = listas2;
            formulario1.listas41 = listas3;
            formulario1.listas51 = listas4;
            formulario1.listas61 = listas5;


            Application.Current.MainPage.Navigation.PushModalAsync(new Page1(formulario1), true);
          
        }
        private void GetCountriesFromFile()
        {
            using(var country = typeof(MainPage).Assembly.GetManifestResourceStream("AutoCompleteEntry.Data.Countries.txt"))
            {   

                CountriesList = new StreamReader(country).ReadToEnd().Split('\n').Select(t => t.Trim()).ToList();
            }
        }

        private void contryEntry_TextChanged(object sender, AutoSuggestBoxTextChangedEventArgs e)
        {
            AutoSuggestBox input = (AutoSuggestBox)sender;

            input.ItemsSource = GetSuggestions(input.Text);
        }

        private List<string> GetSuggestions(string input)
        {
            return string.IsNullOrWhiteSpace(input) ? null : CountriesList.Where(c => c.StartsWith(input, StringComparison.InvariantCultureIgnoreCase)).ToList();
        }

        private void contryEntry_QuerySubmitted(object sender, AutoSuggestBoxQuerySubmittedEventArgs e)
        {
           
        }
         public void seleccion(object sender,EventArgs args)
        {
            RadioButton rad = sender as RadioButton;
            datos = rad.Content as string;
            


        }
         void agrega2 (object sender, EventArgs e)
        {
            listas2.Add(ap1.Text);
            a.Text = "";
            for(int i = 0; i < listas2.Count; i++)
            {
                a.Text = a.Text + "-" + listas2[i]+"\n";
                
            }
        }
        void quita2(object sender, EventArgs e)
        {
            listas2.Remove(ap2.Text);
            a.Text = "";
            for (int i = 0; i < listas2.Count; i++)
            {
                a.Text = a.Text + "-" + listas2[i] + "\n";

            }
        }
        void agrega3(object sender, EventArgs e)
        {
            listas3.Add(ha1.Text);
            h.Text = "";
            for (int i = 0; i < listas3.Count; i++)
            {
                h.Text = h.Text + "-" + listas3[i] + "\n";

            }
        }
        void quita3(object sender, EventArgs e)
        {
            listas3.Remove(ha2.Text);
            h.Text = "";
            for (int i = 0; i < listas3.Count; i++)
            {
                h.Text = h.Text + "-" + listas3[i] + "\n";

            }
        }
        void agrega4(object sender, EventArgs e)
        {
            listas4.Add(el.Text);
            el3.Text = "";
            for (int i = 0; i < listas4.Count; i++)
            {
                el3.Text = el3.Text + "-" + listas4[i] + "\n";

            }
        }
        void quita4(object sender, EventArgs e)
        {
            listas4.Remove(el1.Text);
            el3.Text = "";
            for (int i = 0; i < listas4.Count; i++)
            {
                el3.Text = el3.Text + "-" + listas4[i] + "\n";

            }
        }
        void agrega5(object sender, EventArgs e)
        {
            listas5.Add(formacion1.Text);
            f.Text = "";
            for (int i = 0; i < listas5.Count; i++)
            {
                f.Text = f.Text + "-" + listas5[i] + "\n";

            }
        }
        void quita5(object sender, EventArgs e)
        {
            listas5.Remove(formacion2.Text);
            f.Text = "";
            for (int i = 0; i < listas5.Count; i++)
            {
                f.Text = f.Text + "-" + listas5[i] + "\n";

            }
        }
        public void  acepta1(object sender,CheckedChangedEventArgs e)
        {
            if (e.Value == true)
            {
                listas1.Add("C++");
            }
            else
            {
                listas1.Remove("C++");
            }
       }
        public void acepta2(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value == true)
            {
                listas1.Add("C#");
            }
            else
            {
                listas1.Remove("C#");
            }
        }
        public void acepta3(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value == true)
            {
                listas1.Add("C");
            }
            else
            {
                listas1.Remove("C");
            }
        }
        public void acepta4(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value == true)
            {
                listas1.Add("Java");
            }
            else
            {
                listas1.Remove("Java");
            }
        }
        public void acepta5(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value == true)
            {
                listas1.Add("JavaScrip");
            }
            else
            {
                listas1.Remove("JavaScrip");
            }
        }
        public void acepta6(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value == true)
            {
                listas1.Add("Python");
            }
            else
            {
                listas1.Remove("Python");
            }
        }
    }
}

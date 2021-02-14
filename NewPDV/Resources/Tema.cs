using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Xaml;
using Util;

namespace NewPDV
{
    public class Tema
    {
        public string CorTema { get; set; }
        public string CorTexto { get; set; }
        public Double TextoTamanho { get; set; }
        public string TextoFonte { get; set; }

        public Tema()
        {
        }

        public bool PegarTemaNoArquivo()
        {
            if (System.IO.File.Exists(Pub.ArquivoTema))
            {
                XMLSerializar xml = new XMLSerializar();
                Tema tm = new Tema();
                tm = (Tema)xml.Deserializar(tm, Pub.ArquivoTema);
                CorTema = tm.CorTema;
                CorTexto = tm.CorTexto;
                TextoFonte = tm.TextoFonte;
                TextoTamanho = tm.TextoTamanho;
                MudarTema();
                return true;
            }
            else
            {
                CorTema = "#4169E1";
                CorTexto = "#FFFFFF";
                TextoTamanho = 12;
                TextoFonte = "Arial";
                MudarTema();
                return true;
            }
        }

        public void GravarTemanoArquivo()
        {
            XMLSerializar serializar = new XMLSerializar();
            Tema tema = new Tema();
            if (CorTexto == null)
            {
                tema.CorTexto = Application.Current.Resources["PadraoTexto"].ToString();
            }
            else
            {
                tema.CorTexto = this.CorTexto;
            }
            if (CorTema == null)
            {
                tema.CorTema = Application.Current.Resources["PadraoBackGround"].ToString();
            }
            else
            {
                tema.CorTema = this.CorTema;
            }
            if (TextoFonte == null)
            {
                tema.TextoFonte = Application.Current.Resources["fonteFamilia"].ToString();
            }
            else
            {
                tema.TextoFonte = this.TextoFonte;
            }
            if (TextoTamanho == 0)
            {
                tema.TextoTamanho = (Double)Application.Current.Resources["FonteTamanho"];
            }
            else
            {
                tema.TextoTamanho = this.TextoTamanho;
            }
            



            XMLSerializar ser = new XMLSerializar();
            ser.Serializar(tema, Pub.ArquivoTema);
        }

        public void MudarTema()
        {
            BrushConverter conv = new BrushConverter();
            System.Windows.Media.Color cor = new System.Windows.Media.Color();
            SolidColorBrush brush2 = null;
            SolidColorBrush brush = null;
            if (CorTema != null)
            {
                brush = conv.ConvertFromString(CorTema) as SolidColorBrush;
                brush2 = conv.ConvertFromString(ReduzirTonalidade(CorTema)) as SolidColorBrush;                
                cor = brush.Color;
            }
            if (TextoFonte != null)
            {
                FontFamily fonte = new FontFamily(TextoFonte);
                Application.Current.Resources["fonteFamilia"] = fonte;
            }

            if (TextoTamanho != 0)
            {
                Application.Current.Resources["FonteTamanho"] = TextoTamanho;
            }

            if (CorTema != "" && CorTema != null)
            {
                Application.Current.Resources["PadraoBackGround"] = brush;
                Application.Current.Resources["PadraoColor"] = cor;
                cor = brush2.Color;
                Application.Current.Resources["PadraoColor2"] = cor;
                Application.Current.Resources["PadraoBackGround2"] = brush2;
            }

            if (CorTexto != "" && CorTexto != null)
            {
                brush = conv.ConvertFromString(CorTexto) as SolidColorBrush;
                Application.Current.Resources["PadraoTexto"] = brush;
            }
            //App.Current.Resources.Source = new Uri("Resources/DictionaryResources.xaml", UriKind.Relative);


            Uri langDictUri = new Uri("Resources/DictionaryResources.xaml", UriKind.Relative);
            var langDict = Application.LoadComponent(langDictUri) as ResourceDictionary;

            //Application.Current.Resources["PadraoBackGround"] = Brushes.White;
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(langDict);

            GravarTemanoArquivo();

        }


        private string ReduzirTonalidade(string backgroundColor)
        {
            System.Drawing.Color color = System.Drawing.ColorTranslator.FromHtml(backgroundColor);
            int r = Convert.ToInt16(color.R);
            int g = Convert.ToInt16(color.G);
            int b = Convert.ToInt16(color.B);

            r = r - ((r * 25) / 100);
            g = g - ((g * 25) / 100);
            b = b - ((b * 25) / 100);

            System.Drawing.Color myColor = System.Drawing.Color.FromArgb(r, g, b);
            string hex = "#" + myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
            return hex;


            //return string.Format("rgba({0}, {1}, {2}, {3});", r, g, b, backgroundOpacity);
        }
    }
}

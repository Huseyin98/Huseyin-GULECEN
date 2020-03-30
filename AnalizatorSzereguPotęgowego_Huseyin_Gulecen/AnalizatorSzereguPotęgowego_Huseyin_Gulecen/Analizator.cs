using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizatorSzereguPotęgowego_Huseyin_Gulecen
{
    public partial class Analizator : Form
    {
        public Analizator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        bool PobierzXorazEps (out float X, out float Eps )
        {
            /* przzepisanie wartosci dla parametrow out gdyz bedziemy korzystali 
              z kontrolki errorProvider*/
            X = Eps = 0.0F;
            // pobranie wartosci zmien niezaleznej X  
            if (!float.TryParse(text_X.Text, out X))
            {
                // zostal wykryty
                errorProvider1.SetError(text_X, "ERROR: Wystapil niedozwolony znak w " +
                    "zapoisie wartosc zmienniej niezaleznej X");
                return false;


            }
            else
                errorProvider1.Dispose();

            ///  tutaj
            // 
            // pobranie wartosci Eps czyli dokladnosci obliczen szeregu 
            if (!float.TryParse(text_EpsSzeregu.Text, out Eps))
            {
                // zostal wykryty blad w zapisie 
                errorProvider1.SetError(text_EpsSzeregu, "ERROR: Wystapil niedozwolony znak w " +
                    "zapoisie wartosc zmienniej niezaleznej Eps");
                return false;


            }
            else
                errorProvider1.Dispose();
            // sprawzienie warunku wejsciowegpo dla Eps 
            if (false)// ((0.0F <=Eps)||(Eps >= 1.0F))
            {
                errorProvider1.SetError(text_EpsSzeregu, "ERROR: Wartosc Eps jest poza zakresem dopuszcalnych wartosci 0.0<Eps<1.0");
                return false;
            }
            return true;

        }
        float SumaSzeregu (float X, float Eps,  out ushort LicznikWyrazowSzeregu)
        {
            //DEKLARACJA UZUPELNIAJACE
            float W, Suma;
            // ustalenie poczatkowego stanu obliczen 
            W = 1.0F;
            LicznikWyrazowSzeregu = 0;
            Suma = 1.0F;
            // iteracyjne obliczenie sumy szeregu potegowego 
            do
            {
                Suma = Suma + W;
                LicznikWyrazowSzeregu++;
                W = W * (-1.0F) * X / LicznikWyrazowSzeregu;
            } while (Math.Abs(W) > Eps);
            return Suma;


        }

        private void btn_Oblizc_Wartosc_szeregu_Click(object sender, EventArgs e)
        {
            // deklaracja dla przechowania pobranych danych wejsciowych 
            float X, Eps;
            ushort n;

            // pobranie danych wejsciowych 
            if (!PobierzXorazEps(out X, out Eps))
                return;//
            //
            text_SZeregu.Text=string.Format("{0:0.000}" , SumaSzeregu(X,Eps, out n));
            text_Licznik_Szeregu.Text = n.ToString();



        }
       
       
        private void button1_Click(object sender, EventArgs e)
        {
            // deklaracja dla przechowanoia pobranch danych wejsciowych 
            float DolnaGranicaCalkolania, GornaGranicaCalkowania, EpsAlkowania;
            float X,Eps;
            // pobranie danych wejsciowych 
            if (!PobierzXorazEps(out X, out Eps))
                return;//
            // pobrania danych wejciowych dla potzeb calkowania 

        }
    }
}

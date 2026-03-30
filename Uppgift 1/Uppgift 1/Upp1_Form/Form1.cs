using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upp1_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            //Detta gör så att när man klickar på avsluta knappen så stänger saken ner.
            this.Close();

        }

        private void change_Click(object sender, EventArgs e)
        {

            //Här omvandlar vi de skrivna värdena till integraler som vi sedan kan använda i
            //programmet. Sedan är det samma som commandkoden.
            int pris, peng;
            pris = Convert.ToInt32(cost.Text);
            peng = Convert.ToInt32(money.Text);

            // Kollar nu utifall man har råd med det genom att kolla om pris är högre än peng.
            // Om inte så meddelar programmet det, annars så fortsätter det som normalt.
            if (pris <= peng)
            {

                // Skapar integern totalt som är resterande pengar efter köpet.
                int totalt = peng - pris;

                Console.WriteLine("Antal Växel:");

                // Räkna ut antalet 500lappar via att dela totalt på 500 och
                // sedan ta bort alla decimaler.
                decimal a = totalt / 500;
                decimal A = Decimal.Truncate(a);

                // Nu konverteras decimalen A till en integer för att kunna ta bort antalet
                // 500lappar från totalt.
                int A1 = Decimal.ToInt32(A);
                totalt -= (A1 * 500);

                // Nu kommer detta upprepas för vardera pengavärde.

                // 200

                decimal b = totalt / 200;
                decimal B = Decimal.Truncate(b);
                int B1 = Decimal.ToInt32(B);
                totalt -= (B1 * 200);

                // 100

                decimal c = totalt / 100;
                decimal C = Decimal.Truncate(c);
                int C1 = Decimal.ToInt32(C);
                totalt -= (C1 * 100);

                // 50

                decimal d = totalt / 50;
                decimal D = Decimal.Truncate(d);
                int D1 = Decimal.ToInt32(D);
                totalt -= (D1 * 50);

                // 20

                decimal r = totalt / 20;
                decimal E = Decimal.Truncate(r);
                int E1 = Decimal.ToInt32(E);
                totalt -= (E1 * 20);

                // 10

                decimal f = totalt / 10;
                decimal F = Decimal.Truncate(f);
                int F1 = Decimal.ToInt32(F);
                totalt -= (F1 * 10);

                // 5

                decimal g = totalt / 5;
                decimal G = Decimal.Truncate(g);
                int G1 = Decimal.ToInt32(G);
                totalt -= (G1 * 5);

                // 2

                decimal h = totalt / 2;
                decimal H = Decimal.Truncate(h);
                int H1 = Decimal.ToInt32(H);
                totalt -= (H1 * 2);

                // 1
                // Vi skippar denna, då det är bara resterande av totalt.

                //För att skriva ut all växel så kollar den först om man fick exakt 1 av den typen av
                //valuta, bara så att man inte skriver "1 femkronor" till exempel. Sedan så kollar
                //den om man har fått någon valuta alls. Det görs i denna ordning då annars hade
                //koden alltid fastnat på att man har fått någon valuta, då 1 är ett antal och skulle
                //därför pricka av den. I vilket fall, om man inte har fått någon valuta så skrivs
                //inget ut.

                //Nu skapar vi en list, som vi sedan lägger in vardera valuta som har ett värde,
                //alltså att vi kollar om man får en tiokrona, och om man gör det, så läggs den
                //på listan för att användas senare.

                List<string> finish = new List<string>();

                //500

                if (A == 1)
                {
                    
                    finish.Add(A + " femhundralapp.");

                }
                else if (A != 0)
                {

                    finish.Add(A + " femhundralappar.");

                }

                // 200

                if (B == 1)
                {

                    finish.Add(B + " tvåhundralapp.");

                }
                else if (B != 0)
                {

                    finish.Add(B + " tvåhundralappar.");

                }

                //100

                if (C == 1)
                {

                    finish.Add(C + " hundralapp.");

                }
                else if (C != 0)
                {

                    finish.Add(C + " hundralappar.");

                }

                //50

                if (D == 1)
                {

                    finish.Add(D + " femtilapp.");

                }
                else if (D != 0)
                {

                    finish.Add(D + " femtilappar.");

                }

                //20

                if (E == 1)
                {

                    finish.Add(E + " tjugolapp.");

                }
                else if (E != 0)
                {

                    finish.Add(E + " tjugolappar.");

                }

                //10

                if (F == 1)
                {

                    finish.Add(F + " tiokrona.");

                }
                else if (F != 0)
                {

                    finish.Add(F + " tiokronor.");

                }

                //5

                if (G == 1)
                {

                    finish.Add(G + " femkrona.");
                }
                else if (G != 0)
                {

                    finish.Add(G + " femkronor.");

                }

                //2

                if (H == 1)
                {

                    finish.Add(H + " tvåkrona.");

                }
                else if (H != 0)
                {

                    finish.Add(H + " tvåkronor.");

                }

                //1

                if (totalt == 1)
                {

                    finish.Add(totalt + " krona.");

                }
                else if (totalt != 0)
                {

                    finish.Add(totalt + " kronor.");

                }

                // Nu skriver vi ut all valuta som man får tillbaks, och lägger till att det är en
                //line break mellan vardera av dom.

                result.Text = string.Join(Environment.NewLine, finish);

            }
            else // if else function för det ovan nämnda om man inte har råd.
            {
               
                result.Text = "Det kostar för mycket, tag med mer pengar nästa gång.";

            }

        }
    }
}

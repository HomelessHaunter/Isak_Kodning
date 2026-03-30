using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {

            // Här överför vi de inskrivna värdena in i ett par variabler så att vi kan använda dom som
            // funktioner till metoden.

            string FNamn = Convert.ToString(FName.Text);
            string ENamn = Convert.ToString(SName.Text);
            string Nummer = Convert.ToString(Number.Text);

            // Här både skapar vi metoden i klassen och skriver sedan in våra värden i den.

            Personnummer svar = new Personnummer();
            svar.CheckPrsn(FNamn, ENamn, Nummer);

            // Här skriver vi ut de värdet vi får på slutet.

            Result.Text = Convert.ToString(svar);

        }

        private void Avsluta_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

// Skapar en klass för metoden som vi ska använda.
public class Personnummer
{
    // Detta är sammanfattningen som funktionen nedanför bestämmer, vilket är alltså vad som kommer skrivas ut efteråt.
    public string sammanfattning;

    // Här så bestämmer vi vad som skrivs ut. Vi använder oss utav värdena som funktioner.
    public void CheckPrsn(string FNamn, string ENamn, string Nummer) 
    {

        // Om det är fel antal nummer i personnummret så säger vi till.
        if (Nummer.Length != 10) 
        {

            sammanfattning = "Något är fel med personnummret. Dubbellkolla det!";

        } else
        {
            // Nu skapar vi en Array från personnummret

            int[] värde = Nummer.Select(o => Convert.ToInt32(o) - 48).ToArray();

            // Innan vi gör något annat så kollar vi vilket kön användaren är.

            string Kön;

            if (värde[8] % 2 != 0) 
            {
                Kön = "Man";
            } else
            {
                Kön = "Kvinna";
            }

            // Här förbereder vi för while loopen som v i ska snart skapa

            int antal = 1;

            // Nu skapar vi den nämnda While-loopen, som går igenom vardera värde i Arrayen.

            while (antal <= Nummer.Length) 
            { 

                // Nu kollar vi om värdet på detta nummer är delbart med 2. Om det är det, så multiplicerar vi det med 2.
                // Annars så händer inget.
            
                if (antal % 2 != 0) 
                {

                    int plc = värde[antal - 1] * 2;

                    // Om det multiplicerade värdet är ett tiotal, så måste vi dela upp det och sedan addera de 2 nummrena.

                    if (plc.ToString().Length > 1) 
                    {

                        int plc1 = plc - 10;
                        int plc2 = (plc - plc1) / 10;
                        värde[antal - 1] = plc1 + plc2;

                        // Om inte, så blir det bara lika med det multiplicerade värdet.

                    } else
                    {

                        värde[antal - 1] = plc;

                    }

                }

                antal++;

            }

            // Nu adderar vi ihop alla värdena i arrayn till en slutgiltig integer kallad total

            int total = 0;

            foreach (int element in värde) 
            {

                total += element;   
                
            }

            // Nu ska vi bestämma om man får skriva ut alltet. Om total är delbart med 10, så får man allting utskrivet.
            // Annars så säger programmet till.

            if (total % 10 == 0) 
            {

                sammanfattning =
                    "Förnamn: " + FNamn + Environment.NewLine + Environment.NewLine +
                    "Efternamn: " + ENamn + Environment.NewLine + Environment.NewLine +
                    "Personnummer: " + Nummer + Environment.NewLine + Environment.NewLine +
                    "Kön: " + Kön;

            } else
            {
                sammanfattning = "Felaktigt Personnummer. Dubbelkolla om du skrev fel.";
            }

        }
    }

    // Här säger vi bara till vad classen ska skriva ut då vi säger till.
    public override string ToString()
    {
        return sammanfattning;
    }

}


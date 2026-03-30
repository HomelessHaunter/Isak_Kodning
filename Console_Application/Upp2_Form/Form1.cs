using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

// Skapar en ny klass som innehåller vardera värde som vi behöver skriva in.
public class Lista
{
    public string Namn { get; set; }
    public string Number { get; set; }
    public string Distrikt { get; set; }
    public int Antal { get; set; }

    public override string ToString()
    {
        return Namn + " " + Number + " " + Distrikt + " " + Antal;
    }

}

namespace Upp2_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Skapar en lista baserat på den klassen vi skapade ovan, så att vi kan använda oss utav variablerna i den.

        public List<Lista> lista = new List<Lista>();

        // Här ställer vi in så att man kan gå ur utan att spara. 
        // Om man vill göra det, så kommer ett varningsmeddelande som nämner att man kommer förlora allt.
        private void Quit_Click(object sender, EventArgs e)
        {

            var confirmResult = MessageBox.Show("Är du säker på att du vill avsluta utan att spara?",
                                     "Avsluta",
                                     MessageBoxButtons.YesNo);

            // Om du klickar på ja, så stänger allting.

            if (confirmResult == DialogResult.Yes)
            {

                Application.Exit();
            }

            // Om du klickar på nej, så går du tillbaks.

        }

        // Då du klickar på lägg till, så läggs den skrivna karaktären in i listan
        private void Add_Click(object sender, EventArgs e)
        {

            // Här lägger vi in de skrivna värdena i lsitan

            lista.Add(new Lista() 
            { 
                Namn = Convert.ToString(name.Text), 
                Number = Convert.ToString(number.Text),
                Distrikt = Convert.ToString(district.Text),
                Antal = Convert.ToInt32(amount.Text)
            }
            );

            // Nu tömmer vi textboxerna också, så att man kan fylla dom med nya ord.

            name.Text = string.Empty;
            number.Text = string.Empty;
            district.Text = string.Empty;
            amount.Text = string.Empty;

        }

        // Då man klickar på sammanställ knappen, så ska allting sorteras och sedan delas upp.
        // Sedan skrivs allt in i en fil.
        private void Finish_Click(object sender, EventArgs e)
        {
            // Nu sorterar vi hela listan efter antalet objekt man har sålt.

            lista.Sort(delegate (Lista x, Lista y) 
            {

                if (x.Antal == 0 && y.Antal == 0) return 0;
                else if (x.Antal == 0) return -1;
                else if (y.Antal == 0) return +1;
                else return x.Antal.CompareTo(y.Antal);

            });

            // Nu skriver vi in allting i en fil, samtidigt som vi delar upp det.

            string fileName = @"Samling.txt";

            // Först kollar vi om textfilen existerar, och om den gör det, så raderas den.

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            // Nu skriver vi allting in i textfilen på riktigt.

            using (StreamWriter sw = File.CreateText(fileName))
            {
                // Först så skriver vi ut vad vardera objekt är och i vilken ordning. Alltså titlarna.

                sw.WriteLine("Namn:" + "  " + "Personnummer:" + "  " + "Distrikt:" + "  " + "Antal:");

                // Skapar nu en variabel för vardera nivå, samtidigt som vi kollar vilka människor som hamnar var.

                var första = from f in lista
                             where f.Antal < 50
                             select f;

                var andra = from a in lista
                            where a.Antal >= 50 && a.Antal < 100
                            select a;

                var tredje = from t in lista
                             where t.Antal >= 100 && t.Antal < 200
                             select t;

                var fjärde = from j in lista
                             where j.Antal >= 200
                             select j;

                // Nu ser vi om någon person hamnade på vardera nivå, och om någon gjorde, så skriver vi ut vilka och
                // hur många.

                if (första.Count() != 0)
                {
                    foreach (var prsn in första)
                        sw.WriteLine(prsn.Namn + " " + prsn.Number + " " + prsn.Distrikt + " " + prsn.Antal);
                    sw.WriteLine(första.Count() + " personer är på nivå 1!" + Environment.NewLine);
                }

                if (andra.Count() != 0)
                {
                    foreach (var prsn in andra)
                        sw.WriteLine(prsn.Namn + " " + prsn.Number + " " + prsn.Distrikt + " " + prsn.Antal);
                    sw.WriteLine(andra.Count() + " personer är på nivå 2!" + Environment.NewLine);
                }

                if (tredje.Count() != 0)
                {
                    foreach (var prsn in tredje)
                        sw.WriteLine(prsn.Namn + " " + prsn.Number + " " + prsn.Distrikt + " " + prsn.Antal);
                    sw.WriteLine(tredje.Count() + " personer är på nivå 3!" + Environment.NewLine);
                }

                if (fjärde.Count() != 0)
                {
                    foreach (var prsn in fjärde)
                        sw.WriteLine(prsn.Namn + " " + prsn.Number + " " + prsn.Distrikt + " " + prsn.Antal);
                    sw.WriteLine(fjärde.Count() + " personer är på nivå 4!" + Environment.NewLine);
                }

                // Nu skriver vi sista meningen i dokumentet och öppnar det.

                sw.WriteLine("Det var alla!");

                Process.Start("Samling.txt");

            }

            // Nu stänger vi även programmet, då du är färdig skriven.

            Application.Exit();

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {


        }
    }
}

using System;

namespace Upp1
{
    class Program
    {

        static void Main(string[] args)
        {

            // Ger frågan om hur mycket det kostar.
            Console.WriteLine("Hur mycket kostar det?");

            // Låter nu användaren besvara frågan och omvandlar svaret till en integer kallad pris.
            int pris = int.Parse(Console.ReadLine());

            // Samma sak som ovan, bara att jag frågar om hur mycket pengar dom har istället.
            Console.WriteLine("Hur många kronor har du?");
            int peng = int.Parse(Console.ReadLine());

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

                decimal e = totalt / 20;
                decimal E = Decimal.Truncate(e);
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

                //500

                if (A == 1)
                {

                    Console.WriteLine(A + " femhundralapp.");

                } else if (A != 0)
                {

                    Console.WriteLine(A + " femhundralappar.");

                }

                // 200

                if (B == 1)
                {

                    Console.WriteLine(B + " tvåhundralapp.");

                } else if (B != 0)
                {

                    Console.WriteLine(B + " tvåhundralappar.");

                }

                //100

                if (C == 1)
                {

                    Console.WriteLine(C + " hundralapp.");

                } else if (C != 0)
                {

                    Console.WriteLine(C + " hundralappar.");

                }

                //50

                if (D == 1)
                {

                    Console.WriteLine(D + " femtilapp.");

                }
                else if (D != 0)
                {

                    Console.WriteLine(D + " femtilappar.");

                }

                //20

                if (E == 1)
                {

                    Console.WriteLine(E + " tjugolapp.");

                }
                else if (E != 0)
                {

                    Console.WriteLine(E + " tjugolappar.");

                }

                //10

                if (F == 1)
                {

                    Console.WriteLine(F + " tiokrona.");

                }
                else if (F != 0)
                {

                    Console.WriteLine(F + " tiokronor.");

                }

                //5

                if (G == 1)
                {

                    Console.WriteLine(G + " femkrona.");

                }
                else if (G != 0)
                {

                    Console.WriteLine(G + " femkronor.");

                }

                //2

                if (H == 1)
                {

                    Console.WriteLine(H + " tvåkrona.");

                }
                else if (H != 0)
                {

                    Console.WriteLine(H + " tvåkronor.");

                }

                //1

                if (totalt == 1)
                {

                    Console.WriteLine(totalt + " krona.");

                }
                else if (totalt != 0)
                {

                    Console.WriteLine(totalt + " kronor.");

                }

            } else // if else function för det ovan nämnda om man inte har råd.
            {

                Console.WriteLine("Det kostar för mycket, tag med mer pengar nästa gång.");

            }

          
        }
    }
}

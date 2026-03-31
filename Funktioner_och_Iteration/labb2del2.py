import math

# Skapar funktionen tvarsumman

def tvarsumman(x):

    # Skapar en variabel y som representerar x. Detta är för att x
    # kommer att byta värde senare. Vi skapar även variablerna z, a, b och c
    # eftersom dom behövs senare.
    
    y = x
    z = 0
    a = 0
    b = 0
    c = 0

    # Vi skapar en while loop som loopar så länge x har ett positivt värde.
    
    while x > 0:

        # Sedan skapar vi en if else loop. Detta är så att koden
        # funkar för nummer med fler än 2 sifforr.
        # För att inte skapa ett error,
        # så loopar den tills x är mindre än 10.
        
        if x >= 10:

            # Vi ändrar värdet av x så att den blir till värdet utav
            # nummret utan den sista siffran.
            
            x = math.floor( x / 10 )

            # Sedan så gör vi variabeln a till den sista siffran i nummret.
            
            a = y % ( x * 10 )

            # Nu sparar vi värdet utav den "sista" siffran i nummret,
            # tillsammans med alla dom förra "sista" siffrorna vi har
            # fått från dom andra iterationerna.
            
            c = b + a

            # För att nästa iteration ska bli korrekt så sätts värdet utav
            # b till c och y till x. 
            
            b = c
            y = x
            
        else:

            # Nu lägger vi ihop totalet tillsammans med den sista "sista"
            # nummret, vilket ger oss det sökta värdet.
            # Sedan har vi en break så att det inte blir en evig loop.
            
            z = x + c
            break

    return z

import d0028e_lab2_sumTest

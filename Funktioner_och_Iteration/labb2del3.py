import math

# Skapar funktionen avbetalningsplan

def avbetalningsplan(s, r, b):

    # Vi skapar variabeln tid, som representerar antalet år som har gått

    tid = 1

    # Skriver ut den sammanfattande listan.

    print("Årlig avbetalning:", b, "\nRäntesats:", r*100, \
          "\nIngående skuld:", s, "\n")

    # nu skapar vi en while-loop,
    # som skriver ut antalet av varje variabel varje år.
    # Vi ställer in så att den loopar tills skulden är betald.

    while s >= 0:

        # Vi skapar nya variabler som är det nya värdet för varje år,
        # förutom för skulden. Detta är så att while loopen kan fortfarande
        # läsa av skulden. Också för att räntan och avbetalningen är
        # konstanter, och får alltså inte förändras.
        
        R = s*r
        B = b-R
        s = s-B

        # Nu skapar vi en if-loop, så att värdet alltid blir 0 då
        # skulden är avbetald.
        # Vi sätter in en break och print i där också så att
        # skriptet inte evigt loopar.
        
        if s <= 0:
            s = 0
            print("-- År", tid, "--", "\nÅterstående skuld:", s, \
              "\nAmorterat belopp:", B, "\nRänta:", R, "\n")
            break

        # Här är själva printen som skriver upp informationen för varje år.
        # Som var redan nämnt så repeteras den ovan så att if-loopen
        # inte loopar för evigt.

        print("-- År", tid, "--", "\nÅterstående skuld:", s, \
              "\nAmorterat belopp:", B, "\nRänta:", R, "\n")

        # För varje år som går så ökar vi det med 1.
        
        tid = tid+1
    
    


avbetalningsplan(1000,0.005,25)

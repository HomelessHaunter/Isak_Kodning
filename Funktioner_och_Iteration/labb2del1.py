# Importerar matte funktionerna
import math

# Skapar variabeln logStar(x)
def logStar(x):
    
    # Skapar en variabel för att räkna antalet iterationer loopen tar,
    # och alltså säger hur många gånger man måste använda lorgaritmfunktonen
    # innan x =< 1
    
    count = 0

    # Skapar en while loop som loopar tills x =< 1, och ökar värdet på count
    
    while x > 1:
        x = math.log2(x)
        count = count + 1

    # Nu ges värdet av count
    
    return count

import d0028e_lab2_logStarTest.py

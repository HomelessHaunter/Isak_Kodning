import csv
import sys

# Skapar funktionen orddic som använder dictionary
# och ordlistan som orden sparas i

dict = {}

def orddic(val):

    # Skapar menyn
    
    #print("Vad vill du göra?")
    #val = input("1: Lägg till ett nytt ord. \n" +
              #  "2: Kolla upp ett ord. \n" +
              #  "3: Ta bort ett ord. \n" +
              #  "4: Stäng av programmet. \n")

    # Skapar nu dom olika valen

    # Första valet där man lägger till ett nytt ord

    if val == "1":
        ord = input("Vilket ord? \n")

        defin = input("Beskrivning utav ordet. \n")

        def tillägg(ord, defin):

            if ord in dict:
                print("Ordet finns redan!")

            else:
                dict[ord] = defin

        tillägg(ord,defin)
        meny()
        
    # Andra valet då man kollar upp definitionen av ett ord

    elif val == "2":
        sök = input("Vilket ord? \n")

        def beskrivning(sök):
            if sök in dict:
                print(dict[sök])

            else:
                print("Ord finns inte.")
            
        beskrivning(sök)
        meny()

    # Tredje valet där man tar bort ett ord

    elif val == "3":
        dlt = input("Vilket ord? \n")

        def bort(dlt):
            
            if dlt in dict:
                del dict[dlt]

            else:
                print("Ordet finns redan inte.")

        bort(dlt)
        meny()

    # Fjärde valet där man stänger programmet

    elif val == "4":
        print("Stänger ordlista")
        meny()
        return

    # Utifall du inte skrev in ett av valen

    else:
        print("Inte ett val, försök igen.")
        orddic()

# -----------------------------------------------------------------------------

# Skapar funktionen ordlist som använder list[], och list funktionerna

wordlist = []
defilist = []

def ordlist(val):
    
    # Skapar menyn
    
    #print("Vad vill du göra?")
    #val = input("1: Lägg till ett nytt ord. \n" +
      #          "2: Kolla upp ett ord. \n" +
       #         "3: Ta bort ett ord. \n" +
        #        "4: Stäng av programmet. \n")

    # Skapar nu dom olika valen

    # Första valet där man lägger till ett nytt ord

    if val == "1":
        ord = input("Vilket ord? \n")

        defin = input("Beskrivning utav ordet. \n")

        def tillägg(ord,defin):
            if ord in wordlist:
                print("Ord finns redan")
            else:
                wordlist.append(ord)

                defilist.append(defin)

        tillägg(ord,defin)
        meny()

    # Andra valet då man kollar upp definitionen av ett ord

    elif val == "2":
        sök = input("Vilket ord? \n")

        def beskrivning(sök):
            if sök in wordlist:

                i = 0

                while sök != wordlist[i]:
                    i = i+1

                print(defilist[i])

            else:
                print("Ord finns inte.")

        beskrivning(sök)
        meny()

    # Tredje valet där man tar bort ett ord

    elif val == "3":
        dlt = input("Vilket ord? \n")

        def bort(dlt):
            if dlt in wordlist:

                i = 0

                while dlt != wordlist[i]:
                    i = i+1

                wordlist.remove(dlt)
                defilist.remove(defilist[i])
                print("Ord bortaget!")

            else:
                print("Ord finns redan inte.")
        bort(dlt)
        meny()

    # Fjärde valet där man stänger programmet

    elif val == "4":
        print("Stänger ordlista")
        meny()
        return

    # Utifall du inte skrev in ett av valen

    else:
        print("Inte ett val, försök igen.")
        ordlist()

#------------------------------------------------------------------------------
# Skapar nu ordlistan som använder tupler och lsitan som tuplerna är i

tuplist = []

def ordtup(val):
    # Skapar menyn
    
    #print("Vad vill du göra?")
    #val = input("1: Lägg till ett nytt ord. \n" +
    #            "2: Kolla upp ett ord. \n" +
    #            "3: Ta bort ett ord. \n" +
    #            "4: Stäng av programmet. \n")

    # Skapar nu dom olika valen

    # Första valet där man lägger till ett nytt ord

    if val == "1":
        ord = input("Vilket ord? \n")
        defin = input("Beskrivning utav ordet. \n")

        def tillägg(ord, defin):

            tuplist.append(tuple((ord, defin)))

        tillägg(ord,defin)
        meny()

    # Andra valet då man kollar upp definitionen av ett ord

    elif val == "2":
        sök = input("Vilket ord? \n")

        def beskrivning(sök):
            i = 0

            while i < len(tuplist):
                if sök in tuplist[i]:

                # Skapar en tuple så att vi sedan
                # kan bara skriva ut beskrivningen
                # (Vilket är andra halvan av den)
                
                    ord = tuplist[i]
                    print(ord[1])
                    break

                else:
                    i = i+1
            else:
                print("Ord finns inte.")
                
        beskrivning(sök)
        meny()

    # Tredje valet där man tar bort ett ord

    elif val == "3":
        dlt = input("Vilket ord? \n")

        def bort(dlt):
            i = 0

            while i < len(tuplist):    
                if dlt in tuplist[i]:
                    tuplist.remove(tuplist[i])
                    break

                else:
                    i = i+1
            else:
                print("Ord finns redan inte.")
                
        bort(dlt)
        meny()

    # Fjärde valet där man stänger programmet

    elif val == "4":
        print("Stänger ordlista")
        meny()
        return

    # Utifall du inte skrev in ett av valen

    else:
        print("Inte ett val, försök igen.")
        ordtup()

#-------------------------------------------------------------------------------

# Skapar en meny för att jag är för lat för att skriva in funktionsnamnen
# La till att när man stänger ordlistorna så öppnas programmet också

def meny():
    x = 1
    print("Vad vill du göra?")
    val = input("1. Lägga till ord \n" +
                "2. Hitta definition \n" +
                "3. Ta bort ord \n" +
                "4. Inget \n")
    
    if val == "1":
        ordlista = input("Vilken ordlista vill du lägga in i? \n" +
                         "1. Dictionary \n" +
                         "2. List \n" +
                         "3. Tuple \n")
        if ordlista == "1":
            orddic(val)

        elif ordlista == "2":
            ordlist(val)

        elif ordlista == "3":
            ordtup(val)

    if val == "2":
        ordlista = input("Vilken ordlista vill du hitta din definition? \n" +
                         "1. Dictionary \n" +
                         "2. List \n" +
                         "3. Tuple \n")
        if ordlista == "1":
            orddic(val)

        elif ordlista == "2":
            ordlist(val)

        elif ordlista == "3":
            ordtup(val)

    if val == "3":
        ordlista = input("Vilken ordlista vill du ta bort ordet? \n" +
                         "1. Dictionary \n" +
                         "2. List \n" +
                         "3. Tuple \n")
        if ordlista == "1":
            orddic(val)

        elif ordlista == "2":
            ordlist(val)

        elif ordlista == "3":
            ordtup(val)

    if val == "4":
        print("Stänger Programmet")
        return

meny()

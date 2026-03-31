import pickle
import csv
import sys
import os.path

def telefonbok():
    kontakt = {}
    return kontakt

# Funktion för att lägga till namn
def create(namn, kontakt):
    #namn = input("Vem vill du lägga till? \n")

    # kollar om namnet finns redan
    if namn in kontakt:
        print("Namn finns redan.\n")

    else:
        kontakt[namn] = []
        print(namn + " tillagt!\n")
        return kontakt
        

# Lägg till nummer
def add(namn, nummer, kontakt):
    #namn = input("Vem vill du lägga till ett nummer till? \n")

    # Kollar om namnet finns redan
    if namn in kontakt:
        #nummer = input("Vilket nummer? \n")

        # Kollar om nummret finns redan i katalogen
        if any(nummer in val for val in kontakt.values()):
            
            # Kollar om nummret ligger under rätt namn
            if nummer in kontakt[namn]:
                print("Nummer redan där.\n")

            else:
                print("Nummer finns redan under annat namn.\n")

        else:
            kontakt[namn].append(nummer)
            print("Nummer tillagt. \n")
            return kontakt
            
    else:
       print("namn finns inte.\n")

       
# Kolla upp nummer på ett namn
def lookup(namn, kontakt):
    #namn = input("Vems nummer vill du kolla upp?")

    # Kollar om namnet finns
    if namn in kontakt:
        nummer = kontakt[namn]
        print("Här är alla av " + namn + "s telefonnummer.\n")
        for x in nummer:
            print(x)
        print("\n")
    else:
        print("namn finns inte.\n")

        
# Tar bort ett nummer från ett namn
def deletenu(namn, nummer, kontakt):

    # Kollar om namnet finns
    if namn in kontakt:
        lista = kontakt[namn]

        # kollar om nummret finns i listan
        if nummer in lista:
            i = 0

            # Letar efter nummret
            while nummer != lista[i]:
                i = i+1

            lista.remove(lista[i])
            print("Nummer borttaget.\n")
            return kontakt

        else:
            print("nummret finns redan inte. \n")

    else:
        print("namn finns inte.\n")

        
# Tar bort ett namn och alla nummer kopplade till det
def deletena(namn, kontakt):

    # Kollar om namnet finns, och tar sedan bort det om det gör det.
    if namn in kontakt:
        del kontakt[namn]
        print("Namn borttaget.\n")
        return kontakt

    else:
        print("Namn finns redan inte.\n")


# Skapar en fil och sparar allt på filen
def save(file, kontakt):
    
    # Öppnar/skapar en ny fil med namnet file
    f = open(file, "w")

    # Det första vi gör är att skriva Telefonnummer i filen
    f.write("Telefonnummer:\n")

    # Skapar en loop som gör en iteration för varje key i kontakt
    for x in kontakt:

        # Först så skrivs namnet på personen
        f.write(str(x) + ";")

        # Sedan kollar vi om det finns några nummer skrivna till personen
        if len(kontakt[x]) == 0:
            f.write("\n")

        # Om det gör det, så skriver vi ut alla numrena bredvid namnet
        else:
            nummer = kontakt[x]
            i = 0
            while i < len(nummer):
                f.write(str(nummer[i]) + ";")
                i = i + 1

            # Avslutar alltid med att placera nästa namn nedanför
            else:
                f.write("\n")

    f.close()
    print("Telefonbok sparad!")
        
# Laddar en fil och raderar allting som inte är sparat.
def load(file, kontakt):
    # Kollar om filen existerar
    if os.path.isfile(file) == True:
        f = open(file, "r")

        # Vi skippar första meningen i boken
        f.readline()

        # En while loop, där den håller på tills det inte finns fler rader
        while True:
            line = f.readline()
            if line == "":
                break

            # Skapar en list, som innehåller alla värden på raden
            values = line.split(";")

            # Sedan tar vi bort sista värdet, eftersom det är \n
            values.pop()

            # Nu sätter vi in värdena i dict kontakt,
            # där det första värdet är namnet och resten är
            # nummrena relaterade till namnen.
            kontakt[values[0]] = values[1:]
            
        f.close
        print("Laddat telefonbok!")
    
    else:
        print("Fil finns inte.")

    print(kontakt)
    return kontakt

    
# Dubbelkolla att allt fungerar
def read():
    print(kontakt)

# Stänger programmer
def quit():
    print("Stänger Programmet.")

# Skapar en meny som samlar ihop alla funktioner.
def meny(kontakt):
        
    x = input("Vad vill du göra? \n \n" +
          "CREATE: Lägg till ett nytt namn.\n" +
          "ADD: Lägg till ett nummer till ett namn.\n" +
          "LOOKUP: Kolla upp ett eller flera telefonnummer till en person.\n" +
          "DELETENU: Ta bort ett nummer från en person.\n" +
          "DELETENA: Ta bort ett namn och alla associerade telefonnummer.\n" +
          "SAVE: Spara denna telefonbok.\n" +
          "LOAD: Ladda en äldre telefonbok.\n" +
          "QUIT: Avsluta programmet. \n \n")

    if x == "CREATE" or x == "create":
        namn = input("Vilket namn? \n")
        create(namn, kontakt)
        meny(kontakt)

    elif x == "ADD" or x == "add":
        namn = input("Vem vill du lägga till ett nummer till?\n")
        nummer = input("Vilket nummer?\n")
        add(namn, nummer, kontakt)
        meny(kontakt)

    elif x == "LOOKUP" or x == "lookup":
        namn = input("Vem vill du kolla upp nummret till?\n")
        lookup(namn, kontakt)
        meny(kontakt)

    elif x == "DELETENU" or x == "deletenu":
        namn = input("Vem vill du ta bort ett telefonnummer till?\n")
        nummer = input("Vilket nummer?\n")
        deletenu(namn, nummer, kontakt)
        meny(kontakt)

    elif x == "DELETENA" or x == "deletena":
        namn = input("Vem vill du ta bort?\n")
        deletena(namn, kontakt)
        meny(kontakt)

    elif x == "SAVE" or x == "save":
        file = input("Vilket namn vill du ha på filen?\n")
        save(file, kontakt)
        meny(kontakt)

    elif x == "LOAD" or x == "load":
        file = input("Vilken fil vill du ladda?\n")
        load(file, kontakt)
        meny(kontakt)

    elif x == "QUIT" or x == "quit":
        print("Stänger program")

    else:
        print("Inte ett val.\n" +
              "Tänk på att bara använda bara stora eller små bokstäver.\n" +
              "Inte båda samtidigt!\n")
        meny()

meny(telefonbok())

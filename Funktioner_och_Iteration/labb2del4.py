import math

# Del a
# Skapar funktionen derivative

def derivative(f, x, h):

    # Skriver i den nämnda funktionen
    
    a = ( f(x+h) - f(x-h) ) / (2*h)
    return a

# 3 olika derivator, för att se om det fungerar.

#print(derivative(math.sin, 2, 2))
#print(derivative(math.sin, math.pi, 0.5))
#print(derivative(math.sin, 0.5, 0.25))

# Del b

# Skapar funktionen solve

def solve(f, x0, h):

    # Skapar variablerna xn, x1 och a som kommer att användas senare
    # xn är värdet på x, medans x1 är nästa värde på x
    # a räknar antalet iterationer, så att en del av loopen ska fungera.
    
    xn = x0
    x1 = x0+h+1
    a = 0

    # Skapar en while loop som håller på tills skillnaden mellan x1 och xn
    # blir mindre än h
    
    while abs(x1) >= h:

        # Först ökas värdet av a med 1
        
        a = a + 1

        # Sedan så skapar vi en if loop som kollar om det har varit mer än 1
        # iteration. Om det har varit, så sätts xn till det sista värdet av
        # x1.
        
        if a > 1:
            xn = x1

        # Nu skriver vi in formeln, och får alltså fram det nya värdet av x1

        x1 = xn - f(xn)/derivative(f, xn, h)

        print(x1) 

        # Här är att vi ser om värdet av x har slutat att förändrats,
        # och om det har gjort det, avsluta loopen.

        if x1 == xn:
            break

    # Efter loopen så får vi värdet av x1, vilket är alltså det sista värdet
    # av x
    
    return(x1)

import d0028e_lab2_solveTest


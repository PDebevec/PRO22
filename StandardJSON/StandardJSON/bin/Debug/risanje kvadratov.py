from calendar import c
from turtle import*
stevilokvadratov = int(input("koliko kvadratov želite?"))
d = int(input("kolikšna visina naj bo med njimi?"))
c = int(input("koliko narazen naj bojo?"))
b = int(input("koliko naj bo kvadrat velik?"))
sirina=c
visina=d
velicina=b

for a in range(stevilokvadratov):
    penup()
    goto(c,d)
    pendown()
    forward(b)
    left(90)
    forward(b)
    left(90)
    forward(b)
    left(90)
    forward(b)
    left(90)
    forward(b)
    c=sirina + c
    d=sirina + d




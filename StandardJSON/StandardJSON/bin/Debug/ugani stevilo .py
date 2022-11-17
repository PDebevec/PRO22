from random import randint


a=randint(0,99)
while "_":
    b=int(input("Izberi stevilo od 0 do 99:"))
    if b>a:
        print("stevilo je manjse")
    if b<a:
        print("stevilo je vecje")
    if b==a:
        print("bravo care")
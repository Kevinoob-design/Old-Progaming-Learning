import ramdon
import sys 

class coche():

    def __init__(self):
         self.Largo  = 250
         self.Ancho = 120
         self.__Ruedas = 4
         self.EnMarcha = False

    def arrancar(self, Parametro):
        self.EnMarcha = Parametro
        print(self.__Ruedas)

        if(self.EnMarcha):
            return "Se"

        else:
            return "Na"
        


MiCoche = coche()
print("El largo del coche es: ", MiCoche.Largo)

print(MiCoche.arrancar(True))

print("--------------------------------------")

ElOtroCoche = coche()
print("El largo del coche es: ", MiCoche.Largo)

print(MiCoche.arrancar(True))

ramdonnum = ramdon.randrange(0,100)
name = sys.stdin.readline()

  

    


    

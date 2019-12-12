from tkinter import *
from tkinter import ttk

#Ventana principal en la que se imrpimiran los Objetos.
root = Tk()

#Como crear labels, con parametros de BackColor y ForeColor, Textos y Fill.

'''
OneLabel = Label(root, text="hola que hace", bg="blue", fg="white")
TwoLabel = Label(root, text="hola que hace", bg="red", fg="white")
TreeLabel = Label(root, text="hola que hace", bg="black", fg="white")

OneLabel.pack()
TwoLabel.pack(fill=X)
TreeLabel.pack(side=LEFT, fill=Y)
'''

#Creacion de los Frame.
'''
TopFrame = Frame(root)
TopFrame.pack()

BottonFrame = Frame(root)
BottonFrame.pack(side=BOTTOM)
'''

#Codigo para desplegar Botones. Con respectivos parametros para color y lugar del que seran desplegados.
'''
btn1 = Button(TopFrame, text="El Boton 1", fg="red") 
btn2 = Button(TopFrame, text="El Boton 2", fg="green")
btn3 = Button(TopFrame, text="El Boton 3", fg="yellow")
btn4 = Button(BottonFrame, text="El Boton 4", fg="blue")

btn1.pack(side=LEFT)
btn2.pack(side=LEFT)
btn3.pack(side=LEFT)
btn4.pack(side=BOTTOM)
'''

#MainLoop, para mantener el programa corriendo.
root.mainloop()



from tkinter import *

class LaClase:

	def __init__(self,master):
		frame = Frame(master)
		frame.pack()

		self.btnPrint = Button(frame, text="Dale palla", command=self.PrintLaVaina)
		self.btnPrint.pack(side=LEFT)

		self.btnCerrar = Button(frame, text="Bye", command=frame.quit)
		self.btnCerrar.pack(side=LEFT)

	def PrintLaVaina(self):
		print("lol okey")

root = Tk()

b = LaClase(root)

root.mainloop()

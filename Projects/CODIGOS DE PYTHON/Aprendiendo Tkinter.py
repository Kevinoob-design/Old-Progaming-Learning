from tkinter import *

def DoNothing():
	print("ok :(")

root = Tk()

# ***** Creating the Main Menu *****

MenuPrincipal = Menu(root)
root.config(menu=MenuPrincipal)

SubMenu = Menu(MenuPrincipal)

MenuPrincipal.add_cascade(label="File", menu=SubMenu)

SubMenu.add_command(label="New Project", command=DoNothing)
SubMenu.add_command(label="New...", command=DoNothing)
SubMenu.add_separator()
SubMenu.add_command(label="Exit", command=DoNothing)

editMenu = Menu(MenuPrincipal)
MenuPrincipal.add_cascade(label="Edit", menu=editMenu)
editMenu.add_command(label="Redo", command=DoNothing)

# ***** Creating the Toolbar *****

toolbar = Frame(root, bg="blue")

insertButt = Button(toolbar, text="YOLO", command=DoNothing)
insertButt.pack(side=LEFT, padx=2, pady=2)

printButt = Button(toolbar, text="El YOLO", command=DoNothing)
printButt.pack(side=RIGHT, padx=2, pady=2)

printButt = Button(toolbar, text="THE NEW YOLO", command=DoNothing)
printButt.pack(fill=X, padx=2, pady=2)

toolbar.pack(side=BOTTOM, fill=X)

root.mainloop()

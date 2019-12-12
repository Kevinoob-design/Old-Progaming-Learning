// Juego de Naves.cpp: define el punto de entrada de la aplicación de consola.
//

#include <iostream>
#include <conio.h>

#include <stdio.h>
#include <Windows.h>

using namespace std;

int main()
{
	printf("*");

	HANDLE Aster; //El HENDDLE es que identifica las ventanas en el programa.
	Aster = GetStdHandle(STD_OUTPUT_HANDLE);

	COORD Posi; 
	Posi.X = 119;
	Posi.Y = 29;

	SetConsoleCursorPosition(Aster, Posi); //Esto es para dar posicion al cursor.

	printf("*");


	_getch();
    return 0;
}


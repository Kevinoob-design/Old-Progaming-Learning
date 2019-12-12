// 205 verticales
// 186 horizontales

#include <iostream>
#include <conio.h>
#include <windows.h>

using namespace std;
HANDLE Aster;

void Cuadro(int, int);
int X, Y, i = 2, I = 2;
int A = 1;

int main(){
	
	Aster = GetStdHandle(STD_OUTPUT_HANDLE);
	
	COORD Head;
	Head.X = 28;
	Head.Y = 0;
	
	cout << "Ingrese las dimensiones: "; 
	cin >> X;
	SetConsoleCursorPosition(Aster, Head);
	cout << "x"; cin >> Y;
	
	Cuadro(X,Y);
	
	i = 3;
	I = 3;
	A = A + 1;
	X = X - 1;
	Y = Y - 1;
	Cuadro(X,Y);
	
	i = 4;
	I = 4;
	A = A + 1;
	X = X - 1;
	Y = Y - 1;
	Cuadro(X,Y);

	i = 5;
	I = 5;
	A = A + 1;
	X = X - 1;
	Y = Y - 1;
	Cuadro(X,Y);
	
	i = 6;
	I = 6;
	A = A + 1;
	X = X - 1;
	Y = Y - 1;
	Cuadro(X,Y);
	
	_getch();
	return 0;
}

void Cuadro(int X, int Y){
	
	COORD Posi;
	
	for(i; i <= X-1; i++){
		
		Posi.X = i;
		Posi.Y = A;
		SetConsoleCursorPosition(Aster, Posi);
		cout << char(205);
		
		Posi.X = i; 
		Posi.Y = Y;
		SetConsoleCursorPosition(Aster, Posi);
		cout << char(205); 
	}
	for(I; I <= Y-1; I++){
		
		Posi.X = A; 
		Posi.Y = I;
		SetConsoleCursorPosition(Aster, Posi);
		cout << char(186);
		
		Posi.X = X;
		Posi.Y = I;
		SetConsoleCursorPosition(Aster, Posi);
		cout << char(186);
	}
}


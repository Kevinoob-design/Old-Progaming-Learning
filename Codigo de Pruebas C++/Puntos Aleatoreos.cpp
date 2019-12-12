#include <iostream>
#include <windows.h>
#include <stdlib.h>
#include <time.h>

using namespace std;

int cordX;
int cordY;
bool salir = false;

COORD Punto;

int main(){
	
	HANDLE Aster;
	Aster = GetStdHandle(STD_OUTPUT_HANDLE);
	
	COORD Posi[4];
	COORD Esq[4];
	COORD Head;
	Head.X = 50;
	Head.Y = 3;
	
	Esq[0].X = 2;
	Esq[0].Y = 1;
	SetConsoleCursorPosition(Aster, Esq[0]);
	cout << char(201);
	
	Esq[1].X = 117;
	Esq[1].Y = 1;
	SetConsoleCursorPosition(Aster, Esq[1]);
	cout << char(187);
	
	Esq[2].X = 2;
	Esq[2].Y = 28;
	SetConsoleCursorPosition(Aster, Esq[2]);
	cout << char(200);
	
	Esq[3].X = 117;
	Esq[3].Y = 28;
	SetConsoleCursorPosition(Aster, Esq[3]);
	cout << char(188);
	
	for(int i = 3; i <= 116; i++){
		
		Posi[0].X = i;
		Posi[0].Y = 1;
		
		if(i <= 5){
			
			for(int I = 2; I <= 27; I++){
				
				Posi[1].X = 2;
				Posi[1].Y = I;
				
				Posi[2].X = 117;
				Posi[2].Y = I;
				
				SetConsoleCursorPosition(Aster, Posi[1]);
				cout << char(186);
		
				SetConsoleCursorPosition(Aster, Posi[2]);
				cout << char(186);
			}
		}
		
		Posi[3].X = i;
		Posi[3].Y = 28;
		
		SetConsoleCursorPosition(Aster, Posi[0]);
		cout << char(205);
		
		SetConsoleCursorPosition(Aster, Posi[3]);
		cout << char(205);
	}
	
	do{
		
		srand (time(NULL));
		cordX = 3 + rand ()%(110);
		cordY = 3 + rand ()%(25);
		
		Punto.X = cordX;
		Punto.Y = cordY;
		
		SetConsoleCursorPosition(Aster, Punto);
		cout << "*";
		
	}while(salir == false);
	
	
	return 0;
}

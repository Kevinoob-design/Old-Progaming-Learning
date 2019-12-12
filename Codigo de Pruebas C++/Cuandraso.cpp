#include <iostream>
#include <windows.h>
#include <stdlib.h>

//205 derechas
// 186 laterales

using namespace std;

int X, Y;

int main(){
	
	HANDLE Aster;
	Aster = GetStdHandle(STD_OUTPUT_HANDLE);
	
	COORD Posi;
	COORD Ini;
	
	Ini.X = 80;
	Ini.Y = 0;
	SetConsoleCursorPosition(Aster, Ini);
	cout << " X > 1 && !> 117, Y > 1 && !> 28";
	
	Ini.X = 0;
	Ini.Y = 0;
	SetConsoleCursorPosition(Aster, Ini);
	cout << "Ingrese las dimensiones: "; 
	cin >> X; 
	
	Ini.X = 28;
	Ini.Y = 0;
	SetConsoleCursorPosition(Aster, Ini);
	cout << "x"; 
	
	Ini.X = 30;
	Ini.Y = 0;
	SetConsoleCursorPosition(Aster, Ini);
	cin >> Y;
	
	for(int i = 2; i <= X-1; i++){
		
		Posi.X = i;
		Posi.Y = 1;
		SetConsoleCursorPosition(Aster, Posi);
		cout << char(205);
		
		Posi.X = i;
		Posi.Y = Y;
		SetConsoleCursorPosition(Aster, Posi);
		cout << char(205);	
	}
	for(int I = 2; I <= Y-1; I++){
		
		Posi.X = X;
		Posi.Y = I;
		SetConsoleCursorPosition(Aster, Posi);
		cout << char(186);
		
		Posi.X = 1;
		Posi.Y = I;
		SetConsoleCursorPosition(Aster, Posi);
		cout << char(186);
	}
	
	Posi.X = 0;
	Posi.Y += 2;
	SetConsoleCursorPosition(Aster, Posi);
	system("pause");
	return 0;
}

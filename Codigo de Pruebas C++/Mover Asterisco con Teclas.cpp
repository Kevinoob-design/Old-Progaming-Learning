#include <iostream>
#include <conio.h>
#include <windows.h>

using namespace std;

void Cursor(int X, int Y){
	
	HANDLE Aster;
	Aster = GetStdHandle(STD_OUTPUT_HANDLE);
	
	COORD Posi;
	Posi.X = X;
	Posi.Y = Y;
	
	SetConsoleCursorPosition(Aster, Posi);
}

int main(){
	
	bool salir = false;
	int X = 30, Y = 10;
	Cursor(X,Y); cout << "*";
	
	while(!salir){
		
		if(kbhit()){
			
			char tecla = getch();
			Cursor(X,Y); cout << " ";
			if(tecla == 'a'){
				X--;
			}
			if(tecla == 'd'){
				X++;
			}
			if(tecla == 'w'){
				Y--;
			}
			if(tecla == 's'){
				Y++;
			}
			Cursor(X,Y); cout << "*";
		}
	}
	
	return 0;
}

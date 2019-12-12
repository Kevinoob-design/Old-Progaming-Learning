#include <iostream> //Librera principal
#include "conio.h"> // Libreria para el "Getch()"
#include <math.h> //Libreria para operaciones Matematicas (sqrt < para Raiz Cuadrada, pow < para elevar)

using namespace std;

int main(){
	
	cout << "INICIO \n" << endl;
	
	int a, b, c, resultado1 = 0, resultado2 = 0;
	
	cout << "En pantalla se imprimira x=-b + & - (sqrt(pow(b,2)-4(a)(c)/(2*a))" << endl;
	
	cout << "introduzca el valor de a: "; cin >> a;
	cout << "introduzca el valor de b: "; cin >> b;
	cout << "introduzca el valor de c: "; cin >> c;
	
	resultado1 = (-b + (sqrt((pow(b,2))-(4*a*c))))/(2*a);
	resultado2 = (-b - (sqrt((pow(b,2))-(4*a*c))))/(2*a);
	
	cout << "\nLos resultados son: " << resultado1 << " y " << resultado2 << endl;
	
	
	
	cout << "\n";
	cout << "FIN" << endl;
	
	
	getch();
	return 0;
}

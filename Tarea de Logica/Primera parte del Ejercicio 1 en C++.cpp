/*

Realizar un programa que dado los valores de una materia del ITSC 
que no utiliza laboratorio a nivel del primer parcial, segundo parcial, 
exposiciones y trabajos practicos y examen final. 
Evalue e imprima la LITERAL correspondiente en base al siguiente rango de valores:

90-100 = A
80-89 = B
70-79 = C
60-69 = D
0-59 = F 

Condiciones del Ejercicio

A) Realizar dicha solucion con ''IF'' anidado compuesto, Unario Ascendente.

*/

#include <iostream>
#include <stdlib.h>
#include <string.h>

using namespace std;

int nota1 = 0, nota2 = 0, nota3 = 0, nota4 = 0, nota5 = 0;
int notaf = 0;
string calificacion;

int main(){

	cout << "Ingrese las calificaciones del estudiante\n" << endl;
	
	cout << "Ingrese la calificacion del primer parcial: "; cin >> nota1;
	if((nota1 > 10) or (nota1 < 0)){
		
		cout << "\nLa nota del primer parcial debe estar en un intervalo de 0 a 10" << endl;
		do{
			cin >> nota1;
			
		} while((nota1 > 10) or (nota1 < 0));
	}
	
	cout << "Ingrese la calificacion del segundo parcial: "; cin >> nota2;
	if((nota2 > 10) or (nota2 < 0)){
		
		cout << "\nLa nota del segundo parcial debe estar en un intervalo de 0 a 10" << endl;
		do{
			cin >> nota2;
			
		} while((nota2 > 10) or (nota2 < 0));
	}
	
	cout << "Ingrese la calificacion del examen final: "; cin >> nota3;
	if((nota3 > 20) or (nota3 < 0)){
		
		cout << "\nLa nota del examen final debe estar en un intervalo de 0 a 20" << endl;
		do{
			cin >> nota3;
			
		} while((nota3 > 20) or (nota1 < 0));
	}
	
	cout << "Ingrese la calificacion de los trabajos en clase: "; cin >> nota4;
	if((nota4 > 40) or (nota4 < 0)){
		
		cout << "\nLa nota de los trabajos en clase debe estar en un intervalo de 0 a 40" << endl;
		do{
			cin >> nota4;
			
		} while((nota4 > 40) or (nota1 < 0));
	}
	
	cout << "Ingrese la calificacion en exposiciones: "; cin >> nota5;
	if((nota5 > 20) or (nota4 < 0)){
		
		cout << "\nLa nota de las exposiciones debe estar en un intervalo de 0 a 20" << endl;
		do{
			cin >> nota5;
			
		} while((nota5 > 20) or (nota1 < 0));
	}
	
	notaf = nota1+nota2+nota3+nota4+nota5;
	
	if(notaf <= 59){
		
		calificacion = "F";
	}
	else{
		
		if(notaf <= 69){
			
			calificacion = "D";
			
		}
		else{
			
			if(notaf <= 79){
				
				calificacion = "C";
			}
			else{
				
				if(notaf <= 89){
					
					calificacion = "B";
				}
				else{
					
					if(notaf <= 100){
						
						calificacion = "A";
					}
				}
			}
		}
	}

	cout << "\nSu nota final es de: " << notaf << " Y equivale a una literal de: " << calificacion << endl;

	system("pause");
	return 0;
}

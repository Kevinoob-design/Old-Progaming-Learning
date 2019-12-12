Algoritmo sin_titulo
	Escribir "Ingrese las calificaciones del estudiante";
	Escribir " ";
	Escribir "Ingrese la calificacion del primer parcial: "; Leer nota1;
	Si nota1 > 10 o nota1 < 0 Entonces
		Escribir "La nota del primer parcial debe estar en un intervalo de 0 a 10";
		Mientras nota1 > 10 o nota1 < 0 Hacer
			Leer nota1;
		Fin Mientras
	Fin Si
	
	Escribir "Ingrese la calificacion del segundo parcial: "; Leer nota2;
	Si nota2 > 10 o nota2 < 0 Entonces
		Escribir "La nota del segundo parcial debe estar en un intervalo de 0 a 10";
		Mientras nota2 > 10 o nota2 < 0 Hacer
			Leer nota2;
		Fin Mientras
	Fin Si
	
	Escribir "Ingrese la calificacion del examen final: "; Leer nota3;
	Si nota3 > 20 o nota3 < 0 Entonces
		Escribir "La nota del examen final debe estar en un intervalo de 0 a 20";
		Mientras nota3 > 20 o nota3 < 0 Hacer
			Leer nota3;
		Fin Mientras
	Fin Si
	
	Escribir "Ingrese la calificacion de los trabajos de clase: "; Leer nota4;
	Si nota4 > 40 o nota1 < 0 Entonces
		Escribir "La nota de los trabajos de clase debe estar en un intervalo de 0 a 40";
		Mientras nota4 > 40 o nota1 < 0 Hacer
			Leer nota4;
		Fin Mientras
	Fin Si
	
	Escribir "Ingrese la calificacion de las exposiciones: "; Leer nota5;
	Si nota5 > 20 o nota5 < 0 Entonces
		Escribir "La nota de las exposiciones debe estar en un intervalo de 0 a 20";
		Mientras nota5 > 20 o nota5 < 0 Hacer
			Leer nota5;
		Fin Mientras
	Fin Si
	
	notaf = nota1+nota2+nota3+nota4+nota5;
	
	Si notaf <= 100 y notaf >= 90 Entonces
		Escribir "Su calificacion literal es: A";
	Sino
		Si notaf <= 89 y notaf >= 80 Entonces
			Escribir "Su calificacion literal es: B";
			
		Sino
			Si notaf <= 79 y notaf >= 70 Entonces
				Escribir "Su calificacion literal es: C";
				
			Sino
				Si notaf <= 69 y notaf >= 60 Entonces
					Escribir "Su calificacion literal es: D";
					
				Sino
					Si notaf <= 59 y notaf >= 0 Entonces
						Escribir "Su calificacion literal es: F";
					FinSi
				FinSi
			FinSi
		FinSi
		
	Fin Si
FinAlgoritmo

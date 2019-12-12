Algoritmo sin_titulo
	// Equilatero todos iguales
	// isoceles dos iguales
	// Escaleno todos diferente
	Leer A,B,C
	Si A=B Entonces
		Si A=C Entonces
			Escribir 'Es un triangulo equilatero'
		Sino
			Escribir 'Es un triangulo isoceles'
		FinSi
	Sino
		Si B=C Entonces
			Escribir 'Es un triangulo isoceles'
		Sino
			Si A=C Entonces
				Escribir "Es un triangulo isoceles"
			Sino
				Escribir 'Es un triangulo Escaleno'
			FinSi
		FinSi
	FinSi
FinAlgoritmo


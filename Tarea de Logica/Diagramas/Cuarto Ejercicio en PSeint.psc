Algoritmo sin_titulo
	Escribir "introduzca los valores del tipo de triangulo deseado"
	Leer a, b, c
	
	Si ((a = b) y (a = c)) y ((b = a ) y (b =c)) y ((c = a ) y (c = b)) Entonces
		Escribir "Es un triangulo equilatero"
	Sino
		Si ((a = b) y (a != c)) y ((b  = a) y (b != c)) y ((c != a) y (c != b))o((a != B) y (a != c)) y ((b != a) y (b = c)) y ((c != a) y (c = b))o((a != b) y (a = c)) y ((b != a) y (b != c)) y ((c = a) y (c != b)) Entonces
			Escribir "Es un triangulo isoceles"
		Sino
			Si ((a != b) y (a != c) y (b != a) y (b != c) y (c != a) y (c != b)) Entonces
				Escribir "Es un triangulo escaleno"
			FinSi
			
		FinSi
	FinSi
FinAlgoritmo

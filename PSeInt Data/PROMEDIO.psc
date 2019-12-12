Algoritmo sin_titulo
	Escribir 'Calculadora de Promedio'
	Escribir ''
	Escribir 'Ingrese su nombre:'
	Leer NOMBRE
	Escribir 'Ingrese la cant. de notas a calcular'
	Leer X
	Resultados<-0
	Para i<-1 hasta X hacer
		Escribir 'Ingrese la Nota-',i,' :'
		Leer NOTA
		Resultados<-Resultados+NOTA
	FinPara
	Final<-Resultados/x
	Escribir 'El promedio de: ',NOMBRE,' Es de ', Final
	
FinAlgoritmo

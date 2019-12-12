Algoritmo sin_titulo
	Escribir 'Sueldo del empleado'
	Escribir ''
	Escribir 'Ingrese las Faltas del Empleado'
	Leer FALTAS
	Escribir 'Ingrese el Sueldo Diario del Empleado'
	Leer SueldoDiario
	SueldoQuincena<-SueldoDiario*15
	SueldoFinal<-SueldoQuincena-SueldoDiario*FALTAS
	Escribir 'El empleado tiene ' FALTAS ' Faltas, ' 'Su sueldo diario es de: ' SueldoDiario ' pesos, Su sueldo quincinal es: ' SueldoFinal ' pesos, Su estatus es: ' Sin Saltar
	Si SueldoFinal<6000 Entonces
		Escribir 'Bajo'
	FinSi
	Si SueldoFinal=6000 Entonces
		Escribir 'Promedio'
	FinSi
	Si SueldoFinal>6000 Entonces
		Escribir 'Sobresaliente'
	FinSi
FinAlgoritmo

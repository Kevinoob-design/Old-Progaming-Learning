Algoritmo sin_titulo
	Escribir 'Prueba de Conversacion2'
	Escribir ''
	Mientras VAR=VAR Hacer
		VAR<-Minusculas(VAR)
		Leer VAR
		Si VAR='hola' Entonces
			Escribir 'Hola'
		FinSi
		Si VAR='como estas' o VAR='como estas?' Entonces
			Escribir 'Bien, gracias por preguntar'
		FinSi
		Si VAR='que sabes hacer?'
			Escribir 'Solo puedo tener una conversacion limitada'
		FinSi
		Si VAR='en que puedes ayudarme'
			Escribir 'puedo ayudarte a pasar el rato tratando de conversar con migo'
		FinSi
		Si VAR='como te llamas'
			Escribir 'Mi nombre es Proyecto'
		FinSi
		Si VAR='que hora es?'
			Escribir 'Lo siento, no puedo darte la hora'
		FinSi
	FinMientras
FinAlgoritmo

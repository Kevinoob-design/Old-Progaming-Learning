Algoritmo sin_titulo
	Escribir 'Algoritmo para calcular descuentos'
	Escribir ''
	Escribir ''
	Escribir 'INTRODUZCA NOMBRE'
	Leer NOMBRE
	Escribir 'INTRODUZCA SU SUELDO'
	Leer Sueldo
	Escribir 'INTRODUZCA HORAS EXTRAS'
	Leer HR_EXTRA
	Escribir 'INTRODUZCA BONIFICACION'
	Leer BONO
	Escribir 'INTRODUZCA DEUDA A PAGAR'
	Leer DEUDA
	A<-(Sueldo*3.04)/100
    B<-(Sueldo*2.87)/100
	C<-A+B
	Sobra<-Sueldo-C
	Sobra2<-Sobra*12
	Si Sobra2>399923.01 Entonces
		Sobra3<-Sobra2-399923
		Sobra4<-(Sobra3*15)/100
		ISR<-Sobra4/12
	FinSi
	Si Sobra2>599884.01 Entonces
		Sobra3<-Sobra2-599884
		Sobra4<-(Sobra3*20)/100
		Sobra5<-Sobra4+29994
		ISR<-Sobra5/12
	FinSi
	Si Sobra2>833171.01 Entonces
		Sobra3<-Sobra2-833171
		Sobra4<-(Sobra3*25)/100
		Sobra5<-Sobra4+76652
		ISR<-(Sobra5/12)
	FinSi
	Final<-(Sobra+BONO+HR_EXTRA-DEUDA-ISR)
	Escribir '-------------------------------'
	
	Escribir 'NOMBRE ------------- ' NOMBRE  
	Escribir 'SUELDO  ------------ ' Sueldo 
	Escribir 'AFP ---------------- ' A 
	Escribir 'SFS ---------------- ' B 
	Escribir 'Otros Desc --------- ' DEUDA 
	Escribir 'Horas Ext ---------- ' HR_EXTRA 
	Escribir 'ISR ---------------- ' TRUNC(ISR)
	Escribir 'Sueldo NETO -------- ' TRUNC(Final)
	Escribir '-------------------------------'
FinAlgoritmo

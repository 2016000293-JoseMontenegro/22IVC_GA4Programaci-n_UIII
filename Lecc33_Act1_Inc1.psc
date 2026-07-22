Algoritmo Lecc33_Act1_Inc1
	Definir nombre, telefono Como Cadena
	Definir i, posicion Como Entero
	Dimensionar nombre(10)
	Dimensionar telefono(10)
	Escribir 'Nombre: José Montenegro'
	Escribir 'Grado: IVC - Clave = 22'
	Escribir '=====AGENDA TELEFÓNICA===='
	Para i<-1 Hasta 10 Con Paso 1 Hacer
		Escribir 'Persona ', i
		Escribir 'Nombre:'
		Leer nombre[i]
		Escribir 'Telefono:'
		Leer telefono[i]
	FinPara
	Escribir 'Ingrese una posicion del 1 al 10:'
	Leer posicion
	Si posicion>=1 Y posicion<=10 Entonces
		Escribir 'Nombre: ', nombre[posicion]
		Escribir 'Telefono: ', telefono[posicion]
	SiNo
		Escribir 'Posicion invalida'
	FinSi
FinAlgoritmo

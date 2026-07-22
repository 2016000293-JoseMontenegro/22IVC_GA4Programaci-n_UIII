Algoritmo Lecc33_Act2_Inc1
	Definir frase, invertir Como Cadena
	Definir i Como Entero
	Escribir 'Nombre: José Montenegro'
	Escribir 'Grado: IVC - Clave = 22'
	Escribir '=====INVERTIR FRASE===='
	Escribir 'Ingrese una frase:'
	Leer frase
	invertir <- ''
	Para i<-Longitud(frase)-1 Hasta 0 Con Paso -1 Hacer
		invertir <- invertir+Subcadena(frase,i,i)
	FinPara
	Escribir 'Frase invertida: ', invertir
FinAlgoritmo

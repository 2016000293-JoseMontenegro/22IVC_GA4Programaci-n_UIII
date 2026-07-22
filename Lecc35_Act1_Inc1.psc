Algoritmo Lecc35_Act1_Inc1
	Definir quetzales, dolares, euros, pesos, yenes, colones Como Real
	Definir respuesta Como Cadena
	Escribir 'Nombre: José Montenegro'
	Escribir 'Grado: IVC - Clave = 22'
	Escribir '=====MONEDAS===='
	Repetir
		Escribir 'Ingrese la cantidad en quetzales:'
		Leer quetzales
		dolares <- quetzales/7.70
		euros <- quetzales/8.40
		pesos <- quetzales*2.20
		yenes <- quetzales*19
		colones <- quetzales*66
		Escribir 'Dolares: ', dolares
		Escribir 'Euros: ', euros
		Escribir 'Pesos mexicanos: ', pesos
		Escribir 'Yenes: ', yenes
		Escribir 'Colones: ', colones
		Escribir 'Desea convertir otra cantidad (s/n):'
		Leer respuesta
		respuesta <- Minusculas(respuesta)
	Hasta Que respuesta='n'
FinAlgoritmo

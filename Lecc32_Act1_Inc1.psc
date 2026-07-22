Algoritmo Lecc32_Act1_Inc1
	Definir metros, resultado Como Real
	Definir opc Como Entero
	Escribir 'Nombre: José Montenegro'
	Escribir 'Grado: IVC - Clave = 22'
	Escribir '===== CONVERSIONES ====='
	Escribir 'Ingrese una medida en metros: '
	Leer metros
	Escribir 'MENU PRINCIPAL'
	Escribir '1. Milímetros'
	Escribir '2. Centímetros'
	Escribir '3. Decímetros'
	Escribir '4. Hectómetros'
	Escribir '5. Kilómetros'
	Escribir '6. Salir'
	Escribir 'Seleccione una opción: '
	Leer opc
	Según opc Hacer
		1:
			Escribir 'CONVERSIÓN A MILÍMETROS'
			resultado <- metros*1000
			Escribir metros, ' metros equivalen a ', resultado, ' milímetros'
		2:
			Escribir 'CONVERSIÓN A CENTÍMETROS'
			resultado <- metros*100
			Escribir metros, ' metros equivalen a ', resultado, ' centímetros'
		3:
			Escribir 'CONVERSIÓN A DECÍMETROS'
			resultado <- metros*10
			Escribir metros, ' metros equivalen a ', resultado, ' decímetros'
		4:
			Escribir 'CONVERSIÓN A HECTÓMETROS'
			resultado <- metros/100
			Escribir metros, ' metros equivalen a ', resultado, ' hectómetros'
		5:
			Escribir 'CONVERSIÓN A KILÓMETROS'
			resultado <- metros/1000
			Escribir metros, ' metros equivalen a ', resultado, ' kilómetros'
		6:
			Escribir 'Programa finalizado.'
		De Otro Modo:
			Escribir 'Opción inválida.'
	FinSegún
FinAlgoritmo

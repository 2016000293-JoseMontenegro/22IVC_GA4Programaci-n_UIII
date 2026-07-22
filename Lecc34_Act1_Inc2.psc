Algoritmo Lecc34_Act1_Inc2
	Definir peso, altura, imc Como Real
	Escribir 'Nombre: José Montenegro'
	Escribir 'Grado: IVC - Clave = 22'
	Escribir '=====MASA CORPORAL===='
	Escribir 'Ingrese el peso en kilogramos:'
	Leer peso
	Escribir 'Ingrese la altura en metros:'
	Leer altura
	Si peso<=0 O altura<=0 Entonces
		Escribir 'Los datos deben ser mayores que cero'
	SiNo
		imc <- peso/(altura*altura)
		Escribir 'IMC: ', imc
		Si imc<18.5 Entonces
			Escribir 'Clasificacion: Bajo peso'
		SiNo
			Si imc<25 Entonces
				Escribir 'Clasificacion: Peso normal'
			SiNo
				Si imc<30 Entonces
					Escribir 'Clasificacion: Sobrepeso'
				SiNo
					Escribir 'Clasificacion: Obesidad'
				FinSi
			FinSi
		FinSi
	FinSi
FinAlgoritmo

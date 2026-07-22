Algoritmo Lecc32_Act3_Inc1
	Definir lado1, lado2, lado3 Como Real
	Escribir 'Nombre: José Montenegro'
	Escribir 'Grado: IVC - Clave = 22'
	Escribir '=====TRIÁNGULOS===='
	Escribir 'Ingrese la primera medida: '
	Leer lado1
	Escribir 'Ingrese la segunda medida: '
	Leer lado2
	Escribir 'Ingrese la tercera medida: '
	Leer lado3
	Si lado1<=0 O lado2<=0 O lado3<=0 O lado1+lado2<=lado3 O lado1+lado3<=lado2 O lado2+lado3<=lado1 Entonces
		Escribir 'Medidas Inválidas'
	SiNo
		Si lado1=lado2 Y lado2=lado3 Entonces
			Escribir 'El triángulo es Equilátero'
		SiNo
			Si lado1=lado2 O lado2=lado3 Entonces
				Escribir 'El triángulo es Isósceles'
			SiNo
				Escribir 'El triángulo es Escaleno'
			FinSi
		FinSi
	FinSi
FinAlgoritmo

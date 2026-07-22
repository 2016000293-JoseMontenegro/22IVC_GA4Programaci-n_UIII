Algoritmo Lecc32_Act2_Inc1
	Definir signo Como Cadena
	Definir mes, dia Como Entero
	Escribir 'Nombre: José Montenegro'
	Escribir 'Grado: IVC - Clave = 22'
	Escribir '=====ZODIACAL Y HORÓSCOPO====='
	Escribir 'Ingrese su mes de nacimiento:'
	Leer mes
	Escribir 'Ingrese su dia de nacimiento:'
	Leer dia
	Si (mes=3 Y dia>=21) O (mes=4 Y dia<=19) Entonces
		signo <- 'Aries'
	SiNo
		Si (mes=4 Y dia>=20) O (mes=5 Y dia<=20) Entonces
			signo <- 'Tauro'
		SiNo
			Si (mes=5 Y dia>=21) O (mes=6 Y dia<=20) Entonces
				signo <- 'Geminis'
			SiNo
				Si (mes=6 Y dia>=21) O (mes=7 Y dia<=22) Entonces
					signo <- 'Cancer'
				SiNo
					Si (mes=7 Y dia>=23) O (mes=8 Y dia<=22) Entonces
						signo <- 'Leo'
					SiNo
						Si (mes=8 Y dia>=23) O (mes=9 Y dia<=22) Entonces
							signo <- 'Virgo'
						SiNo
							Si (mes=9 Y dia>=23) O (mes=10 Y dia<=22) Entonces
								signo <- 'Libra'
							SiNo
								Si (mes=10 Y dia>=23) O (mes=11 Y dia<=21) Entonces
									signo <- 'Escorpio'
								SiNo
									Si (mes=11 Y dia>=22) O (mes=12 Y dia<=21) Entonces
										signo <- 'Sagitario'
									SiNo
										Si (mes=12 Y dia>=22) O (mes=1 Y dia<=19) Entonces
											signo <- 'Capricornio'
										SiNo
											Si (mes=1 Y dia>=20) O (mes=2 Y dia<=18) Entonces
												signo <- 'Acuario'
											SiNo
												signo <- 'Piscis'
											FinSi
										FinSi
									FinSi
								FinSi
							FinSi
						FinSi
					FinSi
				FinSi
			FinSi
		FinSi
	FinSi
	Escribir 'Tu signo zodiacal es: ', signo
	Escribir 'Horoscopo: Todos tus deberes los podrás realizar en la mitad de tiempo de lo normal.'
FinAlgoritmo

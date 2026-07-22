Algoritmo Lecc35_Act1_Inc2
	Definir precio, pago, cambio, restante Como Entero
	Definir b200, b100, b50, b20, m10, m5, m1 Como Entero
	Escribir 'Nombre: José Montenegro'
	Escribir 'Grado: IVC - Clave = 22'
	Escribir '=====BILLETES===='
	Escribir 'Ingrese el precio del producto:'
	Leer precio
	Escribir 'Ingrese la cantidad con que pago:'
	Leer pago
	Si pago<precio Entonces
		Escribir 'El dinero entregado no es suficiente'
	SiNo
		cambio <- pago-precio
		restante <- cambio
		b200 <- Trunc(restante/200)
		restante <- restante MOD 200
		b100 <- Trunc(restante/100)
		restante <- restante MOD 100
		b50 <- Trunc(restante/50)
		restante <- restante MOD 50
		b20 <- Trunc(restante/20)
		restante <- restante MOD 20
		m10 <- Trunc(restante/10)
		restante <- restante MOD 10
		m5 <- Trunc(restante/5)
		restante <- restante MOD 5
		m1 <- restante
		Escribir 'Cambio total: Q', cambio
		Escribir 'Billetes de Q200: ', b200
		Escribir 'Billetes de Q100: ', b100
		Escribir 'Billetes de Q50: ', b50
		Escribir 'Billetes de Q20: ', b20
		Escribir 'Monedas de Q10: ', m10
		Escribir 'Monedas de Q5: ', m5
		Escribir 'Monedas de Q1: ', m1
	FinSi
FinAlgoritmo

LF = 10
MAXLINE = 79
UL = 32
	.data


menu:.asciz "\n1.suma\n2.resta\n3.multiplicación\n4.división\n5.cambio de base\nq.salir\n"

/* mensajes*/
m_error:.asciz  "opcion erronea, intentelo otra vez\n"
sumando:.asciz "Introduzca un sumando\n"
resultado:.asciz "Resultado:\n"
sustraendo:.asciz "Introduzca el sustraendo:\n"
minuendo:.asciz "Introduzca el minuendo:\n"
factor:.asciz "Introduzca un factor:\n"
divisor:.asciz "Introduzca el divisor:\n"
dividendo:.asciz "Introduzca el dividendo:\n"
set_base:.asciz "Introduzca la nueva base\nd: decimal, o: octal, h: hexadecimal, b:binario\n"
limite:.asciz "Demasiados caracteres cadena cortada\n"
intentar:.asciz "Vuelva a intentarlo\n"

operando1: .skip 80
operando2: .skip 80
cadena: .skip 80
	.text
	.global main

main:
	save%sp,-64,%sp

	mov 'd',%g3		!inicializa a base decimal
	clr %g4			!registro de errores
imprime_menu:
	set menu,%o0
	call imprime_cadena
	nop
	call getcharclr
	nop

/* comprueba que la opcion esta en el rango y sale con q*/
	
	cmp %o0, 'q'
	be salir
	nop

	cmp %o0,'1'
	bl error
	nop
	cmp %o0,'5'
	bg error
	nop

/* seleccion de opcion*/

	cmp %o0,'1'
	bne op2			!comprueba la siguiente opcion si no es 1
	nop
	call suma
	nop
	ba imprime_menu		!tras ejecutar la operacion vuelve al menu
	nop
op2:
	cmp %o0,'2'
	bne op3
	nop
	call resta
	nop
	ba imprime_menu
	nop
op3:
	cmp %o0,'3'
	bne op4
	nop
	call multiplicacion
	nop
	ba imprime_menu
	nop
op4:
	cmp %o0,'4'
	bne op5
	nop
	call division
	nop
	ba imprime_menu
	nop

op5:
	call cambio_base
	nop
	ba imprime_menu
	nop

salir:
	ret
	restore

error:
	set m_error,%o0
	call imprime_cadena
	nop
	ba imprime_menu
	nop


imprime_cadena: 
/*imprime una cadena terminada en /0 */
	save %sp, -64, %sp
	clr%l1
bucle_ic:
	ldub [%i0 +%l1], %o0
	cmp %g0, %o0
	be salir_ic
	nop
	call putchar
	inc%l1
	ba bucle_ic
	nop
salir_ic:	
	ret
	restore


lee_cadena:
/*lee una cadena terminada en /0 */
	save%sp, -64,%sp
	set cadena,%i0
	clr %l1
bucle_lc:
	call getchar
	nop
	stb %o0,[%i0+%l1]
	cmp %l1, MAXLINE
	be limite_lc
	nop
	cmp %o0,LF
	bne bucle_lc
	inc %l1
	dec %l1
	stb %g0,[%i0+%l1]
	ba salir_lc
	nop
limite_lc:
	set limite, %o0
	call imprime_cadena
	stb %g0,[%i0+%l1]
	nop
salir_lc:
	ret
	restore

getcharclr:
/* Se define para leer un solo caracter y limpiar el buffer*/

	save %sp, -64, %sp
	clr %l1

	call getchar
	nop
	mov %o0, %i0
bucle_cc:
	call getchar
	nop
	cmp %o0, LF
	bne bucle_cc
	nop
	ret
	restore


suma:
/*suma dos numeros usando un conversor*/
	save %sp, -64, %sp
sumando1:
	set sumando, %o0
	call imprime_cadena
	nop
	call lee_cadena
	nop
	call conversor
	nop
	cmp %g4, 1
	bne continua1s
	clr %g4
	set intentar, %o0
	call imprime_cadena
	nop
	ba sumando1
	nop
continua1s:
	mov %o1, %l1
sumando2:
	set sumando, %o0
	call imprime_cadena
	nop
	call lee_cadena
	nop
	call conversor
	nop
	cmp %g4, 1
	bne continua2s
	clr %g4
	set intentar, %o0
	call imprime_cadena
	nop
	ba sumando2
	nop
continua2s:
	mov %o1, %l2
	addcc %l1, %l2, %o1
	set resultado, %o0
	call imprime_cadena
	nop
	call iconversor
	nop
	ret
	restore


resta:
/*resta dos numero en diferentes bases*/
	save %sp, -64, %sp
sustraendo1:
	set sustraendo, %o0
	call imprime_cadena
	nop
	call lee_cadena
	nop
	call conversor
	nop
	cmp %g4, 1
	bne continua1r
	clr %g4
	set intentar, %o0
	call imprime_cadena
	nop
	ba sustraendo1
	nop
continua1r:
	mov %o1, %l1
minuendo1:
	set minuendo, %o0
	call imprime_cadena
	nop
	call lee_cadena
	nop
	call conversor
	nop
	cmp %g4, 1
	bne continua2r
	clr %g4
	set intentar, %o0
	call imprime_cadena
	nop
	ba minuendo1
	nop
continua2r:
	mov %o1, %l2
	subcc %l1, %l2, %o1
	set resultado, %o0
	call imprime_cadena
	nop
	call iconversor
	nop
	ret
	restore


multiplicacion:
/*multiplica dos numeros en diferentes bases*/
	save %sp, -64, %sp
factor1:
	set factor, %o0
	call imprime_cadena
	nop
	call lee_cadena
	nop
	call conversor
	nop
	cmp %g4, 1
	bne continua1m
	clr %g4
	set intentar, %o0
	call imprime_cadena
	nop
	ba factor1
	nop
continua1m:
	mov %o1, %l1
factor2:
	set factor, %o0
	call imprime_cadena
	nop
	call lee_cadena
	nop
	call conversor
	nop
	cmp %g4, 1
	bne continua2m
	clr %g4
	set intentar, %o0
	call imprime_cadena
	nop
	ba factor2
	nop
continua2m:
	mov %o1, %l2
	mulx %l1, %l2, %o1
	set resultado, %o0
	call imprime_cadena
	nop
	call iconversor
	nop
	ret
	restore


division:
/*multiplica dos numeros en diferentes bases*/
	save %sp, -64, %sp
dividendo1:
	set dividendo, %o0
	call imprime_cadena
	nop
	call lee_cadena
	nop
	call conversor
	nop
	cmp %g4, 1
	bne continua1d
	clr %g4
	set intentar, %o0
	call imprime_cadena
	nop
	ba dividendo1
	nop
continua1d:
	mov %o1, %l1
divisor1:
	set divisor, %o0
	call imprime_cadena
	nop
	call lee_cadena
	nop
	call conversor
	nop
	cmp %g4, 1
	bne continua2d
	clr %g4
	set intentar, %o0
	call imprime_cadena
	nop
	ba divisor1
	nop
continua2d:
	mov %o1, %l2
	udivx %l1, %l2, %o1
	set resultado, %o0
	call imprime_cadena
	nop
	call iconversor
	nop
	ret
	restore


cambio_base:
	save %sp, -64, %sp
bucle_cb:
	set set_base, %o0
	call imprime_cadena
	nop
	call getcharclr
	nop
	cmp %o0, 'd'
	be fin_cb
	cmp %o0, 'b'
	be fin_cb
	cmp %o0, 'h'
	be fin_cb
	cmp %o0, 'o'
	be fin_cb
	nop
	set m_error, %o0
	call imprime_cadena
	nop
	ba bucle_cb
fin_cb:
	mov %o0, %g3
	nop
	ret
	restore

conversor:

	save %sp, -64, %sp
	clr %l1
	clr %l3

	cmp %g3,'d'
	bne basehc
	nop	

/*convierte desde un decimal ascii a binario*/
	/*logitud de la cadena*/
	clr %l3
	mov 1, %l1		!potencias de 10
	clr %i1
longd:
	ldub [%i0+%l3], %l2
	cmp %l2, %g0
	bne longd
	inc %l3
	/*convertir numero*/
	dec 2, %l3
bucled:
	ldub [%i0+%l3], %l2
	cmp %l3, %g0
	bl finc
	dec '0', %l2
	mulx %l2, %l1, %l2
	add %l2, %i1, %i1
	mulx %l1, 10, %l1
	ba bucled
	dec %l3


basehc:
	cmp %g3,'h'
	bne baseoc
	nop

/*convierte desde un hexadecimal ascii a binario*/

/*	convierte una cadena a mayusculas
	clr %l1
bucle2_tu:

	ldub [%i0+%l1], %l2
	cmp %l2, %g0
	be fin_tu
	nop
	cmp %l2, 'a'
	bl ignorar_tu
	nop
	cmp %l2, 'z'
	bg ignorar_tu
	nop
	dec UL, %l2
	stb %l2, [%i0+%l1]
ignorar_tu:
	cmp%g0,%l1
	bne bucle2_tu
	inc %l1
fin_tu:
*/
	/*validar numero hexadecimal*/
	clr %l1
bucle_vh:
	ldub [%i0+%l1], %l2
	nop
	cmp %l2, %g0
	be fin_vh
	nop
	cmp %l2, '0'
	bl error_vh
	nop
	cmp %l2, '9'
	ble ok_vh
	nop
	cmp %l2, 'A'
	bl error_vh
	nop
	cmp %l2, 'F'
	ble ok_vh
	nop
error_vh:
	mov 1, %g4
	ba finc
	nop
ok_vh:
	ba bucle_vh
	inc %l1
fin_vh:
/*convertir numero*/
	clr %l1
bucleh:
	ldub [%i0+%l1], %l2
	cmp %l2, %g0
	be finh
	cmp%l2, 'A'
	bl digitoh
	nop
	dec 55,%l2
	ba desplazah
	nop
digitoh:
	dec '0',%l2
desplazah:
	sll %l3, 4, %l3	
	or %l3,%l2,%l3
	ba bucleh
	inc %l1 
finh:
	mov %l3,%i1
	ba finc
	nop

baseoc:
	cmp %g3,'o'
	bne basebc
	nop

/*convierte desde un octal ascii a binario*/

	ba finc
	nop

basebc:
/*convierte desde un binario ascii a binario*/

	nop
finc:
	ret
	restore



iconversor:
/*convierte desde binario a la base actual  e imprime el resultado*/


	save %sp, -64, %sp
	clr %l1
	clr %l3

	cmp %g3,'d'
	bne basehic
	nop	
/*convierte desde un binario a decimal*/
	clr %l1
	set cadena, %i0
	cmp %i1, %g0
	bne bucleid
	nop
	mov '0', %o0
	call putchar
	nop
	ba finic
bucleid:
	mov %i1, %o0
	udivx %o0, 10, %o0
	mulx %o0, 10, %o0
	sub %i1, %o0, %o0
	inc '0', %o0
	udivx %i1, 10, %i1
	stb %o0, [%i0+%l1]
	cmp %i1, %g0
	be imprimed
	nop
	ba bucleid
	inc%l1
imprimed:
	ldub [%i0+%l1], %o0
	call putchar
	nop
	cmp %l1, %g0
	bne imprimed
	dec %l1
	ba finic
	nop
	
basehic:
	cmp %g3,'h'
	bne baseoic
	nop
	
/*convierte desde un hexadecimal ascii a binario
convertir numero*/

	clr %l4			!bandera para eliminar primeros ceros
	mov 15, %l2		!mascara
	mov 28, %l1		!empezar por los primeros digitos
	cmp %i1, %g0
	bne bucleih
	nop
	mov '0', %o0
	call putchar
	nop
	ba finic
	nop
bucleih:

	nop
	mov %i1, %o0
	srl %o0, %l1, %o0
	and %o0, %l2, %o0
	cmp %o0, 9
	bg letraic
	nop
	cmp %o0, %g0
	bne nozero
	nop
	cmp %l4, %g0
	be bucleih
	dec 4, %l1
	
nozero:
	inc '0', %o0
	call putchar
	mov 1, %l4
	cmp %l1, %g0
	be finic
	nop
	ba bucleih
	dec 4, %l1
letraic:
	inc 55, %o0
	call putchar
	mov 1, %l4
	cmp %l1, %g0
	be finic
	nop
	ba bucleih
	dec 4, %l1
	nop	

baseoic:
	cmp %g3,'o'
	bne basebic
	nop

/*convierte desde un octal ascii a binario*/

	ba finic
	nop

basebic:
/*convierte desde un binario ascii a binario*/

	nop
finic:
	mov LF, %o0
	call putchar
	nop
	ret
	restore

;El programa calcula el area de un triangulo de lados a,b,c
;emplea la formula Area=[s(s-a)(s-b)(s-c)]^0.5 con s=s(a+b+c)
;Devuelve por pantalla el area
;Se usan las funciones printf y scanf de c para recibir e imprimir los datos


segment .data
msgPedirDatos db "Introduzca los tres lados del triangulo\n",0
fRecogerDatos db "%lf%lf%lf"
fResultado db "Area triangulo: %f",10,0 

segment .bss

a resq 1
b resq 1
c resq 1
s resq 1 ;semiperimetro


segment .text
global pract6
extern printf, scanf

pract6:
    enter 0,0
    pusha

    push c
    push b
    push a
    push fRecogerDatos
    call scanf
    add esp, 16

    ;calculo semiperimetro
    fld qword [a]
    fadd qword [b]
    fadd qword [c]
    mov dword [s], 2 ; s aun no ha sido usada
    fidiv dword [s]

    ;imprimir resultado
    fstp qword [a]
    push dword [a+4]
    push dword [a]
    push fResultado
    call printf
    add esp, 12

    popa
    leave
    ret

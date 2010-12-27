;El programa calcula el area de un triangulo de lados a,b,c
;emplea la formula Area=[s(s-a)(s-b)(s-c)]^0.5 con s=s(a+b+c)
;Devuelve por pantalla el area
;Se usan las funciones printf y scanf de c para recibir e imprimir los datos
;Retorna 0 si se ha ejecutado correctamente

segment .data
msgPedirDatos db "Introduzca los tres lados del triangulo",10,0
fRecogerDatos db "%lf%lf%lf"
fResultado db "Area triangulo: %f",10,0
msgErrorLectura db "No se han leido correctamente los lados", 10, 0
msgErrorTriangulo db "El triangulo introducido es imposible", 10, 0
msgErrorSigno db "Alguno de los lados introducido es negativo", 10, 0

segment .bss
a resq 1 ;lado a
b resq 1 ;lado b
c resq 1 ;lado c

segment .text
global pract6
extern printf, scanf

pract6:
    enter 0,0 ;no se usa pusha porque no se usan reg reservados en c

    ;leer operandos
    push msgPedirDatos
    call printf
    push c
    push b
    push a
    push fRecogerDatos
    call scanf
    add esp, 20
    cmp eax, 3
    jne errorScanf
    
    ;comprobar signos
    mov eax, [a+4] ;[dir+4] contiene la parte alta del double
    or eax, [b+4]
    or eax, [c+4]
    shl eax, 1 ;el carry lleva 1 si algun signo era 1
    jc errorSigno

    ;inicializar y cargar pila de punto flotante con a, b y c
    finit
    fldz ;necesario para comprobar triangulo imposible
    fld qword [a]
    fld qword [b]
    fld qword [c]

    ;calcular el semiperimetro
    fld st0 ;st1 y st0 tienen c
    fadd st2
    fadd st3
    mov word [a], 2 ;el lado en [a] ya no era necesario
    fidiv word [a] ;st0 tiene el semiperimetro

    ;calculo area
    fsubr st3, st0 ;st3 = s-a
    fsubr st2, st0 ;st2 = s-b
    fsubr st1, st0 ;st1 = s-c
    fmulp st1 ;st0 = s(s-c)
    fmulp st1 ;st0 = s(s-c)(s-b)
    fmulp st1 ;st0 = s(s-c)(s-b)(s-a)
    ;comprobar triangulo valido, si st0 negativo triangulo imposible
    fcomi st0, st1
    ;ftst habria comparado tambien con 0 pero no hay version para eflags
    jb errorTriangulo
    fsqrt ;st0 = s(s-a)(s-b(s-c)^0.5 = area

    ;imprimir resultado
    sub esp, 8
    fstp qword [esp] ;equivalente a push [dir+4]; push[dir] desde dir memoria
    push fResultado
    call printf
    add esp, 12
    mov eax, 0
    jmp short salir

errorScanf:
    push msgErrorLectura
    call printf
    pop eax
    jmp short salir

errorTriangulo:
    push msgErrorTriangulo
    call printf
    pop eax
    jmp short salir

errorSigno:
    push msgErrorSigno
    call printf
    pop eax

salir:
    leave
    ret

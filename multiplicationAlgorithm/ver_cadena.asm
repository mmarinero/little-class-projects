;Imprime una cadena  que no termina en 0 por medio de la interrupcion 80
;Parametro entrada 1: Longitud de la cadena
;Parametro entrada 2: Dirección memoria cadena
%define longCadena ebp + 8
%define cadena ebp + 12

segment .text
global ver_cadena

ver_cadena:
    enter 0, 0
    pusha
    mov eax, 4
    mov ebx, 1
    mov ecx, [cadena]
    mov edx, [longCadena]
    int 80h
    popa
    leave
    ret

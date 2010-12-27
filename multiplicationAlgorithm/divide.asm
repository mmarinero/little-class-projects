;Divide dos numeros con el algoritmo de division sin restauracion
;parametro entrada 1: dividendo
;parametro entrada 2: divisor
;parametro salida 1: resultado
%define dividendo ebp + 8
%define divisor ebp + 12

segment .data
msgRegB db "Reg B: "
longMsgRegB equ $-msgRegB
cabecera db 10, "Reg A                            Reg MQ                           contador",10
longCabecera equ $-cabecera
fLinea db 10
longFLinea equ 1
msgDivCero db "Estas dividendo entre 0, el resultado sera erroneo",10
longMsgDivCero equ $-msgDivCero

segment .text
global divide
extern ver_bin, ver_cadena, ver_num ;ver_bin esta en pract4.asm

divide:
    enter 0,0
    pusha

;imprimir cabecera ----------------------
    push msgRegB
    push longMsgRegB
    call ver_cadena
    add esp, 8
    push dword [dividendo]
    call ver_bin
    pop eax
    push cabecera
    push longCabecera
    call ver_cadena
    add esp,8
;------------------------------------------

;inicializacion
    mov eax, 0 ;registro A
    mov edx, [dividendo] ;registro MQ
    mov ebx, [divisor]; registro B
    ;tratamiento de signos
    mov esi, ebx
    xor esi, edx ;el ultimo bit de esi vale 1 si resultado negativo
    cmp edx, 0
    jge testEbx
    neg edx
testEbx:
    cmp ebx, 0
    jg continua
    jne niega ;si no salta se esta dividendo entre 0
    push msgDivCero
    push longMsgDivCero
    call ver_cadena
    add esp, 8
niega:
    neg ebx
continua:
    mov ecx, 31 ;N-1 en registros de 32 bits
    shl edx, 1 ;desplazamiento
    rcl eax, 1
    sub eax, ebx ;A-B

bucle:
    jmp iRegistros
rImprimidos:
    cmp eax, 0
    jl menor
    ;A>0
    or edx, 1; MQ0 <- 1
    shl edx, 1;desplazar
    rcl eax, 1
    sub eax, ebx; A-B
    loop bucle
    jmp comprobarA
menor:
    ;A<0
    shl edx, 1 ;desplazamiento
    rcl eax, 1
    add eax, ebx ;A+B
    loop bucle

comprobarA:
    cmp eax,0
    jl menor2
    ;A>0
    or edx, 1 ;MQ0 <- 1
    jmp iRegistros
menor2:
    ;A<0
    add eax, ebx ;A+B -> A

iRegistros:
;imprimir registros ------------------------------------
    ;se deben imprimir al principio de cada bucle y al ir a salir
    push eax
    call ver_bin
    push edx
    call ver_bin
    push ecx
    call ver_num
    push fLinea
    push longFLinea
    call ver_cadena
    add esp, 20 ;liberamos de una vez todo el espacio
    cmp ecx, 0 ;saber si el bucle ha terminado
    jne rImprimidos
;----------------------------------------
    ;signo
    rcl esi, 1 ;el ultimo bit de esi tiene el signo y ahora el carry
    jnc continua2
    neg edx
continua2:
    mov dword [divisor], edx
    popa
    leave
    ret

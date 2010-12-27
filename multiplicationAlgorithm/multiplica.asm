;Multiplica dos numeros con el algoritmo de solapamiento de ternas
;internamente multiplica en 64 bits estando estos en A-MQ
;el resultado se devuelve solo los 32 bits mas bajos, sin control de overflow

;parametro entrada 1: Multiplicando
;parametro entrada 2: Multiplicador
;parametro salida 1: Resultado
%define multiplicando ebp + 8
%define multiplicador ebp + 12

segment .data
msgRegB db "Reg B: "
longMsgRegB equ $-msgRegB
cabecera db 10, "Reg A                            Reg MQ                        MQ-1 contador",10
longCabecera equ $-cabecera
fLinea db 10
longFLinea equ 1

segment .text
global multiplica
extern ver_bin, ver_cadena, ver_num ;ver_bin esta en pract4.asm

multiplica:
    enter 0,0
    pusha

;imprimir cabecera ----------------------
    push msgRegB
    push longMsgRegB
    call ver_cadena
    add esp, 8
    push dword [multiplicando]
    call ver_bin
    pop eax
    push cabecera
    push longCabecera
    call ver_cadena
    add esp,8
;------------------------------------------

;inicializacion
    mov eax, 0 ;registro A
    mov edx, [multiplicador] ;registro MQ
    mov ebx, [multiplicando]; registro B
    mov ecx, 16 ;registros de 32 bits
    mov esi, 0 ;mq-1 
bucle:
    jmp short iRegistros
rImprimidos:
    ;determinar la operacion necesaria en funcion de mq1,mq0,mq-1
    ;se implementa para ello una tabla de saltos que permite evitar las comparaciones
    mov edi, edx
    and edi, 0x00000003
    shr esi, 1
    rcl edi, 2 ;mq1, mq0, mq-1 estan en edi y se rota otra vez haciendo
               ;edi*2 porque las instrucciones de salto corto son de dos bytes
    add edi, $+8 ;se suma 8 porque esta instruccion ocupa 6 bytes y jmp edi otros 2
    jmp edi 
    ;
    ;tabla de saltos
    ;
    jmp short desplazar ;cadena de unos, no se hace nada
    jmp short unodos ;final de cadena de unos, se suma A+B con 1 y 2 hay que hacer lo mismo
    jmp short unodos ;1 aislado, se suma A+B
    jmp short tres ;final de cadena de unos, se suma A+2B
    jmp short cuatro ;comienzo de cadena de unos, se resta A-2B
    jmp short cincoseis ;cero aislado, se resta A-B
    jmp short cincoseis ;comienzo de cadena de unos, se resta A-B
    jmp short desplazar ;cadena de unos, no hacer nada

tres:
    add eax, ebx ;tres hace dos sumas y asi ahorramos instrucciones 
unodos:
    add eax, ebx
    jmp short desplazar
cuatro:
    sub eax, ebx 
cincoseis:
    sub eax, ebx
desplazar:
    shrd edx, eax, 2 ;desplazar mq
    rcl esi, 1 ;fijar mq-1
    sar eax,2 ;desplazar A
    loop bucle

iRegistros:

;imprimir registros ------------------------------------
    ;se deben imprimir al principio de cada bucle y al ir a salir
    push eax
    call ver_bin
    push edx
    call ver_bin
    push esi
    call ver_num
    push ecx
    call ver_num
    push fLinea
    push longFLinea
    call ver_cadena
    add esp, 24 ;liberamos de una vez todo el espacio
    cmp ecx, 0 ;saber si el bucle ha terminado
    jne rImprimidos
;----------------------------------------

    mov dword [multiplicador], edx
    popa
    leave
    ret
